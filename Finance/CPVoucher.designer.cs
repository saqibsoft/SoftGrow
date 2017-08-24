namespace SoftGrow.Finance
{
    partial class CPVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPVoucher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtVoucherDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.cboVoucherType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnClearDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(44, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 35);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Cash Payment (Debit) Voucher";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(-8, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 50);
            this.panel1.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(464, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(396, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(330, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(265, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtVoucherDate
            // 
            this.dtVoucherDate.CustomFormat = "dd/MMM/yyyy";
            this.dtVoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVoucherDate.Location = new System.Drawing.Point(241, 88);
            this.dtVoucherDate.Name = "dtVoucherDate";
            this.dtVoucherDate.Size = new System.Drawing.Size(105, 20);
            this.dtVoucherDate.TabIndex = 3;
            this.dtVoucherDate.ValueChanged += new System.EventHandler(this.dtVoucherDate_ValueChanged);
            this.dtVoucherDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voucher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voucher Date";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVoucherNo.Location = new System.Drawing.Point(102, 88);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.ReadOnly = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(59, 20);
            this.txtVoucherNo.TabIndex = 1;
            this.txtVoucherNo.TabStop = false;
            this.txtVoucherNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboVoucherType
            // 
            this.cboVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoucherType.Enabled = false;
            this.cboVoucherType.FormattingEnabled = true;
            this.cboVoucherType.Items.AddRange(new object[] {
            "Cash Receiving",
            "Cash Payment",
            "Journal Voucher"});
            this.cboVoucherType.Location = new System.Drawing.Point(431, 88);
            this.cboVoucherType.Name = "cboVoucherType";
            this.cboVoucherType.Size = new System.Drawing.Size(135, 21);
            this.cboVoucherType.TabIndex = 5;
            this.cboVoucherType.SelectedIndexChanged += new System.EventHandler(this.cboVoucherType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Voucher Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNarration.Location = new System.Drawing.Point(102, 132);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(465, 20);
            this.txtNarration.TabIndex = 11;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.btnClearDetail);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAccountName);
            this.groupBox1.Controls.Add(this.txtCredit);
            this.groupBox1.Controls.Add(this.txtDebit);
            this.groupBox1.Controls.Add(this.txtAccountNo);
            this.groupBox1.Location = new System.Drawing.Point(9, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(229, 33);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(207, 20);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // btnClearDetail
            // 
            this.btnClearDetail.Location = new System.Drawing.Point(541, 30);
            this.btnClearDetail.Name = "btnClearDetail";
            this.btnClearDetail.Size = new System.Drawing.Size(40, 23);
            this.btnClearDetail.TabIndex = 10;
            this.btnClearDetail.Text = "Clear";
            this.btnClearDetail.UseVisualStyleBackColor = true;
            this.btnClearDetail.Click += new System.EventHandler(this.btnClearDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.AccountName,
            this.Remarks,
            this.Debit,
            this.Credit});
            this.Grid.Location = new System.Drawing.Point(9, 62);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(573, 200);
            this.Grid.TabIndex = 11;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // AccountNo
            // 
            this.AccountNo.DataPropertyName = "AccountNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AccountNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountNo.HeaderText = "Account #";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            this.AccountNo.ToolTipText = "Account #";
            this.AccountNo.Width = 67;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AccountName.DefaultCellStyle = dataGridViewCellStyle3;
            this.AccountName.HeaderText = "Account Title";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 172;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 205;
            // 
            // Debit
            // 
            this.Debit.DataPropertyName = "Debit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Debit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            this.Debit.Width = 75;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Credit.DefaultCellStyle = dataGridViewCellStyle5;
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Visible = false;
            this.Credit.Width = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit";
            this.label3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Debit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account #";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Location = new System.Drawing.Point(73, 32);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(150, 20);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.TabStop = false;
            // 
            // txtCredit
            // 
            this.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredit.Location = new System.Drawing.Point(545, 32);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(44, 20);
            this.txtCredit.TabIndex = 8;
            this.txtCredit.TabStop = false;
            this.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCredit.Visible = false;
            this.txtCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredit_KeyPress);
            // 
            // txtDebit
            // 
            this.txtDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebit.Location = new System.Drawing.Point(442, 32);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(57, 20);
            this.txtDebit.TabIndex = 6;
            this.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            this.txtDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebit_KeyPress);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNo.Location = new System.Drawing.Point(9, 32);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(59, 20);
            this.txtAccountNo.TabIndex = 1;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendorID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total";
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDebit.Location = new System.Drawing.Point(475, 450);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.Size = new System.Drawing.Size(74, 20);
            this.txtTotalDebit.TabIndex = 14;
            this.txtTotalDebit.TabStop = false;
            this.txtTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCredit.Location = new System.Drawing.Point(553, 450);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.ReadOnly = true;
            this.txtTotalCredit.Size = new System.Drawing.Size(51, 20);
            this.txtTotalCredit.TabIndex = 15;
            this.txtTotalCredit.TabStop = false;
            this.txtTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCredit.Visible = false;
            // 
            // CPVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 520);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalCredit);
            this.Controls.Add(this.txtTotalDebit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.cboVoucherType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtVoucherDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPVoucher";
            this.Text = "Cash Payment (Debit) Voucher";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CPVoucher_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtVoucherDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.ComboBox cboVoucherType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
    }
}