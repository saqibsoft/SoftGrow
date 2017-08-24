namespace SoftGrow.PayRoll
{
    partial class SalaryGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryGenerate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.SalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGenerate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFilterMonth = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDesignation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.GridBody = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Allowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBody)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaryID,
            this.SalaryMonth,
            this.DepartmentTitle});
            this.Grid.Location = new System.Drawing.Point(12, 109);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(286, 379);
            this.Grid.TabIndex = 20;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // SalaryID
            // 
            this.SalaryID.DataPropertyName = "SalaryID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SalaryID.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalaryID.HeaderText = "ID #";
            this.SalaryID.Name = "SalaryID";
            this.SalaryID.ReadOnly = true;
            this.SalaryID.Width = 60;
            // 
            // SalaryMonth
            // 
            this.SalaryMonth.DataPropertyName = "SalaryMonth";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "MM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.SalaryMonth.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalaryMonth.HeaderText = "Month";
            this.SalaryMonth.Name = "SalaryMonth";
            this.SalaryMonth.ReadOnly = true;
            this.SalaryMonth.Width = 60;
            // 
            // DepartmentTitle
            // 
            this.DepartmentTitle.DataPropertyName = "DepartmentTitle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = null;
            this.DepartmentTitle.DefaultCellStyle = dataGridViewCellStyle3;
            this.DepartmentTitle.HeaderText = "Department";
            this.DepartmentTitle.Name = "DepartmentTitle";
            this.DepartmentTitle.ReadOnly = true;
            this.DepartmentTitle.Width = 170;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(315, 170);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(432, 20);
            this.txtRemarks.TabIndex = 13;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(315, 83);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID #";
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
            this.panel1.Location = new System.Drawing.Point(2, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 50);
            this.panel1.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(698, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(630, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Select";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(562, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(497, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 35);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Salary Generation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Filter";
            // 
            // dtGenerate
            // 
            this.dtGenerate.CustomFormat = "dd/MMM/yyyy";
            this.dtGenerate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGenerate.Location = new System.Drawing.Point(388, 83);
            this.dtGenerate.Name = "dtGenerate";
            this.dtGenerate.Size = new System.Drawing.Size(106, 20);
            this.dtGenerate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Generation Date";
            // 
            // dtFilterMonth
            // 
            this.dtFilterMonth.CustomFormat = "MMM-yyyy";
            this.dtFilterMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFilterMonth.Location = new System.Drawing.Point(12, 83);
            this.dtFilterMonth.Name = "dtFilterMonth";
            this.dtFilterMonth.Size = new System.Drawing.Size(106, 20);
            this.dtFilterMonth.TabIndex = 17;
            this.dtFilterMonth.ValueChanged += new System.EventHandler(this.dtFilterMonth_ValueChanged);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(316, 125);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(177, 21);
            this.cboDepartment.TabIndex = 7;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary Month";
            // 
            // dtSalaryMonth
            // 
            this.dtSalaryMonth.CustomFormat = "MMM-yyyy";
            this.dtSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSalaryMonth.Location = new System.Drawing.Point(500, 83);
            this.dtSalaryMonth.Name = "dtSalaryMonth";
            this.dtSalaryMonth.Size = new System.Drawing.Size(106, 20);
            this.dtSalaryMonth.TabIndex = 5;
            this.dtSalaryMonth.ValueChanged += new System.EventHandler(this.dtSalaryMonth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // cboDepartmentFilter
            // 
            this.cboDepartmentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartmentFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartmentFilter.FormattingEnabled = true;
            this.cboDepartmentFilter.Location = new System.Drawing.Point(124, 82);
            this.cboDepartmentFilter.Name = "cboDepartmentFilter";
            this.cboDepartmentFilter.Size = new System.Drawing.Size(177, 21);
            this.cboDepartmentFilter.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Designation";
            // 
            // cboDesignation
            // 
            this.cboDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesignation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDesignation.FormattingEnabled = true;
            this.cboDesignation.Location = new System.Drawing.Point(500, 125);
            this.cboDesignation.Name = "cboDesignation";
            this.cboDesignation.Size = new System.Drawing.Size(150, 21);
            this.cboDesignation.TabIndex = 9;
            this.cboDesignation.SelectedIndexChanged += new System.EventHandler(this.cboDesignation_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Shift";
            // 
            // cboShift
            // 
            this.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(656, 125);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(91, 21);
            this.cboShift.TabIndex = 11;
            this.cboShift.SelectedIndexChanged += new System.EventHandler(this.cboShift_SelectedIndexChanged);
            // 
            // GridBody
            // 
            this.GridBody.AllowUserToAddRows = false;
            this.GridBody.AllowUserToDeleteRows = false;
            this.GridBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Presents,
            this.Leaves,
            this.BasicSalary,
            this.Allowances,
            this.Bonus,
            this.Deduction,
            this.NetSalary});
            this.GridBody.Location = new System.Drawing.Point(315, 207);
            this.GridBody.Name = "GridBody";
            this.GridBody.RowHeadersWidth = 30;
            this.GridBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBody.Size = new System.Drawing.Size(857, 281);
            this.GridBody.TabIndex = 15;
            this.GridBody.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridBody_CellValidated);
            this.GridBody.Click += new System.EventHandler(this.Grid_Click);
            this.GridBody.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EmployeeID.DefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeID.HeaderText = "ID #";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 60;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = null;
            this.EmployeeName.DefaultCellStyle = dataGridViewCellStyle5;
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 170;
            // 
            // Presents
            // 
            this.Presents.DataPropertyName = "Presents";
            this.Presents.HeaderText = "Presents";
            this.Presents.Name = "Presents";
            this.Presents.ReadOnly = true;
            this.Presents.Width = 60;
            // 
            // Leaves
            // 
            this.Leaves.DataPropertyName = "Leaves";
            this.Leaves.HeaderText = "Leaves";
            this.Leaves.Name = "Leaves";
            this.Leaves.ReadOnly = true;
            this.Leaves.Width = 60;
            // 
            // BasicSalary
            // 
            this.BasicSalary.DataPropertyName = "BasicSalary";
            this.BasicSalary.HeaderText = "Basic Salary";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            this.BasicSalary.Width = 80;
            // 
            // Allowances
            // 
            this.Allowances.DataPropertyName = "Allowances";
            this.Allowances.HeaderText = "Total Allowances";
            this.Allowances.Name = "Allowances";
            // 
            // Bonus
            // 
            this.Bonus.DataPropertyName = "Bonus";
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.Width = 80;
            // 
            // Deduction
            // 
            this.Deduction.DataPropertyName = "Deduction";
            this.Deduction.HeaderText = "Deduction";
            this.Deduction.Name = "Deduction";
            this.Deduction.Width = 80;
            // 
            // NetSalary
            // 
            this.NetSalary.DataPropertyName = "NetSalary";
            this.NetSalary.HeaderText = "Net Salary";
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.ReadOnly = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(753, 170);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(129, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSalary.Location = new System.Drawing.Point(1032, 173);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(140, 20);
            this.txtTotalSalary.TabIndex = 1;
            this.txtTotalSalary.TabStop = false;
            this.txtTotalSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1029, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Salary";
            // 
            // SalaryGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 543);
            this.Controls.Add(this.cboShift);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cboDesignation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboDepartmentFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtSalaryMonth);
            this.Controls.Add(this.dtFilterMonth);
            this.Controls.Add(this.dtGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridBody);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaryGenerate";
            this.Text = "Salary Generation";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalaryGenerate_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFilterMonth;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtSalaryMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDepartmentFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.DataGridView GridBody;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentTitle;
    }
}