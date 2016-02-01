using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmPasswordSet : Form
    {
        string passOut;
        bool successOut;
        public frmPasswordSet(ref string passRef, ref bool successRef)
        {
            InitializeComponent();
            passOut = passRef;
            successOut = successRef;
        }
        bool boolBothSet = false;
        bool boolBothMatch = false;
        bool boolContainsDigit = false;
        bool boolContainsOneUppercase = false;
        bool boolContainsOneLowercase = false;
        bool boolAppropriateLength = false;
        string strErrorMessage = "The following password criteria have not been met:";

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            validatePasswords();
            if (errorCheck())
            {
                passOut = tbxPassword1.Text;
                successOut = true;
                Close();
            }
            else
                MessageBox.Show(strErrorMessage, "Password missing criteria");
        }

        private bool errorCheck()
        {
            bool boolNoErrors = true;
            if (boolBothSet == false)
            {
                strErrorMessage += "\nValues must be set for both fields";
                boolNoErrors = false;
            }
            else {
                if (boolBothMatch == false)
                {
                    strErrorMessage += "\nThe passwords must match.";
                    boolNoErrors = false;
                }
                if (boolContainsDigit == false)
                {
                    strErrorMessage += "\nThe password must contain at least one number";
                    boolNoErrors = false;
                }
                if (boolContainsOneUppercase == false)
                {
                    strErrorMessage += "\nThe password must contain at least one uppercase letter";
                    boolNoErrors = false;
                }
                if (boolContainsOneLowercase == false)
                {
                    strErrorMessage += "\nThe password must contain at least one lowercase letter";
                    boolNoErrors = false;
                }
                if (boolAppropriateLength == false)
                {
                    strErrorMessage += "\nThe password must be 8-30 characters long";
                    boolNoErrors = false;
                }
            }
            return boolNoErrors;
        }

        private void validatePasswords()
        {
            if (tbxPassword1.UseSystemPasswordChar == true && tbxPassword2.UseSystemPasswordChar == true)
            {
                boolBothSet = true;
                if (tbxPassword1.Text == tbxPassword2.Text)
                    boolBothMatch = true;
                char[] passwordCharArray = tbxPassword1.Text.ToCharArray();
                foreach (char c in passwordCharArray)
                {
                    if (char.IsNumber(c))
                        boolContainsDigit = true;
                    if (char.IsUpper(c))
                        boolContainsOneUppercase = true;
                    if (char.IsLower(c))
                        boolContainsOneLowercase = true;
                }
                if (tbxPassword1.TextLength >= 8 && tbxPassword1.TextLength <= 30)
                    boolAppropriateLength = true;
            }
        }

        private void tbxPassword1_Enter(object sender, EventArgs e)
        {
            if (tbxPassword1.Text == "Password")
            {
                tbxPassword1.Text = "";
            }
            tbxPassword1.ForeColor = SystemColors.WindowText;
            tbxPassword1.UseSystemPasswordChar = true;
        }

        private void tbxPassword1_Leave(object sender, EventArgs e)
        {
            if (tbxPassword1.Text == "")
            {
                tbxPassword1.Text = "Password";
                tbxPassword1.ForeColor = Color.DarkGray;
                tbxPassword1.UseSystemPasswordChar = false;
            }
        }

        private void tbxPassword2_Enter(object sender, EventArgs e)
        {
            if (tbxPassword2.Text == "Password")
            {
                tbxPassword2.Text = "";
            }
            tbxPassword2.ForeColor = SystemColors.WindowText;
            tbxPassword2.UseSystemPasswordChar = true;
        }

        private void tbxPassword2_Leave(object sender, EventArgs e)
        {
            if (tbxPassword2.Text == "")
            {
                tbxPassword2.Text = "Password";
                tbxPassword2.ForeColor = Color.DarkGray;
                tbxPassword2.UseSystemPasswordChar = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            passOut = "";
            Close();
        }
    }
}
