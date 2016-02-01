using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmRotaControl : Form
    {
        SqlConnection con;
        public frmRotaControl(bool editable)
        {
            InitializeComponent();
            if (!editable) btnEditRow.Visible = false;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString);
            con.Open();
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

        private void tbxSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView.Rows[dataGridView.SelectedRows[0].Index].Cells[7].Value.ToString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Program.frmStart.WindowState = FormWindowState.Normal;
            Program.frmStart.Show();
            Close();
        }
    }
}
