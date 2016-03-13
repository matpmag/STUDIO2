using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class frmQualifications : Form
    {
        #region Fields

        private List<string> chosenQualifications;

        #endregion Fields

        #region Constructors

        public frmQualifications(ref List<string> listQualRef)
        {
            InitializeComponent();
            chosenQualifications = listQualRef;
        }

        #endregion Constructors

        #region Methods

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cbx in Controls)
            {
                if (cbx.Checked)
                    chosenQualifications.Add(cbx.Text);
                Close();
            }
        }

        #endregion Methods
    }
}