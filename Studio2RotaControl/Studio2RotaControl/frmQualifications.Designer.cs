namespace Studio2RotaControl
{
    partial class FrmQualifications
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxPilates = new System.Windows.Forms.CheckBox();
            this.cbxYoga = new System.Windows.Forms.CheckBox();
            this.cbxTaiChi = new System.Windows.Forms.CheckBox();
            this.cbxJudo = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDesc.Location = new System.Drawing.Point(23, 20);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(250, 40);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "The member of staff is qualified in the following area(s)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbxPilates, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxYoga, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxTaiChi, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxJudo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 77);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cbxPilates
            // 
            this.cbxPilates.AutoSize = true;
            this.cbxPilates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxPilates.Location = new System.Drawing.Point(128, 41);
            this.cbxPilates.Name = "cbxPilates";
            this.cbxPilates.Size = new System.Drawing.Size(96, 24);
            this.cbxPilates.TabIndex = 2;
            this.cbxPilates.Text = "PILATES";
            this.cbxPilates.UseVisualStyleBackColor = true;
            // 
            // cbxYoga
            // 
            this.cbxYoga.AutoSize = true;
            this.cbxYoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxYoga.Location = new System.Drawing.Point(128, 3);
            this.cbxYoga.Name = "cbxYoga";
            this.cbxYoga.Size = new System.Drawing.Size(75, 24);
            this.cbxYoga.TabIndex = 1;
            this.cbxYoga.Text = "YOGA";
            this.cbxYoga.UseVisualStyleBackColor = true;
            // 
            // cbxTaiChi
            // 
            this.cbxTaiChi.AutoSize = true;
            this.cbxTaiChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxTaiChi.Location = new System.Drawing.Point(3, 41);
            this.cbxTaiChi.Name = "cbxTaiChi";
            this.cbxTaiChi.Size = new System.Drawing.Size(82, 24);
            this.cbxTaiChi.TabIndex = 3;
            this.cbxTaiChi.Text = "TAICHI";
            this.cbxTaiChi.UseVisualStyleBackColor = true;
            // 
            // cbxJudo
            // 
            this.cbxJudo.AutoSize = true;
            this.cbxJudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxJudo.Location = new System.Drawing.Point(3, 3);
            this.cbxJudo.Name = "cbxJudo";
            this.cbxJudo.Size = new System.Drawing.Size(75, 24);
            this.cbxJudo.TabIndex = 0;
            this.cbxJudo.Text = "JUDO";
            this.cbxJudo.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConfirm.Location = new System.Drawing.Point(23, 166);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(251, 38);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmQualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmQualifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Studio2 | Qualifications";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.CheckBox cbxJudo;
        private System.Windows.Forms.CheckBox cbxYoga;
        private System.Windows.Forms.CheckBox cbxPilates;
        private System.Windows.Forms.CheckBox cbxTaiChi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnConfirm;
    }
}