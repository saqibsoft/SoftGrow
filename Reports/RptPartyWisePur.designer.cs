namespace SoftGrow.Reports
{
    partial class RptPartyWisePur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptPartyWisePur));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.optAllDates = new System.Windows.Forms.RadioButton();
            this.optRange = new System.Windows.Forms.RadioButton();
            this.dt_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product";
            this.label3.Visible = false;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Location = new System.Drawing.Point(110, 206);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(292, 20);
            this.txt_ProductName.TabIndex = 13;
            this.txt_ProductName.TabStop = false;
            this.txt_ProductName.Visible = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductID.Location = new System.Drawing.Point(45, 206);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(59, 20);
            this.txt_ProductID.TabIndex = 5;
            this.txt_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProductID.Visible = false;
            this.txt_ProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged);
            this.txt_ProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            this.txt_ProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer";
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Location = new System.Drawing.Point(110, 163);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.ReadOnly = true;
            this.txtVendorName.Size = new System.Drawing.Size(292, 20);
            this.txtVendorName.TabIndex = 11;
            this.txtVendorName.TabStop = false;
            // 
            // txtVendorID
            // 
            this.txtVendorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorID.Location = new System.Drawing.Point(48, 163);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(55, 20);
            this.txtVendorID.TabIndex = 4;
            this.txtVendorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            this.txtVendorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
            this.txtVendorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendor_KeyPress);
            // 
            // optAllDates
            // 
            this.optAllDates.AutoSize = true;
            this.optAllDates.Location = new System.Drawing.Point(44, 70);
            this.optAllDates.Name = "optAllDates";
            this.optAllDates.Size = new System.Drawing.Size(67, 17);
            this.optAllDates.TabIndex = 0;
            this.optAllDates.TabStop = true;
            this.optAllDates.Text = "All Dates";
            this.optAllDates.UseVisualStyleBackColor = true;
            this.optAllDates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // optRange
            // 
            this.optRange.AutoSize = true;
            this.optRange.Location = new System.Drawing.Point(44, 105);
            this.optRange.Name = "optRange";
            this.optRange.Size = new System.Drawing.Size(57, 17);
            this.optRange.TabIndex = 1;
            this.optRange.TabStop = true;
            this.optRange.Text = "Range";
            this.optRange.UseVisualStyleBackColor = true;
            this.optRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // dt_ToDate
            // 
            this.dt_ToDate.CustomFormat = "dd/MMM/yyyy";
            this.dt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ToDate.Location = new System.Drawing.Point(317, 103);
            this.dt_ToDate.Name = "dt_ToDate";
            this.dt_ToDate.Size = new System.Drawing.Size(111, 20);
            this.dt_ToDate.TabIndex = 3;
            this.dt_ToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "To Date";
            // 
            // dt_From
            // 
            this.dt_From.CustomFormat = "dd/MMM/yyyy";
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_From.Location = new System.Drawing.Point(161, 103);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(111, 20);
            this.dt_From.TabIndex = 2;
            this.dt_From.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "From Date";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Location = new System.Drawing.Point(-2, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 50);
            this.panel1.TabIndex = 74;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(234, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(166, 13);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 28);
            this.lblTitle.TabIndex = 79;
            this.lblTitle.Text = "Party Wise Purchase";
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.Location = new System.Drawing.Point(322, 61);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(88, 17);
            this.chkReturn.TabIndex = 80;
            this.chkReturn.Text = "Show Return";
            this.chkReturn.UseVisualStyleBackColor = true;
            // 
            // RptPartyWisePur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 282);
            this.Controls.Add(this.chkReturn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.optAllDates);
            this.Controls.Add(this.optRange);
            this.Controls.Add(this.dt_ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_From);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RptPartyWisePur";
            this.Text = "Party Wise Purchase";
            this.Load += new System.EventHandler(this.RptSaleRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.RadioButton optAllDates;
        private System.Windows.Forms.RadioButton optRange;
        private System.Windows.Forms.DateTimePicker dt_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkReturn;
    }
}