namespace SoftGrow.SearchForms
{
    partial class SchStockIssue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchStockIssue));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dt_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(169, 318);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(62, 23);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.IssueDate,
            this.PartyName});
            this.Grid.Location = new System.Drawing.Point(17, 60);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(398, 242);
            this.Grid.TabIndex = 12;
            this.Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Grid_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Location = new System.Drawing.Point(16, 34);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 20);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dt_ToDate
            // 
            this.dt_ToDate.CustomFormat = "dd/MMM/yyyy";
            this.dt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ToDate.Location = new System.Drawing.Point(305, 34);
            this.dt_ToDate.Name = "dt_ToDate";
            this.dt_ToDate.Size = new System.Drawing.Size(110, 20);
            this.dt_ToDate.TabIndex = 90;
            this.dt_ToDate.ValueChanged += new System.EventHandler(this.dt_From_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "To Date";
            // 
            // dt_From
            // 
            this.dt_From.CustomFormat = "dd/MMM/yyyy";
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_From.Location = new System.Drawing.Point(190, 34);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(110, 20);
            this.dt_From.TabIndex = 89;
            this.dt_From.ValueChanged += new System.EventHandler(this.dt_From_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "From Date";
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "IssueID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IssueID.DefaultCellStyle = dataGridViewCellStyle1;
            this.IssueID.HeaderText = "ID #";
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            this.IssueID.Width = 65;
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.IssueDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.IssueDate.HeaderText = "Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            this.IssueDate.Width = 75;
            // 
            // PartyName
            // 
            this.PartyName.DataPropertyName = "PartyName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PartyName.DefaultCellStyle = dataGridViewCellStyle3;
            this.PartyName.HeaderText = "Name";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            this.PartyName.Width = 200;
            // 
            // SchStockIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 356);
            this.Controls.Add(this.dt_ToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchStockIssue";
            this.Text = "Stock Issue to Customer";
            this.Load += new System.EventHandler(this.SchSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DateTimePicker dt_ToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
    }
}