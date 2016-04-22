using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Studio2RotaControl
{
    public partial class FrmQualifications : Form
    {
        #region Fields

        private List<string> chosenQualifications;

        #endregion Fields

        #region Constructors

        public FrmQualifications(ref List<string> listQualRef)
        {
            InitializeComponent();
            Icon = Studio2RotaControl.Properties.Resources.logo_small;
            chosenQualifications = listQualRef;
        }

        #endregion Constructors

        #region Methods

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (Control crl in Controls)
            {
                CheckBox cbx = new CheckBox();
                if(crl.GetType() == cbx.GetType())
                {
                    cbx = (CheckBox)crl;
                }
                else { return; }
                if (cbx.Checked)
                    chosenQualifications.Add(cbx.Text);
                Close();
            }
        }

        #endregion Methods
    }
}