﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmRotaControl : Form
    {
        #region Fields

        private SqlConnection con;

        #endregion Fields

        #region Constructors

        public frmRotaControl(bool editable)
        {
            InitializeComponent();
            if (!editable) btnEditRow.Visible = false;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString);
            con.Open();
        }

        #endregion Constructors

        #region Methods

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            bool boolAssignmentFinished = false;
            Form frmSetAssigned = new frmAvailableStaff(dataGridView.Rows[dataGridView.SelectedRows[0].Index], con, ref boolAssignmentFinished);
            frmSetAssigned.Show();
            /*while (!boolAssignmentFinished)
            {
                this.Enabled = false;
            }*/
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
    }
}