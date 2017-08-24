namespace SoftGrow.PayRoll
{
    partial class DailyAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttendance));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.AttendanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendaceDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtDateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFilterMonth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceID,
            this.AttendaceDateTime,
            this.EmployeeName});
            this.Grid.Location = new System.Drawing.Point(263, 112);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(368, 341);
            this.Grid.TabIndex = 19;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // AttendanceID
            // 
            this.AttendanceID.DataPropertyName = "AttendanceID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AttendanceID.DefaultCellStyle = dataGridViewCellStyle1;
            this.AttendanceID.HeaderText = "ID #";
            this.AttendanceID.Name = "AttendanceID";
            this.AttendanceID.ReadOnly = true;
            this.AttendanceID.Width = 60;
            // 
            // AttendaceDateTime
            // 
            this.AttendaceDateTime.DataPropertyName = "AttendaceDateTime";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.AttendaceDateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.AttendaceDateTime.HeaderText = "Date";
            this.AttendaceDateTime.Name = "AttendaceDateTime";
            this.AttendaceDateTime.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 150;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(13, 369);
            this.txtRemarks.MaxLength = 150;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(232, 69);
            this.txtRemarks.TabIndex = 14;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(13, 130);
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
            this.label2.Location = new System.Drawing.Point(13, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
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
            this.panel1.Location = new System.Drawing.Point(-1, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 50);
            this.panel1.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(418, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(350, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Select";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 14);
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
            this.pictureBox1.Size = new System.Drawing.Size(669, 65);
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
            this.lblTitle.Size = new System.Drawing.Size(279, 35);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Daily Attendance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Filter";
            // 
            // dtDateTime
            // 
            this.dtDateTime.CustomFormat = "dd/MMM/yyyy";
            this.dtDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateTime.Location = new System.Drawing.Point(13, 318);
            this.dtDateTime.Name = "dtDateTime";
            this.dtDateTime.Size = new System.Drawing.Size(106, 20);
            this.dtDateTime.TabIndex = 12;
            this.dtDateTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attendance Date";
            // 
            // dtFilterMonth
            // 
            this.dtFilterMonth.Checked = false;
            this.dtFilterMonth.CustomFormat = "dd-MMM-yyyy";
            this.dtFilterMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFilterMonth.Location = new System.Drawing.Point(263, 86);
            this.dtFilterMonth.Name = "dtFilterMonth";
            this.dtFilterMonth.ShowCheckBox = true;
            this.dtFilterMonth.Size = new System.Drawing.Size(106, 20);
            this.dtFilterMonth.TabIndex = 17;
            this.dtFilterMonth.ValueChanged += new System.EventHandler(this.dtFilterMonth_ValueChanged);
            this.dtFilterMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Location = new System.Drawing.Point(66, 177);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(181, 20);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Location = new System.Drawing.Point(13, 177);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(48, 20);
            this.txtEmployeeID.TabIndex = 3;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            this.txtEmployeeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeID_KeyDown);
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForQty_KeyPress);
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Location = new System.Drawing.Point(13, 223);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(234, 20);
            this.txtDepartment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department";
            // 
            // txtDesignation
            // 
            this.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignation.Location = new System.Drawing.Point(13, 268);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(152, 20);
            this.txtDesignation.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Designation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Shift";
            // 
            // txtShift
            // 
            this.txtShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShift.Location = new System.Drawing.Point(167, 268);
            this.txtShift.Name = "txtShift";
            this.txtShift.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(78, 20);
            this.txtShift.TabIndex = 10;
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Location = new System.Drawing.Point(375, 86);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(230, 20);
            this.txtFilter.TabIndex = 18;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // DailyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 505);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.dtFilterMonth);
            this.Controls.Add(this.dtDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyAttendance";
            this.Text = "Daily Attendance";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailyAttendance_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFilterMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendaceDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
    }
}