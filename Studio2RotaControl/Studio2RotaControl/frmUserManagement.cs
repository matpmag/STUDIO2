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
        public frmUserManagement()
        {
            InitializeComponent();
        }

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
            this.table_StaffTableAdapter.Fill(this.s2DataStoreDataSet.table_Staff);

        }
    }
}
