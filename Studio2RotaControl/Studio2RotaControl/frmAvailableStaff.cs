using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmAvailableStaff : Form
    {
        #region Fields

        private SqlConnection con;
        private DataGridViewRow dataRow;
        private bool finishedAssignment;

        #endregion Fields

        #region Constructors

        public frmAvailableStaff(DataGridViewRow dgvr, SqlConnection sqlc, ref bool fin)
        {
            InitializeComponent();
            dataRow = dgvr;
            con = sqlc;
            finishedAssignment = fin;
        }

        #endregion Constructors

        #region Methods

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string mboxConfirm = string.Format("Are you sure you want to assign {0} to this role?", lbxApplicableStaff.SelectedItem.ToString());
            DialogResult userConfirm = MessageBox.Show(mboxConfirm, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (userConfirm == DialogResult.OK)
            {
                //Change assigned user
                MessageBox.Show("Test");
            }
        }

        private void frmAvailableStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            finishedAssignment = true;
        }

        private void frmAvailableStaff_Load(object sender, EventArgs e)
        {
            lblRoleRemind.Text = string.Format("Staff available for {0}", dataRow.Cells[0].Value.ToString());

            using (SqlCommand cmd = new SqlCommand("procedure_GetApplicableStaff", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = Convert.ToInt32(dataRow.Cells[7].Value);
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