using System;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmStart : Form
    {
        #region Constructors

        public frmStart()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            this.WindowState = FormWindowState.Minimized;
            frmLogin.Show();
        }

        private void btnViewRota_Click(object sender, EventArgs e)
        {
        }

        private void ContextMenuExit_Click(object sender, EventArgs e)
        {
            DialogResult drConfirmExit = MessageBox.Show("Are you sure you wish to exit?\nEnsure that all database requests have finished before continuing.", "Quit application", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            if (drConfirmExit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmStart_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #endregion Methods
    }
}