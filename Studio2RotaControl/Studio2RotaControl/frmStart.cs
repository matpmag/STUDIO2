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
            frmLogin.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void btnViewRota_Click(object sender, EventArgs e)
        {
            Form frmViewRota = new frmRotaControl(editable: false);
            frmViewRota.Show();
            WindowState = FormWindowState.Minimized;
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
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon.Visible = true;
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        #endregion Methods
    }
}