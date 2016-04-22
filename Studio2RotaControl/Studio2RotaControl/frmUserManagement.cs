using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmUserManagement : Form
    {
        #region Constructors

        private SqlConnection con;
        private userInMemory userToEdit = null;
        private List<string> qualificationsToAdd = null;

        public FrmUserManagement(Form parent)
        {
            InitializeComponent();
            Icon = Studio2RotaControl.Properties.Resources.logo_small;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["S2DataStore.ConnectionString"].ConnectionString);
            con.Open();
        }

        private string[] getValuesFromFields()
        {
            string passkeyStore = "";
            using (SqlCommand cmd = new SqlCommand("procedure_GetPass", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = userToEdit.StaffID;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    passkeyStore = dr[0].ToString();
                dr.Close();
            }
            char genderChar = rbtnMale.Checked ? 'M' : 'F';
            string basisString = rbtnFullTime.Checked ? "FULL" : "PART";
            string[] output =
            {
                lblStaffID.Text,
                passkeyStore,
                nudPermLevel.Value.ToString(),
                tbxForename.Text,
                tbxSurname.Text,
                cbxTitle.SelectedItem.ToString(),
                genderChar.ToString(),
                dtpDOB.Value.Date.ToString(),
                cbxRole.SelectedItem.ToString(),
                basisString,
                tbxAddress1.Text,
                tbxAddress2.Text,
                tbxCity.Text,
                tbxPostcode.Text,
                tbxContactNo.Text,
                tbxEmail.Text
            };
            return output;
        }

        #endregion Constructors

        #region Methods

        private void btnHideEdit_Click(object sender, EventArgs e)
        {
            tblEdit.Visible = tblEdit.Visible != true;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            using (SqlCommand cmd = new SqlCommand("SELECT  DISTINCT Title FROM  table_Staff", con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cbxTitle.Items.Add(dr[0]);
                    }
                }
            }
            using (SqlCommand cmd = new SqlCommand("SELECT  DISTINCT Role FROM  table_Staff", con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cbxRole.Items.Add(dr[0]);
                    }
                }
            }
        }

        #endregion Methods

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Program.FrmStart.WindowState = FormWindowState.Normal;
            Program.FrmStart.Show();
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                tblSearch.Visible = false;
                btnLoad.Text = "Search";
            
            int staffIDToEdit;
            if (!int.TryParse(lbxResults.SelectedItem.ToString().Substring(0, 3), out staffIDToEdit))
            {
                MessageBox.Show("Not a valid user");
                return;
            }
            using (SqlCommand cmd = new SqlCommand("procedure_GetUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = staffIDToEdit;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] dataArray = new string[16];
                    for (int i = 0; i < 16; i++)
                    {
                        dataArray[i] = dr[i].ToString();
                    }
                    userToEdit = new userInMemory(dataArray);
                }
                dr.Close();
                if (userToEdit.UserSet)
                {
                    lblStaffID.Text = userToEdit.StaffID.ToString();
                    nudPermLevel.Value = userToEdit.PermLevel;
                    tbxForename.Text = userToEdit.Forename;
                    tbxSurname.Text = userToEdit.Surname;
                    cbxTitle.SelectedIndex = cbxTitle.FindStringExact(userToEdit.Title);
                    if (userToEdit.Gender.ToString().ToUpper() == "M") rbtnMale.Checked = true;
                    else rbtnFemale.Checked = true;
                    dtpDOB.Value = userToEdit.DOB;
                    cbxRole.SelectedIndex = cbxRole.FindStringExact(userToEdit.Role);
                    if (userToEdit.EmploymentBasis.ToString().ToUpper().StartsWith("F")) rbtnFullTime.Checked = true;
                    else rbtnPartTime.Checked = true;
                    tbxAddress1.Text = userToEdit.Address1;
                    tbxAddress2.Text = userToEdit.Address2;
                    tbxCity.Text = userToEdit.City;
                    tbxPostcode.Text = userToEdit.Postcode;
                    tbxContactNo.Text = userToEdit.ContactNumber;
                    tbxEmail.Text = userToEdit.Email;
                }
            }
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                tblSearch.Visible = true;
                btnLoad.Text = "Load";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userInMemory holdUser = new userInMemory(getValuesFromFields());
            using (SqlCommand cmd = new SqlCommand("procedure_EditStaff", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@StaffID", SqlDbType.Int).Value = holdUser.StaffID;
                cmd.Parameters.Add("@PermLevel", SqlDbType.Int).Value = holdUser.PermLevel;
                cmd.Parameters.Add("@Forename", SqlDbType.VarChar, 20).Value = holdUser.Forename;
                cmd.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = holdUser.Surname;
                cmd.Parameters.Add("@Title", SqlDbType.VarChar, 10).Value = holdUser.Title;
                cmd.Parameters.Add("@Gender", SqlDbType.Char, 1).Value = holdUser.Gender;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = holdUser.DOB;
                cmd.Parameters.Add("@Role", SqlDbType.VarChar, 20).Value = holdUser.Role;
                cmd.Parameters.Add("@EmploymentBasis", SqlDbType.Char, 4).Value = holdUser.EmploymentBasis;
                cmd.Parameters.Add("@Address1", SqlDbType.VarChar, 50).Value = holdUser.Address1;
                cmd.Parameters.Add("@Address2", SqlDbType.VarChar, 50).Value = holdUser.Address2;
                cmd.Parameters.Add("@City", SqlDbType.VarChar, 20).Value = holdUser.City;
                cmd.Parameters.Add("@Postcode", SqlDbType.VarChar, 10).Value = holdUser.Postcode;
                cmd.Parameters.Add("@ContactNumber", SqlDbType.VarChar, 20).Value = holdUser.ContactNumber;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = holdUser.Email;

                cmd.ExecuteNonQuery();
            }
            userToEdit = holdUser;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                getSearchResults(cbxProperty.SelectedItem.ToString(), tbxValue.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void getSearchResults(string fieldName, string value)
        {
            SqlCommand cmd = new SqlCommand("SELECT StaffID, Forename, Surname FROM table_Staff WHERE " + fieldName + " LIKE @value", con);
            cmd.Parameters.AddWithValue("@value", String.Format("{0}%", value));

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                lbxResults.Items.Clear();
                while (dr.Read())
                {
                    lbxResults.Items.Add(String.Format("{0} - {2}, {1}", dr[0], dr[1], dr[2]));
                }
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            Form frmQualification = new FrmQualifications(ref qualificationsToAdd);
            frmQualification.Show();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}