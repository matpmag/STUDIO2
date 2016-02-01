using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmNewUser : Form
    {
        #region Fields

        private string password = "";
        private bool passwordSetFlag = false;

        #endregion Fields

        #region Constructors
        string errorMessage = "The following errors are present in the data";
        public frmNewUser()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods
        private int getPermLevel()
        {
            switch (cbxRole.SelectedIndex)
            {
                case 0:
                case 1:
                    return 3;
                case 2:
                    return 2;
                default:
                    return 1;
            }
        }
        private char getGender()
        {
            if (rbtnMale.Checked)
                return 'M';
            else
                return 'F';
        }
        private string getBasis()
        {
            if (rbtnFullTime.Checked)
                return "FULL";
            else
                return "PART";
        }
        private void addUser()
        {
            if (errorInCredentials())
            {
                MessageBox.Show(errorMessage, "Problem with new user credentials");
                return;
            }
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_AddStaff", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = "";
                        cmd.Parameters.Add("@PermLevel", SqlDbType.Int).Value = getPermLevel();
                        cmd.Parameters.Add("@Forename", SqlDbType.VarChar, 20).Value = tbxForename.Text;
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = tbxSurname.Text;
                        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 10).Value = cbxTitle.Text;
                        cmd.Parameters.Add("@Gender", SqlDbType.Char, 1).Value = getGender();
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtpDOB.Value.Date;
                        cmd.Parameters.Add("@Role", SqlDbType.VarChar, 20).Value = cbxRole;
                        cmd.Parameters.Add("@EmploymentBasis", SqlDbType.Char, 4).Value = getBasis();
                        cmd.Parameters.Add("@Address1", SqlDbType.VarChar, 50).Value = tbxAddress1.Text;
                        cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = tbxAddress2.Text;
                        cmd.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = tbxCity.Text;
                        cmd.Parameters.Add("@Postcode", SqlDbType.VarChar, 10).Value = tbxPostcode.Text;
                        cmd.Parameters.Add("@ContactNumber", SqlDbType.VarChar, 20).Value = tbxContactNo.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = tbxEmail.Text;

                        con.Open();
                        if (cmd.ExecuteNonQuery() < 0)
                            MessageBox.Show("User added successfully", "Success");
                        con.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("There has been an error in the execution of this command, please retry", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool errorInCredentials()
        {
            bool errorPresent = false;
            if (!passwordSetFlag)
            {
                errorPresent = true;
                errorMessage += "\n No password has been set.";
            }
            if (getPermLevel() > classSessionStorage.PermLevel)
            {
                errorMessage += "\nYou do not have sufficient permissions to add this type of user.";
            }
            if (tbxForename.Text == "")
            {
                errorMessage += "\nForename has not been set.";
            }
            if (tbxSurname.Text == "")
            {
                errorPresent = true;
                errorMessage += "\nSurname has not been set.";
            }
            if (tbxAddress1.Text == "")
            {
                errorPresent = true;
                errorMessage += "\nAddress has not been set.";
            }
            if (tbxCity.Text == "")
            {
                errorPresent = true;
                errorMessage += "\nCity has not been set.";
            }
            if (tbxPostcode.Text == "")
            {
                errorPresent = true;
                errorMessage += "\nPostcode has not been set.";
            }
            if (tbxContactNo.Text != "")
            {
                char[] contactNoArray = tbxContactNo.Text.ToCharArray();
                bool errorInContactNumber = false;
                foreach (char c in contactNoArray)
                {
                    if (!char.IsDigit(c))
                        errorInContactNumber = true;
                }
                if (errorInContactNumber)
                {
                    errorPresent = true;
                    errorMessage += "\nThe phone number is not formatted correctly";
                }
            }
            return errorPresent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_GetMaxStaffID", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        int staffID = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
                        lblStaffID.Text = staffID.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("There has been an error in the execution of this command, please retry", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion Methods

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Form frmPasswordSet = new frmPasswordSet(ref password, ref passwordSetFlag);
            frmPasswordSet.Show();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Program.frmStart.WindowState = FormWindowState.Normal;
            Program.frmStart.Show();
            Close();
        }
    }
}