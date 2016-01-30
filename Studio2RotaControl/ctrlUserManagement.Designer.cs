namespace Studio2RotaControl
{
    partial class ctrlUserManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.tblMaster = new System.Windows.Forms.TableLayoutPanel();
            this.tblStaffID = new System.Windows.Forms.TableLayoutPanel();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblEmployment = new System.Windows.Forms.TableLayoutPanel();
            this.nudPermLevel = new System.Windows.Forms.NumericUpDown();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPermLevel = new System.Windows.Forms.Label();
            this.floEmpolymentBasis = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnFullTime = new System.Windows.Forms.RadioButton();
            this.rbtnPartTime = new System.Windows.Forms.RadioButton();
            this.lblEmploymentBasis = new System.Windows.Forms.Label();
            this.gbxEmployment = new System.Windows.Forms.GroupBox();
            this.tblContact = new System.Windows.Forms.TableLayoutPanel();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxPostcode = new System.Windows.Forms.TextBox();
            this.tbxContactNo = new System.Windows.Forms.TextBox();
            this.tblExit = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.tblProfileQualification = new System.Windows.Forms.TableLayoutPanel();
            this.gbxProfile = new System.Windows.Forms.GroupBox();
            this.tblProfile = new System.Windows.Forms.TableLayoutPanel();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.tblQualifications = new System.Windows.Forms.TableLayoutPanel();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tblContactExit = new System.Windows.Forms.TableLayoutPanel();
            this.tblMaster.SuspendLayout();
            this.tblStaffID.SuspendLayout();
            this.tblEmployment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPermLevel)).BeginInit();
            this.floEmpolymentBasis.SuspendLayout();
            this.gbxEmployment.SuspendLayout();
            this.tblContact.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.tblExit.SuspendLayout();
            this.tblProfileQualification.SuspendLayout();
            this.gbxProfile.SuspendLayout();
            this.tblProfile.SuspendLayout();
            this.tblQualifications.SuspendLayout();
            this.tblContactExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxRole
            // 
            this.cbxRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(107, 3);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(211, 28);
            this.cbxRole.TabIndex = 5;
            // 
            // tblMaster
            // 
            this.tblMaster.ColumnCount = 4;
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74176F));
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25824F));
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.Controls.Add(this.tblStaffID, 1, 1);
            this.tblMaster.Controls.Add(this.tblProfileQualification, 2, 1);
            this.tblMaster.Controls.Add(this.gbxEmployment, 1, 2);
            this.tblMaster.Controls.Add(this.tblContactExit, 1, 3);
            this.tblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMaster.Location = new System.Drawing.Point(0, 0);
            this.tblMaster.Name = "tblMaster";
            this.tblMaster.RowCount = 5;
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.53532F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.89963F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.56506F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMaster.Size = new System.Drawing.Size(769, 588);
            this.tblMaster.TabIndex = 6;
            // 
            // tblStaffID
            // 
            this.tblStaffID.ColumnCount = 2;
            this.tblStaffID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.Controls.Add(this.lblStaffID, 0, 0);
            this.tblStaffID.Controls.Add(this.btnPassword, 0, 1);
            this.tblStaffID.Controls.Add(this.btnDelete, 1, 1);
            this.tblStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStaffID.Location = new System.Drawing.Point(23, 23);
            this.tblStaffID.Name = "tblStaffID";
            this.tblStaffID.RowCount = 2;
            this.tblStaffID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.Size = new System.Drawing.Size(327, 128);
            this.tblStaffID.TabIndex = 7;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.tblStaffID.SetColumnSpan(this.lblStaffID, 2);
            this.lblStaffID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblStaffID.Location = new System.Drawing.Point(3, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(321, 64);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "<StaffID>";
            this.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPassword
            // 
            this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPassword.Location = new System.Drawing.Point(3, 67);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(157, 58);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDelete.Location = new System.Drawing.Point(166, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 58);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblEmployment
            // 
            this.tblEmployment.ColumnCount = 2;
            this.tblEmployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEmployment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEmployment.Controls.Add(this.lblRole, 0, 0);
            this.tblEmployment.Controls.Add(this.cbxRole, 1, 0);
            this.tblEmployment.Controls.Add(this.lblPermLevel, 0, 1);
            this.tblEmployment.Controls.Add(this.nudPermLevel, 1, 1);
            this.tblEmployment.Controls.Add(this.lblEmploymentBasis, 0, 2);
            this.tblEmployment.Controls.Add(this.floEmpolymentBasis, 1, 2);
            this.tblEmployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmployment.Location = new System.Drawing.Point(3, 22);
            this.tblEmployment.Name = "tblEmployment";
            this.tblEmployment.RowCount = 3;
            this.tblEmployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblEmployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblEmployment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblEmployment.Size = new System.Drawing.Size(321, 149);
            this.tblEmployment.TabIndex = 7;
            // 
            // nudPermLevel
            // 
            this.nudPermLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPermLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nudPermLevel.Location = new System.Drawing.Point(107, 41);
            this.nudPermLevel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPermLevel.Name = "nudPermLevel";
            this.nudPermLevel.Size = new System.Drawing.Size(211, 26);
            this.nudPermLevel.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblRole.Location = new System.Drawing.Point(3, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 20);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Role:";
            // 
            // lblPermLevel
            // 
            this.lblPermLevel.AutoSize = true;
            this.lblPermLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPermLevel.Location = new System.Drawing.Point(3, 38);
            this.lblPermLevel.Name = "lblPermLevel";
            this.lblPermLevel.Size = new System.Drawing.Size(98, 20);
            this.lblPermLevel.TabIndex = 8;
            this.lblPermLevel.Text = "Permission:";
            // 
            // floEmpolymentBasis
            // 
            this.floEmpolymentBasis.Controls.Add(this.rbtnFullTime);
            this.floEmpolymentBasis.Controls.Add(this.rbtnPartTime);
            this.floEmpolymentBasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floEmpolymentBasis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.floEmpolymentBasis.Location = new System.Drawing.Point(107, 76);
            this.floEmpolymentBasis.Name = "floEmpolymentBasis";
            this.floEmpolymentBasis.Size = new System.Drawing.Size(211, 70);
            this.floEmpolymentBasis.TabIndex = 9;
            // 
            // rbtnFullTime
            // 
            this.rbtnFullTime.AutoSize = true;
            this.rbtnFullTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnFullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnFullTime.Location = new System.Drawing.Point(3, 3);
            this.rbtnFullTime.Name = "rbtnFullTime";
            this.rbtnFullTime.Size = new System.Drawing.Size(100, 24);
            this.rbtnFullTime.TabIndex = 0;
            this.rbtnFullTime.TabStop = true;
            this.rbtnFullTime.Text = "Full Time";
            this.rbtnFullTime.UseVisualStyleBackColor = true;
            // 
            // rbtnPartTime
            // 
            this.rbtnPartTime.AutoSize = true;
            this.rbtnPartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnPartTime.Location = new System.Drawing.Point(3, 33);
            this.rbtnPartTime.Name = "rbtnPartTime";
            this.rbtnPartTime.Size = new System.Drawing.Size(100, 24);
            this.rbtnPartTime.TabIndex = 1;
            this.rbtnPartTime.TabStop = true;
            this.rbtnPartTime.Text = "Part Time";
            this.rbtnPartTime.UseVisualStyleBackColor = true;
            // 
            // lblEmploymentBasis
            // 
            this.lblEmploymentBasis.AutoSize = true;
            this.lblEmploymentBasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmploymentBasis.Location = new System.Drawing.Point(3, 73);
            this.lblEmploymentBasis.Name = "lblEmploymentBasis";
            this.lblEmploymentBasis.Size = new System.Drawing.Size(57, 20);
            this.lblEmploymentBasis.TabIndex = 10;
            this.lblEmploymentBasis.Text = "Basis:";
            // 
            // gbxEmployment
            // 
            this.gbxEmployment.Controls.Add(this.tblEmployment);
            this.gbxEmployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployment.Location = new System.Drawing.Point(23, 157);
            this.gbxEmployment.Name = "gbxEmployment";
            this.gbxEmployment.Size = new System.Drawing.Size(327, 174);
            this.gbxEmployment.TabIndex = 8;
            this.gbxEmployment.TabStop = false;
            this.gbxEmployment.Text = "Employment";
            // 
            // tblContact
            // 
            this.tblContact.ColumnCount = 2;
            this.tblContact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblContact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblContact.Controls.Add(this.lblAddress1, 0, 0);
            this.tblContact.Controls.Add(this.tbxAddress1, 1, 0);
            this.tblContact.Controls.Add(this.lblAddress2, 0, 1);
            this.tblContact.Controls.Add(this.tbxAddress2, 1, 1);
            this.tblContact.Controls.Add(this.lblCity, 0, 2);
            this.tblContact.Controls.Add(this.tbxCity, 1, 2);
            this.tblContact.Controls.Add(this.lblPostcode, 0, 3);
            this.tblContact.Controls.Add(this.tbxPostcode, 1, 3);
            this.tblContact.Controls.Add(this.lblContactNo, 0, 4);
            this.tblContact.Controls.Add(this.tbxContactNo, 1, 4);
            this.tblContact.Controls.Add(this.lblEmail, 0, 5);
            this.tblContact.Controls.Add(this.tbxEmail, 1, 5);
            this.tblContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContact.Location = new System.Drawing.Point(3, 22);
            this.tblContact.Name = "tblContact";
            this.tblContact.RowCount = 6;
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblContact.Size = new System.Drawing.Size(477, 196);
            this.tblContact.TabIndex = 9;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.tblContact);
            this.gbxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContact.Location = new System.Drawing.Point(3, 3);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(483, 221);
            this.gbxContact.TabIndex = 10;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAddress1.Location = new System.Drawing.Point(3, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(121, 20);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address line 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAddress2.Location = new System.Drawing.Point(3, 32);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(121, 20);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address line 2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCity.Location = new System.Drawing.Point(3, 64);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPostcode.Location = new System.Drawing.Point(3, 96);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(84, 20);
            this.lblPostcode.TabIndex = 3;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblContactNo.Location = new System.Drawing.Point(3, 128);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(98, 20);
            this.lblContactNo.TabIndex = 4;
            this.lblContactNo.Text = "Contact No:";
            // 
            // tbxAddress1
            // 
            this.tbxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxAddress1.Location = new System.Drawing.Point(130, 3);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(328, 26);
            this.tbxAddress1.TabIndex = 6;
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxAddress2.Location = new System.Drawing.Point(130, 35);
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(328, 26);
            this.tbxAddress2.TabIndex = 7;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxCity.Location = new System.Drawing.Point(130, 67);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(328, 26);
            this.tbxCity.TabIndex = 8;
            // 
            // tbxPostcode
            // 
            this.tbxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPostcode.Location = new System.Drawing.Point(130, 99);
            this.tbxPostcode.Name = "tbxPostcode";
            this.tbxPostcode.Size = new System.Drawing.Size(328, 26);
            this.tbxPostcode.TabIndex = 9;
            // 
            // tbxContactNo
            // 
            this.tbxContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxContactNo.Location = new System.Drawing.Point(130, 131);
            this.tbxContactNo.Name = "tbxContactNo";
            this.tbxContactNo.Size = new System.Drawing.Size(328, 26);
            this.tbxContactNo.TabIndex = 10;
            // 
            // tblExit
            // 
            this.tblExit.ColumnCount = 3;
            this.tblExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblExit.Controls.Add(this.btnSave, 1, 1);
            this.tblExit.Controls.Add(this.btnDiscard, 1, 2);
            this.tblExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExit.Location = new System.Drawing.Point(492, 3);
            this.tblExit.Name = "tblExit";
            this.tblExit.RowCount = 4;
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblExit.Size = new System.Drawing.Size(227, 221);
            this.tblExit.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(43, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(141, 84);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDiscard.Location = new System.Drawing.Point(43, 113);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDiscard.Size = new System.Drawing.Size(141, 84);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard Changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // tblProfileQualification
            // 
            this.tblProfileQualification.ColumnCount = 1;
            this.tblProfileQualification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProfileQualification.Controls.Add(this.gbxProfile, 0, 0);
            this.tblProfileQualification.Controls.Add(this.tblQualifications, 0, 1);
            this.tblProfileQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProfileQualification.Location = new System.Drawing.Point(356, 23);
            this.tblProfileQualification.Name = "tblProfileQualification";
            this.tblProfileQualification.RowCount = 2;
            this.tblMaster.SetRowSpan(this.tblProfileQualification, 2);
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.9868F));
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.0132F));
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProfileQualification.Size = new System.Drawing.Size(389, 308);
            this.tblProfileQualification.TabIndex = 12;
            // 
            // gbxProfile
            // 
            this.gbxProfile.Controls.Add(this.tblProfile);
            this.gbxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProfile.Location = new System.Drawing.Point(3, 3);
            this.gbxProfile.Name = "gbxProfile";
            this.gbxProfile.Size = new System.Drawing.Size(383, 203);
            this.gbxProfile.TabIndex = 2;
            this.gbxProfile.TabStop = false;
            this.gbxProfile.Text = "Profile";
            // 
            // tblProfile
            // 
            this.tblProfile.ColumnCount = 2;
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9947F));
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0053F));
            this.tblProfile.Controls.Add(this.lblTitle, 0, 0);
            this.tblProfile.Controls.Add(this.cbxTitle, 1, 0);
            this.tblProfile.Controls.Add(this.lblForename, 0, 1);
            this.tblProfile.Controls.Add(this.tbxForename, 1, 1);
            this.tblProfile.Controls.Add(this.lblSurname, 0, 2);
            this.tblProfile.Controls.Add(this.tbxSurname, 1, 2);
            this.tblProfile.Controls.Add(this.lblDOB, 0, 4);
            this.tblProfile.Controls.Add(this.dtpDOB, 1, 4);
            this.tblProfile.Controls.Add(this.lblGender, 0, 3);
            this.tblProfile.Controls.Add(this.cbxGender, 1, 3);
            this.tblProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProfile.Location = new System.Drawing.Point(3, 22);
            this.tblProfile.Name = "tblProfile";
            this.tblProfile.RowCount = 5;
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProfile.Size = new System.Drawing.Size(377, 178);
            this.tblProfile.TabIndex = 0;
            // 
            // cbxTitle
            // 
            this.cbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Location = new System.Drawing.Point(101, 3);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(273, 28);
            this.cbxTitle.TabIndex = 3;
            // 
            // tbxForename
            // 
            this.tbxForename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxForename.Location = new System.Drawing.Point(101, 37);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(273, 26);
            this.tbxForename.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.AllowDrop = true;
            this.dtpDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDOB.Location = new System.Drawing.Point(101, 135);
            this.dtpDOB.MaxDate = new System.DateTime(2999, 1, 30, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(273, 26);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxSurname.Location = new System.Drawing.Point(101, 69);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(273, 26);
            this.tbxSurname.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 34);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblForename.Location = new System.Drawing.Point(3, 34);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(92, 32);
            this.lblForename.TabIndex = 9;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSurname.Location = new System.Drawing.Point(3, 66);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 32);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Surname:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGender.Location = new System.Drawing.Point(3, 98);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 34);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDOB.Location = new System.Drawing.Point(3, 132);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(92, 46);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Birth date:";
            // 
            // tblQualifications
            // 
            this.tblQualifications.ColumnCount = 3;
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.Controls.Add(this.btnQualifications, 1, 1);
            this.tblQualifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQualifications.Location = new System.Drawing.Point(3, 212);
            this.tblQualifications.Name = "tblQualifications";
            this.tblQualifications.RowCount = 3;
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.Size = new System.Drawing.Size(383, 93);
            this.tblQualifications.TabIndex = 3;
            // 
            // btnQualifications
            // 
            this.btnQualifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQualifications.Location = new System.Drawing.Point(23, 23);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(337, 47);
            this.btnQualifications.TabIndex = 0;
            this.btnQualifications.Text = "Manage Qualifications";
            this.btnQualifications.UseVisualStyleBackColor = true;
            // 
            // cbxGender
            // 
            this.cbxGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(101, 101);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(273, 28);
            this.cbxGender.TabIndex = 5;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxEmail.Location = new System.Drawing.Point(130, 163);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(328, 26);
            this.tbxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmail.Location = new System.Drawing.Point(3, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // tblContactExit
            // 
            this.tblContactExit.ColumnCount = 2;
            this.tblMaster.SetColumnSpan(this.tblContactExit, 2);
            this.tblContactExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.86703F));
            this.tblContactExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.13297F));
            this.tblContactExit.Controls.Add(this.gbxContact, 0, 0);
            this.tblContactExit.Controls.Add(this.tblExit, 1, 0);
            this.tblContactExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContactExit.Location = new System.Drawing.Point(23, 337);
            this.tblContactExit.Name = "tblContactExit";
            this.tblContactExit.RowCount = 1;
            this.tblContactExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContactExit.Size = new System.Drawing.Size(722, 227);
            this.tblContactExit.TabIndex = 13;
            // 
            // ctrlUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMaster);
            this.Name = "ctrlUserManagement";
            this.Size = new System.Drawing.Size(769, 588);
            this.tblMaster.ResumeLayout(false);
            this.tblStaffID.ResumeLayout(false);
            this.tblStaffID.PerformLayout();
            this.tblEmployment.ResumeLayout(false);
            this.tblEmployment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPermLevel)).EndInit();
            this.floEmpolymentBasis.ResumeLayout(false);
            this.floEmpolymentBasis.PerformLayout();
            this.gbxEmployment.ResumeLayout(false);
            this.tblContact.ResumeLayout(false);
            this.tblContact.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            this.tblExit.ResumeLayout(false);
            this.tblProfileQualification.ResumeLayout(false);
            this.gbxProfile.ResumeLayout(false);
            this.tblProfile.ResumeLayout(false);
            this.tblProfile.PerformLayout();
            this.tblQualifications.ResumeLayout(false);
            this.tblContactExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.TableLayoutPanel tblMaster;
        private System.Windows.Forms.GroupBox gbxEmployment;
        private System.Windows.Forms.TableLayoutPanel tblEmployment;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.NumericUpDown nudPermLevel;
        private System.Windows.Forms.Label lblPermLevel;
        private System.Windows.Forms.FlowLayoutPanel floEmpolymentBasis;
        private System.Windows.Forms.RadioButton rbtnFullTime;
        private System.Windows.Forms.RadioButton rbtnPartTime;
        private System.Windows.Forms.Label lblEmploymentBasis;
        private System.Windows.Forms.TableLayoutPanel tblStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.TableLayoutPanel tblContact;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxPostcode;
        private System.Windows.Forms.TextBox tbxContactNo;
        private System.Windows.Forms.TableLayoutPanel tblExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.TableLayoutPanel tblProfileQualification;
        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.TableLayoutPanel tblProfile;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TableLayoutPanel tblQualifications;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TableLayoutPanel tblContactExit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
    }
}
