namespace SoftGrow.Finance
{
    partial class ChequeIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeIssue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtReceivedby = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtDepositDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtBankAccNo = new System.Windows.Forms.TextBox();
            this.txtBankAccName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheqNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtCheqDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearDonor = new System.Windows.Forms.Button();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChqAmount = new System.Windows.Forms.TextBox();
            this.txtWHTAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCheqAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReceivedby
            // 
            this.txtReceivedby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceivedby.Location = new System.Drawing.Point(87, 202);
            this.txtReceivedby.MaxLength = 150;
            this.txtReceivedby.Name = "txtReceivedby";
            this.txtReceivedby.Size = new System.Drawing.Size(403, 20);
            this.txtReceivedby.TabIndex = 14;
            this.txtReceivedby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Received by.";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(86, 90);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue ID";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(1, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 50);
            this.panel1.TabIndex = 32;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(354, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(284, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Open";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(216, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(78, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 35);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Cheque Issue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 157;
            this.pictureBox1.TabStop = false;
            // 
            // dtDepositDate
            // 
            this.dtDepositDate.CustomFormat = "dd/MMM/yyyy";
            this.dtDepositDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepositDate.Location = new System.Drawing.Point(386, 90);
            this.dtDepositDate.Name = "dtDepositDate";
            this.dtDepositDate.Size = new System.Drawing.Size(106, 20);
            this.dtDepositDate.TabIndex = 3;
            this.dtDepositDate.ValueChanged += new System.EventHandler(this.dtDepositDate_ValueChanged);
            this.dtDepositDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "To Account";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Location = new System.Drawing.Point(135, 287);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(206, 20);
            this.txtAccountName.TabIndex = 23;
            this.txtAccountName.TabStop = false;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNo.Location = new System.Drawing.Point(73, 287);
            this.txtAccountNo.MaxLength = 25;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(59, 20);
            this.txtAccountNo.TabIndex = 22;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNo_KeyDown);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // txtBankAccNo
            // 
            this.txtBankAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccNo.Location = new System.Drawing.Point(86, 165);
            this.txtBankAccNo.MaxLength = 25;
            this.txtBankAccNo.Name = "txtBankAccNo";
            this.txtBankAccNo.Size = new System.Drawing.Size(59, 20);
            this.txtBankAccNo.TabIndex = 11;
            this.txtBankAccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAccNo.TextChanged += new System.EventHandler(this.txtBankAccountNo_TextChanged);
            this.txtBankAccNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankAccountNo_KeyDown);
            this.txtBankAccNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankAccountNo_KeyPress);
            // 
            // txtBankAccName
            // 
            this.txtBankAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankAccName.Location = new System.Drawing.Point(148, 165);
            this.txtBankAccName.Name = "txtBankAccName";
            this.txtBankAccName.ReadOnly = true;
            this.txtBankAccName.Size = new System.Drawing.Size(342, 20);
            this.txtBankAccName.TabIndex = 12;
            this.txtBankAccName.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "From Bank Acc.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(344, 287);
            this.txtAmount.MaxLength = 25;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(76, 20);
            this.txtAmount.TabIndex = 25;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNarration.Location = new System.Drawing.Point(86, 430);
            this.txtNarration.MaxLength = 200;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(416, 20);
            this.txtNarration.TabIndex = 31;
            this.txtNarration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cheque No.";
            // 
            // txtCheqNo
            // 
            this.txtCheqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheqNo.Location = new System.Drawing.Point(87, 128);
            this.txtCheqNo.MaxLength = 50;
            this.txtCheqNo.Name = "txtCheqNo";
            this.txtCheqNo.Size = new System.Drawing.Size(238, 20);
            this.txtCheqNo.TabIndex = 7;
            this.txtCheqNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cheq.Date";
            // 
            // dtCheqDate
            // 
            this.dtCheqDate.CustomFormat = "dd/MMM/yyyy";
            this.dtCheqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheqDate.Location = new System.Drawing.Point(387, 128);
            this.dtCheqDate.Name = "dtCheqDate";
            this.dtCheqDate.Size = new System.Drawing.Size(105, 20);
            this.dtCheqDate.TabIndex = 9;
            this.dtCheqDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // btnClearDonor
            // 
            this.btnClearDonor.Location = new System.Drawing.Point(462, 286);
            this.btnClearDonor.Name = "btnClearDonor";
            this.btnClearDonor.Size = new System.Drawing.Size(40, 23);
            this.btnClearDonor.TabIndex = 27;
            this.btnClearDonor.Text = "Clear";
            this.btnClearDonor.UseVisualStyleBackColor = true;
            this.btnClearDonor.Click += new System.EventHandler(this.btnClearAccounts_Click);
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(422, 286);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(37, 23);
            this.btnAddDonor.TabIndex = 26;
            this.btnAddDonor.Text = "Add";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.AccountName,
            this.Amount});
            this.Grid.Location = new System.Drawing.Point(74, 313);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(428, 88);
            this.Grid.TabIndex = 34;
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // AccountNo
            // 
            this.AccountNo.DataPropertyName = "AccountNo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AccountNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.AccountNo.HeaderText = "AccountNo";
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            this.AccountNo.Width = 75;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "Account Title";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 220;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(435, 404);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(67, 20);
            this.txtTotalAmount.TabIndex = 29;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Amount.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "With Holding Tax.";
            // 
            // txtChqAmount
            // 
            this.txtChqAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChqAmount.Location = new System.Drawing.Point(87, 237);
            this.txtChqAmount.MaxLength = 25;
            this.txtChqAmount.Name = "txtChqAmount";
            this.txtChqAmount.Size = new System.Drawing.Size(76, 20);
            this.txtChqAmount.TabIndex = 16;
            this.txtChqAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChqAmount.TextChanged += new System.EventHandler(this.txtChqAmount_TextChanged);
            this.txtChqAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtChqAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtWHTAmount
            // 
            this.txtWHTAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWHTAmount.Location = new System.Drawing.Point(259, 237);
            this.txtWHTAmount.MaxLength = 25;
            this.txtWHTAmount.Name = "txtWHTAmount";
            this.txtWHTAmount.Size = new System.Drawing.Size(59, 20);
            this.txtWHTAmount.TabIndex = 18;
            this.txtWHTAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWHTAmount.TextChanged += new System.EventHandler(this.txtWHTAmount_TextChanged);
            this.txtWHTAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtWHTAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtTotalCheqAmount
            // 
            this.txtTotalCheqAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCheqAmount.Location = new System.Drawing.Point(393, 237);
            this.txtTotalCheqAmount.MaxLength = 25;
            this.txtTotalCheqAmount.Name = "txtTotalCheqAmount";
            this.txtTotalCheqAmount.ReadOnly = true;
            this.txtTotalCheqAmount.Size = new System.Drawing.Size(97, 20);
            this.txtTotalCheqAmount.TabIndex = 20;
            this.txtTotalCheqAmount.TabStop = false;
            this.txtTotalCheqAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalCheqAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtTotalCheqAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Total Amount";
            // 
            // ChequeIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 505);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.btnClearDonor);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.txtCheqNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalCheqAmount);
            this.Controls.Add(this.txtWHTAmount);
            this.Controls.Add(this.txtChqAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBankAccName);
            this.Controls.Add(this.txtBankAccNo);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.dtCheqDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtDepositDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceivedby);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChequeIssue";
            this.Text = "Cheque Issue";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChequeIssue_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceivedby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtDepositDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtBankAccNo;
        private System.Windows.Forms.TextBox txtBankAccName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheqNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtCheqDate;
        private System.Windows.Forms.Button btnClearDonor;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChqAmount;
        private System.Windows.Forms.TextBox txtWHTAmount;
        private System.Windows.Forms.TextBox txtTotalCheqAmount;
        private System.Windows.Forms.Label label14;
    }
}