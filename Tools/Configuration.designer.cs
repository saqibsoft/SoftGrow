namespace SoftGrow.Tools
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCashAccTitle = new System.Windows.Forms.TextBox();
            this.txtOpDebit = new System.Windows.Forms.TextBox();
            this.txtOpCredit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoPost = new System.Windows.Forms.CheckBox();
            this.chkVoiceMsg = new System.Windows.Forms.CheckBox();
            this.chkMinToSysTry = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccNameIssue = new System.Windows.Forms.TextBox();
            this.txtAccIssue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccNameWaste = new System.Windows.Forms.TextBox();
            this.txtAccWaste = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(97, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 35);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "System Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 50);
            this.panel1.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(249, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Account Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(495, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "100000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCashAccTitle
            // 
            this.txtCashAccTitle.Location = new System.Drawing.Point(580, 107);
            this.txtCashAccTitle.Name = "txtCashAccTitle";
            this.txtCashAccTitle.Size = new System.Drawing.Size(219, 20);
            this.txtCashAccTitle.TabIndex = 1;
            this.txtCashAccTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtOpDebit
            // 
            this.txtOpDebit.Location = new System.Drawing.Point(805, 107);
            this.txtOpDebit.Name = "txtOpDebit";
            this.txtOpDebit.Size = new System.Drawing.Size(71, 20);
            this.txtOpDebit.TabIndex = 3;
            this.txtOpDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpDebit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpDebit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // txtOpCredit
            // 
            this.txtOpCredit.Location = new System.Drawing.Point(881, 107);
            this.txtOpCredit.Name = "txtOpCredit";
            this.txtOpCredit.Size = new System.Drawing.Size(71, 20);
            this.txtOpCredit.TabIndex = 5;
            this.txtOpCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Op. Debit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Op. Credit";
            // 
            // chkAutoPost
            // 
            this.chkAutoPost.AutoSize = true;
            this.chkAutoPost.Location = new System.Drawing.Point(580, 149);
            this.chkAutoPost.Name = "chkAutoPost";
            this.chkAutoPost.Size = new System.Drawing.Size(86, 17);
            this.chkAutoPost.TabIndex = 6;
            this.chkAutoPost.Text = "Auto Posting";
            this.chkAutoPost.UseVisualStyleBackColor = true;
            this.chkAutoPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // chkVoiceMsg
            // 
            this.chkVoiceMsg.AutoSize = true;
            this.chkVoiceMsg.Location = new System.Drawing.Point(580, 172);
            this.chkVoiceMsg.Name = "chkVoiceMsg";
            this.chkVoiceMsg.Size = new System.Drawing.Size(103, 17);
            this.chkVoiceMsg.TabIndex = 7;
            this.chkVoiceMsg.Text = "Message Sound";
            this.chkVoiceMsg.UseVisualStyleBackColor = true;
            this.chkVoiceMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // chkMinToSysTry
            // 
            this.chkMinToSysTry.AutoSize = true;
            this.chkMinToSysTry.Location = new System.Drawing.Point(579, 195);
            this.chkMinToSysTry.Name = "chkMinToSysTry";
            this.chkMinToSysTry.Size = new System.Drawing.Size(129, 17);
            this.chkMinToSysTry.TabIndex = 8;
            this.chkMinToSysTry.Text = "Minimize to System try";
            this.chkMinToSysTry.UseVisualStyleBackColor = true;
            this.chkMinToSysTry.Visible = false;
            this.chkMinToSysTry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Salary Expense Account #";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Location = new System.Drawing.Point(103, 116);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(335, 20);
            this.txtAccountName.TabIndex = 81;
            this.txtAccountName.TabStop = false;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNo.Location = new System.Drawing.Point(39, 116);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(59, 20);
            this.txtAccountNo.TabIndex = 80;
            this.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtAccountNo_TextChanged);
            this.txtAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNo_KeyDown);
            this.txtAccountNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Sample Issuance Account #";
            // 
            // txtAccNameIssue
            // 
            this.txtAccNameIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNameIssue.Location = new System.Drawing.Point(103, 167);
            this.txtAccNameIssue.Name = "txtAccNameIssue";
            this.txtAccNameIssue.ReadOnly = true;
            this.txtAccNameIssue.Size = new System.Drawing.Size(335, 20);
            this.txtAccNameIssue.TabIndex = 84;
            this.txtAccNameIssue.TabStop = false;
            // 
            // txtAccIssue
            // 
            this.txtAccIssue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccIssue.Location = new System.Drawing.Point(39, 167);
            this.txtAccIssue.Name = "txtAccIssue";
            this.txtAccIssue.Size = new System.Drawing.Size(59, 20);
            this.txtAccIssue.TabIndex = 83;
            this.txtAccIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccIssue.TextChanged += new System.EventHandler(this.txtAccIssue_TextChanged);
            this.txtAccIssue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtAccIssue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Product Wastage Account #";
            // 
            // txtAccNameWaste
            // 
            this.txtAccNameWaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNameWaste.Location = new System.Drawing.Point(103, 217);
            this.txtAccNameWaste.Name = "txtAccNameWaste";
            this.txtAccNameWaste.ReadOnly = true;
            this.txtAccNameWaste.Size = new System.Drawing.Size(335, 20);
            this.txtAccNameWaste.TabIndex = 87;
            this.txtAccNameWaste.TabStop = false;
            // 
            // txtAccWaste
            // 
            this.txtAccWaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccWaste.Location = new System.Drawing.Point(39, 217);
            this.txtAccWaste.Name = "txtAccWaste";
            this.txtAccWaste.Size = new System.Drawing.Size(59, 20);
            this.txtAccWaste.TabIndex = 86;
            this.txtAccWaste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccWaste.TextChanged += new System.EventHandler(this.txtAccWaste_TextChanged);
            this.txtAccWaste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            this.txtAccWaste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNo_KeyPress);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccNameWaste);
            this.Controls.Add(this.txtAccWaste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccNameIssue);
            this.Controls.Add(this.txtAccIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.chkMinToSysTry);
            this.Controls.Add(this.chkVoiceMsg);
            this.Controls.Add(this.chkAutoPost);
            this.Controls.Add(this.txtCashAccTitle);
            this.Controls.Add(this.txtOpCredit);
            this.Controls.Add(this.txtOpDebit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.Text = "System Settings";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCashAccTitle;
        private System.Windows.Forms.TextBox txtOpDebit;
        private System.Windows.Forms.TextBox txtOpCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoPost;
        private System.Windows.Forms.CheckBox chkVoiceMsg;
        private System.Windows.Forms.CheckBox chkMinToSysTry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccNameIssue;
        private System.Windows.Forms.TextBox txtAccIssue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccNameWaste;
        private System.Windows.Forms.TextBox txtAccWaste;
    }
}