using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmAvailableStaff : Form
    {
        #region Fields

        private SqlConnection con;
        private DataGridViewRow dataRow;
        private bool finishedAssignment;
        private FrmRotaControl senderForm;

        #endregion Fields

        #region Constructors

        public frmAvailableStaff(DataGridViewRow dgvr, SqlConnection sqlc, ref bool fin, FrmRotaControl sender)
        {
            InitializeComponent();
            Icon = Studio2RotaControl.Properties.Resources.logo_small;
            dataRow = dgvr;
            con = sqlc;
            finishedAssignment = fin;
            senderForm = sender;
        }

        #endregion Constructors

        #region Methods

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lbxApplicableStaff.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select a user for this role", "No user selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> conflicts = new List<string>();
            int roleID = Convert.ToInt32(dataRow.Cells[0].Value);
            int staffID = Convert.ToInt32(lbxApplicableStaff.SelectedItem.ToString().Substring(0, 3));
            using (SqlCommand cmd = new SqlCommand("procedure_FindOverlap", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleID;
                cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = staffID;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() != roleID.ToString())
                        conflicts.Add(string.Format("{0} - {1} for class {2}", dr[0], dr[5], dr[1]));
                    else
                        conflicts.Add("The user is already assigned to this role");
                }
                if (conflicts.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("The following roles conflict with your instruction:");
                    foreach (string str in conflicts)
                    {
                        sb.AppendLine(str);
                    }
                    sb.AppendLine();
                    sb.AppendLine("Continue?");
                    DialogResult conflictConfirm = MessageBox.Show(sb.ToString(), "Conflicts found", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (conflictConfirm == DialogResult.No)
                        return;
                }
                dr.Close();
            }
            string mboxConfirm = string.Format("Are you sure you want to assign {0} to this role?", lbxApplicableStaff.SelectedItem.ToString());
            DialogResult userConfirm = MessageBox.Show(mboxConfirm, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (userConfirm == DialogResult.OK)
            {
                using (SqlCommand cmd = new SqlCommand("procedure_AssignStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = roleID;
                    cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = staffID;
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(String.Format("Successfully assigned {0} to role {1}", staffID, roleID), "Success");
                        Close();
                    }
                }
            }
        }

        private void frmAvailableStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            finishedAssignment = true;
            senderForm.AssignmentFinished();
        }

        private void frmAvailableStaff_Load(object sender, EventArgs e)
        {
            lblRoleRemind.Text = string.Format("Staff available for {0}", dataRow.Cells[0].Value.ToString());

            using (SqlCommand cmd = new SqlCommand("procedure_GetApplicableStaff", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = Convert.ToInt32(dataRow.Cells[0].Value);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string Employee = String.Format("{0}, {1} {2}", dr[0], dr[1], dr[2]);
                        lbxApplicableStaff.Items.Add(Employee);
                    }
                }
            }
        }

        #endregion Methods
    }
}