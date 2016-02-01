namespace Studio2RotaControl
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewRota = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAmmendRota = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tblMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxUsername.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsername.Location = new System.Drawing.Point(108, 146);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(268, 26);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.Text = "StaffID";
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbxPassword.Location = new System.Drawing.Point(108, 178);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(268, 26);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // btnLogIn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnLogIn, 3);
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(23, 230);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(438, 50);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox2, 3);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxUsername, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPassword, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLogIn, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 303);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnViewRota
            // 
            this.btnViewRota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewRota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnViewRota.Location = new System.Drawing.Point(3, 3);
            this.btnViewRota.Name = "btnViewRota";
            this.btnViewRota.Size = new System.Drawing.Size(204, 76);
            this.btnViewRota.TabIndex = 0;
            this.btnViewRota.Text = "View Rota";
            this.btnViewRota.UseVisualStyleBackColor = true;
            this.btnViewRota.Click += new System.EventHandler(this.btnViewRota_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAddStaff.Location = new System.Drawing.Point(3, 3);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(204, 76);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnAmmendRota
            // 
            this.btnAmmendRota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAmmendRota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAmmendRota.Location = new System.Drawing.Point(3, 85);
            this.btnAmmendRota.Name = "btnAmmendRota";
            this.btnAmmendRota.Size = new System.Drawing.Size(204, 77);
            this.btnAmmendRota.TabIndex = 2;
            this.btnAmmendRota.Text = "Ammend Rota";
            this.btnAmmendRota.UseVisualStyleBackColor = true;
            this.btnAmmendRota.Click += new System.EventHandler(this.btnAmmendRota_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnManageStaff.Location = new System.Drawing.Point(3, 85);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(204, 77);
            this.btnManageStaff.TabIndex = 3;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(23, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rota";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnViewRota, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAmmendRota, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(210, 165);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(245, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 193);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAddStaff, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnManageStaff, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(210, 165);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 4;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenu.Controls.Add(this.groupBox1, 1, 0);
            this.tblMenu.Controls.Add(this.groupBox2, 2, 0);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(0, 303);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 2;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMenu.Size = new System.Drawing.Size(484, 219);
            this.tblMenu.TabIndex = 7;
            this.tblMenu.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 522);
            this.Controls.Add(this.tblMenu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tblMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewRota;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAmmendRota;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
    }
}