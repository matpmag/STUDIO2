using System;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmStart : Form
    {
        #region Constructors

        public FrmStart()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
            {
                SoundLocation = "../../../Media/MusicBox.wav"
            };
            player.Play();
        }

        #endregion Constructors

        #region Methods

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
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
                Hide();
            }
            else
            {
                ShowInTaskbar = true;
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

        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            Form frmLogin = new FrmLogin();
            frmLogin.Show();
            WindowState = FormWindowState.Minimized;
        }
    }
}