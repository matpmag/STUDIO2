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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            tbxUsername.ForeColor = SystemColors.WindowText;
            tbxUsername.Text = "";
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.ForeColor = SystemColors.WindowText;
            tbxPassword.Text = "";
            tbxPassword.UseSystemPasswordChar = true;
        }
    }
}
