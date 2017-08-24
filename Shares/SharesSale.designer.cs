namespace SoftGrow.Shares
{
    partial class SharesSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharesSale));
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
            this.dtIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheqNo = new System.Windows.Forms.Label();
            this.txtCheqNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.cboScheme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoOfShares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSharePrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalShares = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.optCash = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.optCheque = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(36, 94);
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
            this.panel1.Location = new System.Drawing.Point(1, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 50);
            this.panel1.TabIndex = 26;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(345, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(413, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(278, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "Open";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(77, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(210, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 14);
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
            this.lblTitle.Size = new System.Drawing.Size(199, 35);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Shares Issue";
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
            // dtIssueDate
            // 
            this.dtIssueDate.CustomFormat = "dd/MMM/yyyy";
            this.dtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIssueDate.Location = new System.Drawing.Point(416, 90);
            this.dtIssueDate.Name = "dtIssueDate";
            this.dtIssueDate.Size = new System.Drawing.Size(106, 20);
            this.dtIssueDate.TabIndex = 3;
            this.dtIssueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date";
            // 
            // lblCheqNo
            // 
            this.lblCheqNo.AutoSize = true;
            this.lblCheqNo.Location = new System.Drawing.Point(231, 226);
            this.lblCheqNo.Name = "lblCheqNo";
            this.lblCheqNo.Size = new System.Drawing.Size(24, 13);
            this.lblCheqNo.TabIndex = 22;
            this.lblCheqNo.Text = "No.";
            // 
            // txtCheqNo
            // 
            this.txtCheqNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheqNo.Location = new System.Drawing.Point(255, 222);
            this.txtCheqNo.MaxLength = 50;
            this.txtCheqNo.Name = "txtCheqNo";
            this.txtCheqNo.Size = new System.Drawing.Size(97, 20);
            this.txtCheqNo.TabIndex = 23;
            this.txtCheqNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Member";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberName.Location = new System.Drawing.Point(148, 157);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(376, 20);
            this.txtMemberName.TabIndex = 12;
            this.txtMemberName.TabStop = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemberID.Location = new System.Drawing.Point(86, 157);
            this.txtMemberID.MaxLength = 25;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(59, 20);
            this.txtMemberID.TabIndex = 11;
            this.txtMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            this.txtMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberID_KeyDown);
            this.txtMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(384, 192);
            this.txtTotalAmount.MaxLength = 25;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(85, 20);
            this.txtTotalAmount.TabIndex = 18;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            this.txtTotalAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(86, 257);
            this.txtRemarks.MaxLength = 200;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(438, 20);
            this.txtRemarks.TabIndex = 25;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // cboScheme
            // 
            this.cboScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScheme.FormattingEnabled = true;
            this.cboScheme.Location = new System.Drawing.Point(86, 122);
            this.cboScheme.Name = "cboScheme";
            this.cboScheme.Size = new System.Drawing.Size(160, 21);
            this.cboScheme.TabIndex = 5;
            this.cboScheme.SelectedIndexChanged += new System.EventHandler(this.cboScheme_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Scheme";
            // 
            // txtNoOfShares
            // 
            this.txtNoOfShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfShares.Location = new System.Drawing.Point(86, 190);
            this.txtNoOfShares.MaxLength = 25;
            this.txtNoOfShares.Name = "txtNoOfShares";
            this.txtNoOfShares.Size = new System.Drawing.Size(85, 20);
            this.txtNoOfShares.TabIndex = 14;
            this.txtNoOfShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoOfShares.TextChanged += new System.EventHandler(this.txtNoOfShares_TextChanged);
            this.txtNoOfShares.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtNoOfShares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "No. Of Shares";
            // 
            // txtSharePrice
            // 
            this.txtSharePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSharePrice.Location = new System.Drawing.Point(256, 190);
            this.txtSharePrice.MaxLength = 25;
            this.txtSharePrice.Name = "txtSharePrice";
            this.txtSharePrice.Size = new System.Drawing.Size(51, 20);
            this.txtSharePrice.TabIndex = 16;
            this.txtSharePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSharePrice.TextChanged += new System.EventHandler(this.txtSharePrice_TextChanged);
            this.txtSharePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtSharePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Per Share Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total Shares";
            // 
            // txtTotalShares
            // 
            this.txtTotalShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalShares.Location = new System.Drawing.Point(315, 122);
            this.txtTotalShares.Name = "txtTotalShares";
            this.txtTotalShares.ReadOnly = true;
            this.txtTotalShares.Size = new System.Drawing.Size(78, 20);
            this.txtTotalShares.TabIndex = 7;
            this.txtTotalShares.TabStop = false;
            this.txtTotalShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Available";
            // 
            // txtAvailable
            // 
            this.txtAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvailable.Location = new System.Drawing.Point(446, 122);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(78, 20);
            this.txtAvailable.TabIndex = 9;
            this.txtAvailable.TabStop = false;
            this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // optCash
            // 
            this.optCash.AutoSize = true;
            this.optCash.Checked = true;
            this.optCash.Location = new System.Drawing.Point(86, 224);
            this.optCash.Name = "optCash";
            this.optCash.Size = new System.Drawing.Size(49, 17);
            this.optCash.TabIndex = 20;
            this.optCash.TabStop = true;
            this.optCash.Text = "Cash";
            this.optCash.UseVisualStyleBackColor = true;
            this.optCash.CheckedChanged += new System.EventHandler(this.optCash_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payment Mode";
            // 
            // optCheque
            // 
            this.optCheque.AutoSize = true;
            this.optCheque.Location = new System.Drawing.Point(154, 224);
            this.optCheque.Name = "optCheque";
            this.optCheque.Size = new System.Drawing.Size(62, 17);
            this.optCheque.TabIndex = 21;
            this.optCheque.Text = "Cheque";
            this.optCheque.UseVisualStyleBackColor = true;
            this.optCheque.CheckedChanged += new System.EventHandler(this.optCheque_CheckedChanged);
            // 
            // SharesSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 342);
            this.Controls.Add(this.optCheque);
            this.Controls.Add(this.optCash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.cboScheme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSharePrice);
            this.Controls.Add(this.txtNoOfShares);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dtIssueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCheqNo);
            this.Controls.Add(this.lblCheqNo);
            this.Controls.Add(this.txtTotalShares);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharesSale";
            this.Text = "Shares Issue";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DateTimePicker dtIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCheqNo;
        private System.Windows.Forms.TextBox txtCheqNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cboScheme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoOfShares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSharePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalShares;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.RadioButton optCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optCheque;
    }
}