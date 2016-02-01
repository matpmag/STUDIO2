using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmLogin : Form
    {
        #region Constructors

        public frmLogin()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private bool searchUsers(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_SearchUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = username;
                        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    classSessionStorage.Username = dr[0].ToString();
                                    classSessionStorage.PermLevel = int.Parse(dr[1].ToString());
                                }
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Incorrect StaffID/Password combination, please retry", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    return false;
                }
                catch
                {
                    MessageBox.Show("There has been an error in the execution of this command, please retry", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Password")
            {
                tbxPassword.Text = "";
            }
            tbxPassword.ForeColor = SystemColors.WindowText;
            tbxPassword.UseSystemPasswordChar = true;
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if(tbxPassword.Text == "")
            {
                tbxPassword.Text = "Password";
                tbxPassword.ForeColor = Color.DarkGray;
                tbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "StaffID")
            {
                tbxUsername.ForeColor = SystemColors.WindowText;
                tbxUsername.Text = "";
            }
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                tbxUsername.Text = "StaffID";
                tbxUsername.ForeColor = Color.DarkGray;
            }
        }

        #endregion Methods

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (searchUsers(tbxUsername.Text, tbxPassword.Text))
            {
                if (classSessionStorage.PermLevel == 1)
                {
                    Form frmViewRota = new frmRotaControl(editable: false);
                    frmViewRota.Show();
                    Close();
                    //tblMenu.Visible = false;
                }
                else
                {
                    tblMenu.Visible = true;
                }
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Form frmNewUser = new frmNewUser();
            frmNewUser.Show();
            Close();
        }

        private void btnViewRota_Click(object sender, EventArgs e)
        {
            Form frmViewRota = new frmRotaControl(editable: false);
            frmViewRota.Show();
            Close();
        }

        private void btnAmmendRota_Click(object sender, EventArgs e)
        {
            Form frmViewRota = new frmRotaControl(editable: true);
            frmViewRota.Show();
            Close();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            Form frmEditUser = new frmUserManagement();
            frmEditUser.Show();
            Close();
        }
    }
}