namespace SoftGrow.Definition
{
    partial class GenAccountChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenAccountChart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAccountTypeFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpeningCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOpCredit = new System.Windows.Forms.TextBox();
            this.txtOpDebit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 35);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "General Accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Account Type";
            this.label4.Visible = false;
            // 
            // cboAccountTypeFilter
            // 
            this.cboAccountTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccountTypeFilter.FormattingEnabled = true;
            this.cboAccountTypeFilter.Items.AddRange(new object[] {
            "ASSET",
            "LIABILITY",
            "EXPENSE",
            "REVENUE",
            "CAPITAL"});
            this.cboAccountTypeFilter.Location = new System.Drawing.Point(422, 103);
            this.cboAccountTypeFilter.Name = "cboAccountTypeFilter";
            this.cboAccountTypeFilter.Size = new System.Drawing.Size(122, 21);
            this.cboAccountTypeFilter.TabIndex = 14;
            this.cboAccountTypeFilter.Visible = false;
            this.cboAccountTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cboAccountTypeFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Type";
            // 
            // cboAccountType
            // 
            this.cboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Items.AddRange(new object[] {
            "ASSET",
            "LIABILITY",
            "EXPENSE",
            "REVENUE",
            "CAPITAL"});
            this.cboAccountType.Location = new System.Drawing.Point(95, 128);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(135, 21);
            this.cboAccountType.TabIndex = 3;
            this.cboAccountType.SelectedIndexChanged += new System.EventHandler(this.cboAccountType_SelectedIndexChanged);
            this.cboAccountType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountTitle.Location = new System.Drawing.Point(12, 186);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(218, 20);
            this.txtAccountTitle.TabIndex = 5;
            this.txtAccountTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Title";
            // 
            // txtAccountID
            // 
            this.txtAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountID.Location = new System.Drawing.Point(12, 129);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.ReadOnly = true;
            this.txtAccountID.Size = new System.Drawing.Size(67, 20);
            this.txtAccountID.TabIndex = 1;
            this.txtAccountID.TabStop = false;
            this.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 123;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Filter (Account #/Title)";
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Location = new System.Drawing.Point(257, 103);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(159, 20);
            this.txtFilter.TabIndex = 12;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.AccountType,
            this.AccountTitle,
            this.OpeningDebit,
            this.OpeningCredit});
            this.Grid.Location = new System.Drawing.Point(257, 130);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(286, 248);
            this.Grid.TabIndex = 15;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // AccountNo
            // 
            this.AccountNo.DataPropertyName = "AccountNo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AccountNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.AccountNo.HeaderText = "A/c #";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            this.AccountNo.Width = 60;
            // 
            // AccountType
            // 
            this.AccountType.DataPropertyName = "AccountType";
            this.AccountType.HeaderText = "AccountType";
            this.AccountType.Name = "AccountType";
            this.AccountType.ReadOnly = true;
            this.AccountType.Visible = false;
            // 
            // AccountTitle
            // 
            this.AccountTitle.DataPropertyName = "AccountTitle";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AccountTitle.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccountTitle.HeaderText = "Title";
            this.AccountTitle.Name = "AccountTitle";
            this.AccountTitle.ReadOnly = true;
            this.AccountTitle.Width = 170;
            // 
            // OpeningDebit
            // 
            this.OpeningDebit.DataPropertyName = "OpeningDebit";
            dataGridViewCellStyle7.NullValue = null;
            this.OpeningDebit.DefaultCellStyle = dataGridViewCellStyle7;
            this.OpeningDebit.HeaderText = "Debit";
            this.OpeningDebit.Name = "OpeningDebit";
            this.OpeningDebit.ReadOnly = true;
            this.OpeningDebit.Visible = false;
            // 
            // OpeningCredit
            // 
            this.OpeningCredit.DataPropertyName = "OpeningCredit";
            dataGridViewCellStyle8.NullValue = null;
            this.OpeningCredit.DefaultCellStyle = dataGridViewCellStyle8;
            this.OpeningCredit.HeaderText = "Credit";
            this.OpeningCredit.Name = "OpeningCredit";
            this.OpeningCredit.ReadOnly = true;
            this.OpeningCredit.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 50);
            this.panel1.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(319, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Select";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOpCredit
            // 
            this.txtOpCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpCredit.Location = new System.Drawing.Point(142, 232);
            this.txtOpCredit.MaxLength = 25;
            this.txtOpCredit.Name = "txtOpCredit";
            this.txtOpCredit.Size = new System.Drawing.Size(88, 20);
            this.txtOpCredit.TabIndex = 9;
            this.txtOpCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // txtOpDebit
            // 
            this.txtOpDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpDebit.Location = new System.Drawing.Point(12, 232);
            this.txtOpDebit.MaxLength = 25;
            this.txtOpDebit.Name = "txtOpDebit";
            this.txtOpDebit.Size = new System.Drawing.Size(88, 20);
            this.txtOpDebit.TabIndex = 7;
            this.txtOpDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Opening Credit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Opening Debit";
            // 
            // GenAccountChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 436);
            this.Controls.Add(this.txtOpCredit);
            this.Controls.Add(this.txtOpDebit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboAccountTypeFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboAccountType);
            this.Controls.Add(this.txtAccountTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenAccountChart";
            this.Text = "General Accounts";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GenAccountChart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAccountTypeFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.TextBox txtAccountTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpeningCredit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOpCredit;
        private System.Windows.Forms.TextBox txtOpDebit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

    }
}

