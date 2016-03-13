using System;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmUserManagement : Form
    {
        #region Constructors

        public FrmUserManagement()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btnHideEdit_Click(object sender, EventArgs e)
        {
            tblEdit.Visible = tblEdit.Visible != true;
        }
         
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 's2DataStoreDataSet.table_Staff' table. You can move, or remove it, as needed.
            table_StaffTableAdapter.Fill(s2DataStoreDataSet.table_Staff);
        }

        #endregion Methods

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Program.FrmStart.WindowState = FormWindowState.Normal;
            Program.FrmStart.Show();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}