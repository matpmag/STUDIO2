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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text != "" && tbxPassword.Text != "")
            {
                searchUsers(tbxUsername.Text, tbxPassword.Text);
            }
        }

        private void searchUsers(string username, string password)
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
                            }
                            else
                            {
                                MessageBox.Show("Incorrect StaffID/Password combination, please retry", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("There has been an error in the execution of this command, please retry", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            tbxPassword.ForeColor = SystemColors.WindowText;
            tbxPassword.Text = "";
            tbxPassword.UseSystemPasswordChar = true;
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxUsername.Text = "Password";
                tbxPassword.UseSystemPasswordChar = false;
                tbxUsername.ForeColor = Color.DarkGray;
            }
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.ForeColor = SystemColors.WindowText;
            tbxUsername.Text = "";
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                tbxUsername.Text = "Username";
                tbxUsername.ForeColor = Color.DarkGray;
            }
        }

        #endregion Methods
    }
}