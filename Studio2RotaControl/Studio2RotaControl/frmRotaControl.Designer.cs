namespace Studio2RotaControl
{
    partial class frmRotaControl
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxSearchValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxSearchValue = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEditRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1334, 633);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxSearchCategory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEditRow, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbxSearchValue
            // 
            this.cbxSearchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxSearchValue.FormattingEnabled = true;
            this.cbxSearchValue.Items.AddRange(new object[] {
            "[Select search catagory]"});
            this.cbxSearchValue.Location = new System.Drawing.Point(3, 3);
            this.cbxSearchValue.Name = "cbxSearchValue";
            this.cbxSearchValue.Size = new System.Drawing.Size(231, 28);
            this.cbxSearchValue.Sorted = true;
            this.cbxSearchValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 106);
            this.label2.TabIndex = 2;
            this.label2.Text = "For";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSearchCategory
            // 
            this.cbxSearchCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbxSearchCategory.FormattingEnabled = true;
            this.cbxSearchCategory.Items.AddRange(new object[] {
            "Classes",
            "Roles",
            "StaffID"});
            this.cbxSearchCategory.Location = new System.Drawing.Point(71, 3);
            this.cbxSearchCategory.Name = "cbxSearchCategory";
            this.cbxSearchCategory.Size = new System.Drawing.Size(244, 28);
            this.cbxSearchCategory.TabIndex = 1;
            this.cbxSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchCategory_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSearch.Location = new System.Drawing.Point(71, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(244, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(997, 633);
            this.dataGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbxSearchValue);
            this.flowLayoutPanel1.Controls.Add(this.tbxSearchValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tbxSearchValue
            // 
            this.tbxSearchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxSearchValue.Location = new System.Drawing.Point(3, 37);
            this.tbxSearchValue.Name = "tbxSearchValue";
            this.tbxSearchValue.Size = new System.Drawing.Size(231, 26);
            this.tbxSearchValue.TabIndex = 4;
            this.tbxSearchValue.Visible = false;
            this.tbxSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearchValue_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnReturn.Location = new System.Drawing.Point(71, 590);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(244, 40);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Exit";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditRow
            // 
            this.btnEditRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditRow.Location = new System.Drawing.Point(71, 194);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.Size = new System.Drawing.Size(244, 25);
            this.btnEditRow.TabIndex = 7;
            this.btnEditRow.Text = "Edit";
            this.btnEditRow.UseVisualStyleBackColor = true;
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // frmRotaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 633);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRotaControl";
            this.Text = "frmRotaControl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbxSearchValue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditRow;
    }
}