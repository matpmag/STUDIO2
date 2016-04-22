namespace Studio2RotaControl
{
    partial class frmAvailableStaff
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbxApplicableStaff = new System.Windows.Forms.ListBox();
            this.lblRoleRemind = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelect, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbxApplicableStaff, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRoleRemind, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSelect.Location = new System.Drawing.Point(524, 206);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(495, 34);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Continue";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbxApplicableStaff
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lbxApplicableStaff, 2);
            this.lbxApplicableStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxApplicableStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbxApplicableStaff.FormattingEnabled = true;
            this.lbxApplicableStaff.ItemHeight = 20;
            this.lbxApplicableStaff.Location = new System.Drawing.Point(23, 63);
            this.lbxApplicableStaff.Name = "lbxApplicableStaff";
            this.lbxApplicableStaff.Size = new System.Drawing.Size(996, 117);
            this.lbxApplicableStaff.TabIndex = 2;
            // 
            // lblRoleRemind
            // 
            this.lblRoleRemind.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblRoleRemind, 2);
            this.lblRoleRemind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoleRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblRoleRemind.Location = new System.Drawing.Point(23, 20);
            this.lblRoleRemind.Name = "lblRoleRemind";
            this.lblRoleRemind.Size = new System.Drawing.Size(996, 20);
            this.lblRoleRemind.TabIndex = 3;
            this.lblRoleRemind.Text = "Staff available for <ROLE>";
            // 
            // frmAvailableStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 263);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAvailableStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Studio2 | Assign Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAvailableStaff_FormClosing);
            this.Load += new System.EventHandler(this.frmAvailableStaff_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lbxApplicableStaff;
        private System.Windows.Forms.Label lblRoleRemind;
    }
}