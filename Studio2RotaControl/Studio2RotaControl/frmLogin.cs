using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmLogin : Form
    {
        #region Constructors

        public FrmLogin(Form parent)
        {
            InitializeComponent();
            Icon = Studio2RotaControl.Properties.Resources.logo_small;
            Size = new Size(500, 350);
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
            if (tbxPassword.Text == "")
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

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Form frmNewUser = new FrmNewUser(this);
            frmNewUser.Show();
            Hide();
        }

        private void btnAmmendRota_Click(object sender, EventArgs e)
        {
            Form frmViewRota = new FrmRotaControl(this, editable: true);
            frmViewRota.Show();
            Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (searchUsers(tbxUsername.Text, tbxPassword.Text))
            {
                if (classSessionStorage.PermLevel == 1)
                {
                    Form frmViewRota = new FrmRotaControl(this, editable: false);
                    frmViewRota.Show();
                    Hide();
                }
                else
                {
                    Size = new Size(500, 550);
                    tblMenu.Visible = true;
                }
            }
            else
            {
                classSessionStorage.PermLevel = 0;
                classSessionStorage.Username = "default";
                Size = new Size(500, 350);
            }
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            Form frmEditUser = new FrmUserManagement(this);
            frmEditUser.Show();
            Hide();
        }

        private void btnViewRota_Click(object sender, EventArgs e)
        {
            Form frmViewRota = new FrmRotaControl(this, editable: false);
            frmViewRota.Show();
            Hide();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}