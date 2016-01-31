using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmNewUser : Form
    {
        #region Constructors

        public frmNewUser()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void addUser()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_AddStaff", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = "";//TODO: Password
                        cmd.Parameters.Add("@PermLevel", SqlDbType.Int).Value = 1;//TODO: PermLevel
                        cmd.Parameters.Add("@Forename", SqlDbType.VarChar, 20).Value = tbxForename.Text;
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = tbxSurname.Text;
                        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 10).Value = cbxTitle.Text;
                        cmd.Parameters.Add("@Gender", SqlDbType.Char, 1).Value = 'M';//TODO: Gender
                        cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtpDOB.Value.Date;
                        cmd.Parameters.Add("@Role", SqlDbType.VarChar, 20).Value = cbxRole;
                        cmd.Parameters.Add("@EmploymentBasis", SqlDbType.Char, 4).Value = "FULL";//TODO: Basis
                        cmd.Parameters.Add("@Address1", SqlDbType.VarChar, 50).Value = tbxAddress1.Text;
                        cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = tbxAddress2.Text;
                        cmd.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = tbxCity.Text;
                        cmd.Parameters.Add("@Postcode", SqlDbType.VarChar, 10).Value = tbxPostcode.Text;
                        cmd.Parameters.Add("@ContactNumber", SqlDbType.VarChar, 20).Value = tbxContactNo.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = tbxEmail.Text;
                        //TODO: Validation

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("There has been an error in the execution of this command, please retry", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
        }

        #endregion Methods
    }
}