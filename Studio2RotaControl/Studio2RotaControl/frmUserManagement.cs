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
    public partial class frmUserManagement : Form
    {
        #region Constructors

        public frmUserManagement()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void btnHideEdit_Click(object sender, EventArgs e)
        {
            if (tblEdit.Visible == true)
                tblEdit.Visible = false;
            else
                tblEdit.Visible = true;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's2DataStoreDataSet.table_Staff' table. You can move, or remove it, as needed.
            table_StaffTableAdapter.Fill(s2DataStoreDataSet.table_Staff);

        }

        #endregion Methods

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Program.frmStart.WindowState = FormWindowState.Normal;
            Program.frmStart.Show();
            Close();
        }
    }
}
