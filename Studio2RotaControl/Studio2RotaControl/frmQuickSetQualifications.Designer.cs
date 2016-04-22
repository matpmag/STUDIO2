namespace Studio2RotaControl
{
    partial class frmQuickSetQualifications
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.cbxJudo = new System.Windows.Forms.CheckBox();
            this.cbxYoga = new System.Windows.Forms.CheckBox();
            this.cbxPilates = new System.Windows.Forms.CheckBox();
            this.cbxTaiChi = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(455, 12);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(109, 114);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Load User";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // cbxJudo
            // 
            this.cbxJudo.AutoSize = true;
            this.cbxJudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxJudo.Location = new System.Drawing.Point(583, 12);
            this.cbxJudo.Name = "cbxJudo";
            this.cbxJudo.Size = new System.Drawing.Size(75, 24);
            this.cbxJudo.TabIndex = 2;
            this.cbxJudo.Text = "JUDO";
            this.cbxJudo.UseVisualStyleBackColor = true;
            // 
            // cbxYoga
            // 
            this.cbxYoga.AutoSize = true;
            this.cbxYoga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxYoga.Location = new System.Drawing.Point(583, 42);
            this.cbxYoga.Name = "cbxYoga";
            this.cbxYoga.Size = new System.Drawing.Size(75, 24);
            this.cbxYoga.TabIndex = 3;
            this.cbxYoga.Text = "YOGA";
            this.cbxYoga.UseVisualStyleBackColor = true;
            // 
            // cbxPilates
            // 
            this.cbxPilates.AutoSize = true;
            this.cbxPilates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxPilates.Location = new System.Drawing.Point(583, 102);
            this.cbxPilates.Name = "cbxPilates";
            this.cbxPilates.Size = new System.Drawing.Size(96, 24);
            this.cbxPilates.TabIndex = 4;
            this.cbxPilates.Text = "PILATES";
            this.cbxPilates.UseVisualStyleBackColor = true;
            // 
            // cbxTaiChi
            // 
            this.cbxTaiChi.AutoSize = true;
            this.cbxTaiChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxTaiChi.Location = new System.Drawing.Point(583, 72);
            this.cbxTaiChi.Name = "cbxTaiChi";
            this.cbxTaiChi.Size = new System.Drawing.Size(82, 24);
            this.cbxTaiChi.TabIndex = 5;
            this.cbxTaiChi.Text = "TAICHI";
            this.cbxTaiChi.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(455, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblOutcome
            // 
            this.lblOutcome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOutcome.Location = new System.Drawing.Point(12, 179);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(663, 17);
            this.lblOutcome.TabIndex = 7;
            this.lblOutcome.Text = "Outcome";
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmQuickSetQualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 205);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxTaiChi);
            this.Controls.Add(this.cbxPilates);
            this.Controls.Add(this.cbxYoga);
            this.Controls.Add(this.cbxJudo);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.listBox1);
            this.Name = "frmQuickSetQualifications";
            this.Text = "Studio2 | Qualifications (Quickset)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.CheckBox cbxJudo;
        private System.Windows.Forms.CheckBox cbxYoga;
        private System.Windows.Forms.CheckBox cbxPilates;
        private System.Windows.Forms.CheckBox cbxTaiChi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutcome;
    }
}