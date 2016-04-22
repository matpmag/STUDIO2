using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmRotaControl : Form
    {
        #region Fields

        private SqlConnection con;
        Form parentForm;

        #endregion Fields

        #region Constructors

        public FrmRotaControl(Form parent, bool editable)
        {
            InitializeComponent();
            parentForm = parent;
            Icon = Studio2RotaControl.Properties.Resources.logo_small;
            if (!editable) btnEditRow.Visible = false;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString);
            con.Open();
        }

        #endregion Constructors

        #region Methods

        public void AssignmentFinished()
        {
            Enabled = true;
            btnSearch_Click(new object(), new EventArgs());
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1)
                return;
            bool boolAssignmentFinished = false;
            Enabled = false;
            Form frmSetAssigned = new frmAvailableStaff(dataGridView.Rows[dataGridView.SelectedRows[0].Index], con, ref boolAssignmentFinished, this);
            frmSetAssigned.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Program.FrmStart.WindowState = FormWindowState.Normal;
            Program.FrmStart.Show();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearchCategory.SelectedItem == null)
                return;
            if (cbxSearchCategory.SelectedItem.ToString() == "Classes")
            {
                if (cbxSearchValue.SelectedItem == null)
                    return;
                using (SqlCommand cmd = new SqlCommand("procedure_GetRolesByClasses", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Field", SqlDbType.VarChar, 15).Value = cbxSearchValue.SelectedItem.ToString();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
            if (cbxSearchCategory.SelectedItem.ToString() == "Roles")
            {
                if (cbxSearchValue.SelectedItem == null)
                    return;
                if (cbxSearchValue.SelectedIndex == 0)
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_GetRolesByAll", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                        DataTable table = new DataTable();
                        dataAdapter.Fill(table);
                        dataGridView.DataSource = table;
                    }
                    return;
                }
                using (SqlCommand cmd = new SqlCommand("procedure_GetRolesByPosition", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Position", SqlDbType.VarChar, 25).Value = cbxSearchValue.SelectedItem.ToString();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
            if (cbxSearchCategory.SelectedItem.ToString() == "StaffID")
            {
                if (tbxSearchValue.Text == "")
                    return;
                using (SqlCommand cmd = new SqlCommand("procedure_GetRolesByStaffID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = tbxSearchValue.Text;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
        }

        private void cbxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSearchCategory.SelectedItem.ToString() == "StaffID")
            {
                cbxSearchValue.Visible = false;
                tbxSearchValue.Visible = true;
            }
            else
            {
                cbxSearchValue.Visible = true;
                tbxSearchValue.Visible = false;
            }
            if (cbxSearchCategory.SelectedItem.ToString() == "Classes")
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Field] FROM table_Class", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        cbxSearchValue.Items.Clear();
                        while (dr.Read())
                        {
                            cbxSearchValue.Items.Add(dr[0]);
                        }
                    }
                }
            }
            if (cbxSearchCategory.SelectedItem.ToString() == "Roles")
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Position] FROM table_Role", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        cbxSearchValue.Items.Clear();
                        cbxSearchValue.Items.Add("ANY");
                        while (dr.Read())
                        {
                            cbxSearchValue.Items.Add(dr[0]);
                        }
                    }
                }
            }
        }

        private void tbxSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion Methods

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (!splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = true;
                btnCollapse.Text = ">>";
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                btnCollapse.Text = "<<";
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //using (SqlCommand cmd = new SqlCommand("procedure_FindAllOverlap", con))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        foreach (DataGridViewRow dgvr in dataGridView.Rows)
            //        {
            //            FLAG01 = false;
            //            string readerID = dr[0].ToString();

            //            string rowID = dgvr.Cells[0].Value.ToString();
            //            sb.AppendLine(readerID + " - " + rowID);
            //            if (dr[0].ToString() == dgvr.Cells[0].ToString())
            //            {
            //                FLAG01 = true;
            //                dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            //            }
            //            //else
            //            //    dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            //        }
            //        System.IO.File.WriteAllText("../ScanLOG.txt", sb.ToString());

            //    }
            //    dr.Close();
            //}
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (DataGridViewRow dgvr in dataGridView.Rows)
            {
                int rowID = Convert.ToInt32(dgvr.Cells[0].Value.ToString());
                int rowID2 = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                using (SqlCommand cmd = new SqlCommand("procedure_FindAllOverlap", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RoleID", SqlDbType.Int).Value = rowID;
                    cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = rowID2;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string readerID = dr[0].ToString();

                        sb.AppendLine(readerID + " - " + rowID);
                        foreach (DataGridViewRow dgvrConflict in dataGridView.Rows)
                        {
                            if (readerID == dgvrConflict.Cells[0].Value.ToString())
                                dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        }

                        //else
                        //    dgvr.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                    }
                    System.IO.File.WriteAllText("../ScanLOG.txt", sb.ToString());

                    dr.Close();
                }
            }
        }

        private void FrmRotaControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}