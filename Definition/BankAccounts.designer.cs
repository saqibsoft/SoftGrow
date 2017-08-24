namespace SoftGrow.Definition
{
    partial class BankAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccounts));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.txtOpCredit = new System.Windows.Forms.TextBox();
            this.txtOpDebit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(12, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 3;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Title";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(12, 90);
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
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AccountTitle});
            this.Grid.Location = new System.Drawing.Point(294, 74);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(264, 227);
            this.Grid.TabIndex = 15;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "BankAccountID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // AccountTitle
            // 
            this.AccountTitle.DataPropertyName = "AccountTitle";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AccountTitle.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountTitle.HeaderText = "Title";
            this.AccountTitle.Name = "AccountTitle";
            this.AccountTitle.ReadOnly = true;
            this.AccountTitle.Width = 170;
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
            this.panel1.Location = new System.Drawing.Point(1, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 50);
            this.panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(381, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(313, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Select";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(245, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 14);
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
            this.lblTitle.Location = new System.Drawing.Point(27, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 35);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Bank Accounts";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Branch Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Branch Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bank Name";
            // 
            // txtBankName
            // 
            this.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankName.Location = new System.Drawing.Point(12, 179);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(277, 20);
            this.txtBankName.TabIndex = 5;
            this.txtBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Location = new System.Drawing.Point(12, 224);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(186, 20);
            this.txtBranchName.TabIndex = 7;
            this.txtBranchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchCode.Location = new System.Drawing.Point(204, 224);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(85, 20);
            this.txtBranchCode.TabIndex = 9;
            this.txtBranchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtOpCredit
            // 
            this.txtOpCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpCredit.Location = new System.Drawing.Point(110, 269);
            this.txtOpCredit.MaxLength = 25;
            this.txtOpCredit.Name = "txtOpCredit";
            this.txtOpCredit.Size = new System.Drawing.Size(88, 20);
            this.txtOpCredit.TabIndex = 13;
            this.txtOpCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // txtOpDebit
            // 
            this.txtOpDebit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpDebit.Location = new System.Drawing.Point(12, 269);
            this.txtOpDebit.MaxLength = 25;
            this.txtOpDebit.Name = "txtOpDebit";
            this.txtOpDebit.Size = new System.Drawing.Size(88, 20);
            this.txtOpDebit.TabIndex = 11;
            this.txtOpDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Opening Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Opening Debit";
            // 
            // BankAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 353);
            this.Controls.Add(this.txtOpCredit);
            this.Controls.Add(this.txtOpDebit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankAccounts";
            this.Text = "Bank Accounts";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BankAccounts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountTitle;
        private System.Windows.Forms.TextBox txtOpCredit;
        private System.Windows.Forms.TextBox txtOpDebit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}