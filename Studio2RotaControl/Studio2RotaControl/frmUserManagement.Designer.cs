namespace Studio2RotaControl
{
    partial class FrmUserManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchProperty = new System.Windows.Forms.Label();
            this.lblSearchValue = new System.Windows.Forms.Label();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.cbxProperty = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tblEdit = new System.Windows.Forms.TableLayoutPanel();
            this.tblStaffID = new System.Windows.Forms.TableLayoutPanel();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblProfileQualification = new System.Windows.Forms.TableLayoutPanel();
            this.gbxProfile = new System.Windows.Forms.GroupBox();
            this.tblProfile = new System.Windows.Forms.TableLayoutPanel();
            this.floGender = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.tblQualifications = new System.Windows.Forms.TableLayoutPanel();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.gbxEmployment = new System.Windows.Forms.GroupBox();
            this.tblEmployment = new System.Windows.Forms.TableLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblPermLevel = new System.Windows.Forms.Label();
            this.nudPermLevel = new System.Windows.Forms.NumericUpDown();
            this.lblEmploymentBasis = new System.Windows.Forms.Label();
            this.floEmpolymentBasis = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnFullTime = new System.Windows.Forms.RadioButton();
            this.rbtnPartTime = new System.Windows.Forms.RadioButton();
            this.tblContactExit = new System.Windows.Forms.TableLayoutPanel();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.tblContact = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.tbxAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.tbxPostcode = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.tbxContactNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tblExit = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearch.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tblEdit.SuspendLayout();
            this.tblStaffID.SuspendLayout();
            this.tblProfileQualification.SuspendLayout();
            this.gbxProfile.SuspendLayout();
            this.tblProfile.SuspendLayout();
            this.floGender.SuspendLayout();
            this.tblQualifications.SuspendLayout();
            this.gbxEmployment.SuspendLayout();
            this.tblEmployment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPermLevel)).BeginInit();
            this.floEmpolymentBasis.SuspendLayout();
            this.tblContactExit.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.tblContact.SuspendLayout();
            this.tblExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 5;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.34126F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.65874F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblSearch.Controls.Add(this.lblSearch, 1, 1);
            this.tblSearch.Controls.Add(this.lblSearchProperty, 1, 2);
            this.tblSearch.Controls.Add(this.lblSearchValue, 1, 3);
            this.tblSearch.Controls.Add(this.lbxResults, 1, 4);
            this.tblSearch.Controls.Add(this.cbxProperty, 2, 2);
            this.tblSearch.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(3, 3);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 6;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSearch.Size = new System.Drawing.Size(1145, 60);
            this.tblSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblSearch.Location = new System.Drawing.Point(23, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(94, 29);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblSearchProperty
            // 
            this.lblSearchProperty.AutoSize = true;
            this.lblSearchProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearchProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSearchProperty.Location = new System.Drawing.Point(23, 49);
            this.lblSearchProperty.Name = "lblSearchProperty";
            this.lblSearchProperty.Size = new System.Drawing.Size(94, 34);
            this.lblSearchProperty.TabIndex = 1;
            this.lblSearchProperty.Text = "Property:";
            this.lblSearchProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSearchValue
            // 
            this.lblSearchValue.AutoSize = true;
            this.lblSearchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSearchValue.Location = new System.Drawing.Point(23, 83);
            this.lblSearchValue.Name = "lblSearchValue";
            this.lblSearchValue.Size = new System.Drawing.Size(94, 41);
            this.lblSearchValue.TabIndex = 2;
            this.lblSearchValue.Text = "Value:";
            this.lblSearchValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbxResults
            // 
            this.tblSearch.SetColumnSpan(this.lbxResults, 3);
            this.lbxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.ItemHeight = 20;
            this.lbxResults.Location = new System.Drawing.Point(23, 127);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(1086, 1);
            this.lbxResults.TabIndex = 3;
            // 
            // cbxProperty
            // 
            this.tblSearch.SetColumnSpan(this.cbxProperty, 2);
            this.cbxProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxProperty.FormattingEnabled = true;
            this.cbxProperty.Items.AddRange(new object[] {
            "StaffID",
            "Forename",
            "Surname",
            "Gender",
            "DOB",
            "Role",
            "EmploymentBasis"});
            this.cbxProperty.Location = new System.Drawing.Point(123, 52);
            this.cbxProperty.Name = "cbxProperty";
            this.cbxProperty.Size = new System.Drawing.Size(435, 28);
            this.cbxProperty.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.Location = new System.Drawing.Point(3, 69);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(1145, 29);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbxValue);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 83);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(867, 41);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tbxValue
            // 
            this.tbxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxValue.Location = new System.Drawing.Point(3, 3);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(435, 26);
            this.tbxValue.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(444, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tblEdit
            // 
            this.tblEdit.ColumnCount = 4;
            this.tblEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74176F));
            this.tblEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25824F));
            this.tblEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblEdit.Controls.Add(this.tblStaffID, 1, 1);
            this.tblEdit.Controls.Add(this.tblProfileQualification, 2, 1);
            this.tblEdit.Controls.Add(this.gbxEmployment, 1, 2);
            this.tblEdit.Controls.Add(this.tblContactExit, 1, 3);
            this.tblEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEdit.Location = new System.Drawing.Point(0, 0);
            this.tblEdit.Name = "tblEdit";
            this.tblEdit.RowCount = 5;
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.1242F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.40685F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.37568F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEdit.Size = new System.Drawing.Size(1151, 608);
            this.tblEdit.TabIndex = 8;
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
            this.tblStaffID.Location = new System.Drawing.Point(23, 12);
            this.tblStaffID.Name = "tblStaffID";
            this.tblStaffID.RowCount = 2;
            this.tblStaffID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStaffID.Size = new System.Drawing.Size(501, 145);
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
            this.lblStaffID.Size = new System.Drawing.Size(495, 72);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "<StaffID>";
            this.lblStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPassword
            // 
            this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPassword.Location = new System.Drawing.Point(3, 75);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(244, 67);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDelete.Location = new System.Drawing.Point(253, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tblProfileQualification
            // 
            this.tblProfileQualification.ColumnCount = 1;
            this.tblProfileQualification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblProfileQualification.Controls.Add(this.gbxProfile, 0, 0);
            this.tblProfileQualification.Controls.Add(this.tblQualifications, 0, 1);
            this.tblProfileQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProfileQualification.Location = new System.Drawing.Point(530, 12);
            this.tblProfileQualification.Name = "tblProfileQualification";
            this.tblProfileQualification.RowCount = 2;
            this.tblEdit.SetRowSpan(this.tblProfileQualification, 2);
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.14893F));
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.85106F));
            this.tblProfileQualification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProfileQualification.Size = new System.Drawing.Size(595, 321);
            this.tblProfileQualification.TabIndex = 12;
            // 
            // gbxProfile
            // 
            this.gbxProfile.Controls.Add(this.tblProfile);
            this.gbxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProfile.Location = new System.Drawing.Point(3, 3);
            this.gbxProfile.Name = "gbxProfile";
            this.gbxProfile.Size = new System.Drawing.Size(589, 215);
            this.gbxProfile.TabIndex = 2;
            this.gbxProfile.TabStop = false;
            this.gbxProfile.Text = "Profile";
            // 
            // tblProfile
            // 
            this.tblProfile.ColumnCount = 2;
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9947F));
            this.tblProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0053F));
            this.tblProfile.Controls.Add(this.floGender, 1, 3);
            this.tblProfile.Controls.Add(this.lblTitle, 0, 0);
            this.tblProfile.Controls.Add(this.cbxTitle, 1, 0);
            this.tblProfile.Controls.Add(this.lblForename, 0, 1);
            this.tblProfile.Controls.Add(this.tbxForename, 1, 1);
            this.tblProfile.Controls.Add(this.lblSurname, 0, 2);
            this.tblProfile.Controls.Add(this.tbxSurname, 1, 2);
            this.tblProfile.Controls.Add(this.lblDOB, 0, 4);
            this.tblProfile.Controls.Add(this.dtpDOB, 1, 4);
            this.tblProfile.Controls.Add(this.lblGender, 0, 3);
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
            this.tblProfile.Size = new System.Drawing.Size(583, 190);
            this.tblProfile.TabIndex = 0;
            // 
            // floGender
            // 
            this.floGender.AutoSize = true;
            this.floGender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.floGender.Controls.Add(this.rbtnMale);
            this.floGender.Controls.Add(this.rbtnFemale);
            this.floGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floGender.Location = new System.Drawing.Point(154, 101);
            this.floGender.Name = "floGender";
            this.floGender.Size = new System.Drawing.Size(426, 30);
            this.floGender.TabIndex = 14;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnMale.Location = new System.Drawing.Point(3, 3);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(63, 24);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbtnFemale.Location = new System.Drawing.Point(72, 3);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(82, 24);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 34);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            // 
            // cbxTitle
            // 
            this.cbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Location = new System.Drawing.Point(154, 3);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(426, 28);
            this.cbxTitle.TabIndex = 3;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblForename.Location = new System.Drawing.Point(3, 34);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(145, 32);
            this.lblForename.TabIndex = 9;
            this.lblForename.Text = "Forename:";
            // 
            // tbxForename
            // 
            this.tbxForename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxForename.Location = new System.Drawing.Point(154, 37);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(426, 26);
            this.tbxForename.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSurname.Location = new System.Drawing.Point(3, 66);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(145, 32);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Surname:";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxSurname.Location = new System.Drawing.Point(154, 69);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(426, 26);
            this.tbxSurname.TabIndex = 2;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDOB.Location = new System.Drawing.Point(3, 134);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(145, 56);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Birth date:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AllowDrop = true;
            this.dtpDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDOB.Location = new System.Drawing.Point(154, 137);
            this.dtpDOB.MaxDate = new System.DateTime(2999, 1, 30, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(426, 26);
            this.dtpDOB.TabIndex = 7;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblGender.Location = new System.Drawing.Point(3, 98);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(145, 36);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // tblQualifications
            // 
            this.tblQualifications.ColumnCount = 3;
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQualifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.Controls.Add(this.btnQualifications, 1, 1);
            this.tblQualifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblQualifications.Location = new System.Drawing.Point(3, 224);
            this.tblQualifications.Name = "tblQualifications";
            this.tblQualifications.RowCount = 3;
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblQualifications.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblQualifications.Size = new System.Drawing.Size(589, 94);
            this.tblQualifications.TabIndex = 3;
            // 
            // btnQualifications
            // 
            this.btnQualifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQualifications.Location = new System.Drawing.Point(23, 23);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(543, 48);
            this.btnQualifications.TabIndex = 0;
            this.btnQualifications.Text = "Manage Qualifications";
            this.btnQualifications.UseVisualStyleBackColor = true;
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // gbxEmployment
            // 
            this.gbxEmployment.Controls.Add(this.tblEmployment);
            this.gbxEmployment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxEmployment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployment.Location = new System.Drawing.Point(23, 163);
            this.gbxEmployment.Name = "gbxEmployment";
            this.gbxEmployment.Size = new System.Drawing.Size(501, 170);
            this.gbxEmployment.TabIndex = 8;
            this.gbxEmployment.TabStop = false;
            this.gbxEmployment.Text = "Employment";
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
            this.tblEmployment.Size = new System.Drawing.Size(495, 145);
            this.tblEmployment.TabIndex = 7;
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
            // cbxRole
            // 
            this.cbxRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(107, 3);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(385, 28);
            this.cbxRole.TabIndex = 5;
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
            this.nudPermLevel.Size = new System.Drawing.Size(385, 26);
            this.nudPermLevel.TabIndex = 6;
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
            // floEmpolymentBasis
            // 
            this.floEmpolymentBasis.Controls.Add(this.rbtnFullTime);
            this.floEmpolymentBasis.Controls.Add(this.rbtnPartTime);
            this.floEmpolymentBasis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floEmpolymentBasis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.floEmpolymentBasis.Location = new System.Drawing.Point(107, 76);
            this.floEmpolymentBasis.Name = "floEmpolymentBasis";
            this.floEmpolymentBasis.Size = new System.Drawing.Size(385, 66);
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
            // tblContactExit
            // 
            this.tblContactExit.ColumnCount = 2;
            this.tblEdit.SetColumnSpan(this.tblContactExit, 2);
            this.tblContactExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.86703F));
            this.tblContactExit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.13297F));
            this.tblContactExit.Controls.Add(this.gbxContact, 0, 0);
            this.tblContactExit.Controls.Add(this.tblExit, 1, 0);
            this.tblContactExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContactExit.Location = new System.Drawing.Point(23, 339);
            this.tblContactExit.Name = "tblContactExit";
            this.tblContactExit.RowCount = 1;
            this.tblContactExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContactExit.Size = new System.Drawing.Size(1102, 245);
            this.tblContactExit.TabIndex = 13;
            // 
            // gbxContact
            // 
            this.gbxContact.Controls.Add(this.tblContact);
            this.gbxContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContact.Location = new System.Drawing.Point(3, 3);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(741, 239);
            this.gbxContact.TabIndex = 10;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact";
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
            this.tblContact.Size = new System.Drawing.Size(735, 214);
            this.tblContact.TabIndex = 9;
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
            // tbxAddress1
            // 
            this.tbxAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxAddress1.Location = new System.Drawing.Point(130, 3);
            this.tbxAddress1.Name = "tbxAddress1";
            this.tbxAddress1.Size = new System.Drawing.Size(604, 26);
            this.tbxAddress1.TabIndex = 6;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAddress2.Location = new System.Drawing.Point(3, 35);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(121, 20);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address line 2:";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxAddress2.Location = new System.Drawing.Point(130, 38);
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(604, 26);
            this.tbxAddress2.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCity.Location = new System.Drawing.Point(3, 70);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // tbxCity
            // 
            this.tbxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxCity.Location = new System.Drawing.Point(130, 73);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(604, 26);
            this.tbxCity.TabIndex = 8;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPostcode.Location = new System.Drawing.Point(3, 105);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(84, 20);
            this.lblPostcode.TabIndex = 3;
            this.lblPostcode.Text = "Postcode:";
            // 
            // tbxPostcode
            // 
            this.tbxPostcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPostcode.Location = new System.Drawing.Point(130, 108);
            this.tbxPostcode.Name = "tbxPostcode";
            this.tbxPostcode.Size = new System.Drawing.Size(604, 26);
            this.tbxPostcode.TabIndex = 9;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblContactNo.Location = new System.Drawing.Point(3, 140);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(98, 20);
            this.lblContactNo.TabIndex = 4;
            this.lblContactNo.Text = "Contact No:";
            // 
            // tbxContactNo
            // 
            this.tbxContactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxContactNo.Location = new System.Drawing.Point(130, 143);
            this.tbxContactNo.Name = "tbxContactNo";
            this.tbxContactNo.Size = new System.Drawing.Size(604, 26);
            this.tbxContactNo.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmail.Location = new System.Drawing.Point(3, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxEmail.Location = new System.Drawing.Point(130, 178);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(604, 26);
            this.tbxEmail.TabIndex = 11;
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
            this.tblExit.Location = new System.Drawing.Point(750, 3);
            this.tblExit.Name = "tblExit";
            this.tblExit.RowCount = 4;
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblExit.Size = new System.Drawing.Size(349, 239);
            this.tblExit.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(43, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(263, 93);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDiscard.Location = new System.Drawing.Point(43, 122);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDiscard.Size = new System.Drawing.Size(263, 93);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard Changes";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblEdit);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1151, 713);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tblSearch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 101);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 713);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Studio2 |  User Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUserManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tblEdit.ResumeLayout(false);
            this.tblStaffID.ResumeLayout(false);
            this.tblStaffID.PerformLayout();
            this.tblProfileQualification.ResumeLayout(false);
            this.gbxProfile.ResumeLayout(false);
            this.tblProfile.ResumeLayout(false);
            this.tblProfile.PerformLayout();
            this.floGender.ResumeLayout(false);
            this.floGender.PerformLayout();
            this.tblQualifications.ResumeLayout(false);
            this.gbxEmployment.ResumeLayout(false);
            this.tblEmployment.ResumeLayout(false);
            this.tblEmployment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPermLevel)).EndInit();
            this.floEmpolymentBasis.ResumeLayout(false);
            this.floEmpolymentBasis.PerformLayout();
            this.tblContactExit.ResumeLayout(false);
            this.gbxContact.ResumeLayout(false);
            this.tblContact.ResumeLayout(false);
            this.tblContact.PerformLayout();
            this.tblExit.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchProperty;
        private System.Windows.Forms.Label lblSearchValue;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.ComboBox cbxProperty;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.TableLayoutPanel tblEdit;
        private System.Windows.Forms.TableLayoutPanel tblStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tblProfileQualification;
        private System.Windows.Forms.GroupBox gbxProfile;
        private System.Windows.Forms.TableLayoutPanel tblProfile;
        private System.Windows.Forms.FlowLayoutPanel floGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TableLayoutPanel tblQualifications;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.GroupBox gbxEmployment;
        private System.Windows.Forms.TableLayoutPanel tblEmployment;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label lblPermLevel;
        private System.Windows.Forms.NumericUpDown nudPermLevel;
        private System.Windows.Forms.Label lblEmploymentBasis;
        private System.Windows.Forms.FlowLayoutPanel floEmpolymentBasis;
        private System.Windows.Forms.RadioButton rbtnFullTime;
        private System.Windows.Forms.RadioButton rbtnPartTime;
        private System.Windows.Forms.TableLayoutPanel tblContactExit;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.TableLayoutPanel tblContact;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox tbxAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox tbxPostcode;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox tbxContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TableLayoutPanel tblExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}