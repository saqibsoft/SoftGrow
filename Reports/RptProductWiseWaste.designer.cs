namespace SoftGrow.Reports
{
    partial class RptProductWiseWaste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptProductWiseWaste));
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.optRange = new System.Windows.Forms.RadioButton();
            this.optAllDates = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkReturn = new System.Windows.Forms.CheckBox();
            this.cboSalesman = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkLetterPad = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_From
            // 
            this.dt_From.CustomFormat = "dd/MMM/yyyy";
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_From.Location = new System.Drawing.Point(154, 108);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(111, 20);
            this.dt_From.TabIndex = 2;
            this.dt_From.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "From Date";
            // 
            // dt_ToDate
            // 
            this.dt_ToDate.CustomFormat = "dd/MMM/yyyy";
            this.dt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ToDate.Location = new System.Drawing.Point(313, 108);
            this.dt_ToDate.Name = "dt_ToDate";
            this.dt_ToDate.Size = new System.Drawing.Size(111, 20);
            this.dt_ToDate.TabIndex = 3;
            this.dt_ToDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "To Date";
            // 
            // optRange
            // 
            this.optRange.AutoSize = true;
            this.optRange.Location = new System.Drawing.Point(37, 110);
            this.optRange.Name = "optRange";
            this.optRange.Size = new System.Drawing.Size(57, 17);
            this.optRange.TabIndex = 1;
            this.optRange.TabStop = true;
            this.optRange.Text = "Range";
            this.optRange.UseVisualStyleBackColor = true;
            this.optRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // optAllDates
            // 
            this.optAllDates.AutoSize = true;
            this.optAllDates.Location = new System.Drawing.Point(37, 75);
            this.optAllDates.Name = "optAllDates";
            this.optAllDates.Size = new System.Drawing.Size(67, 17);
            this.optAllDates.TabIndex = 0;
            this.optAllDates.TabStop = true;
            this.optAllDates.Text = "All Dates";
            this.optAllDates.UseVisualStyleBackColor = true;
            this.optAllDates.CheckedChanged += new System.EventHandler(this.optAllDates_CheckedChanged);
            this.optAllDates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer";
            this.label5.Visible = false;
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Location = new System.Drawing.Point(91, 372);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.ReadOnly = true;
            this.txtVendorName.Size = new System.Drawing.Size(287, 20);
            this.txtVendorName.TabIndex = 5;
            this.txtVendorName.TabStop = false;
            this.txtVendorName.Visible = false;
            // 
            // txtVendorID
            // 
            this.txtVendorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorID.Location = new System.Drawing.Point(29, 372);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(55, 20);
            this.txtVendorID.TabIndex = 4;
            this.txtVendorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendorID.Visible = false;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            this.txtVendorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
            this.txtVendorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Location = new System.Drawing.Point(103, 161);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(292, 20);
            this.txt_ProductName.TabIndex = 7;
            this.txt_ProductName.TabStop = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductID.Location = new System.Drawing.Point(38, 161);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(59, 20);
            this.txt_ProductID.TabIndex = 6;
            this.txt_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged);
            this.txt_ProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            this.txt_ProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Location = new System.Drawing.Point(-3, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 51);
            this.panel1.TabIndex = 74;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(163, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 28);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.Text = "Product Wise Wastage";
            // 
            // chkReturn
            // 
            this.chkReturn.AutoSize = true;
            this.chkReturn.Location = new System.Drawing.Point(314, 63);
            this.chkReturn.Name = "chkReturn";
            this.chkReturn.Size = new System.Drawing.Size(88, 17);
            this.chkReturn.TabIndex = 81;
            this.chkReturn.Text = "Show Return";
            this.chkReturn.UseVisualStyleBackColor = true;
            this.chkReturn.Visible = false;
            // 
            // cboSalesman
            // 
            this.cboSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSalesman.FormattingEnabled = true;
            this.cboSalesman.Location = new System.Drawing.Point(91, 358);
            this.cboSalesman.Name = "cboSalesman";
            this.cboSalesman.Size = new System.Drawing.Size(287, 21);
            this.cboSalesman.TabIndex = 83;
            this.cboSalesman.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 362);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 82;
            this.label18.Text = "Salesman";
            this.label18.Visible = false;
            // 
            // chkLetterPad
            // 
            this.chkLetterPad.AutoSize = true;
            this.chkLetterPad.BackColor = System.Drawing.Color.Transparent;
            this.chkLetterPad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLetterPad.ForeColor = System.Drawing.Color.Black;
            this.chkLetterPad.Location = new System.Drawing.Point(314, 86);
            this.chkLetterPad.Name = "chkLetterPad";
            this.chkLetterPad.Size = new System.Drawing.Size(99, 17);
            this.chkLetterPad.TabIndex = 92;
            this.chkLetterPad.Text = "Letter Pad Print";
            this.chkLetterPad.UseVisualStyleBackColor = false;
            this.chkLetterPad.Visible = false;
            // 
            // RptProductWiseWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 257);
            this.Controls.Add(this.chkLetterPad);
            this.Controls.Add(this.cboSalesman);
            this.Controls.Add(this.label18);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RptProductWiseWaste";
            this.Text = "Product Wise Wastage";
            this.Load += new System.EventHandler(this.RptSaleRegister_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optRange;
        private System.Windows.Forms.RadioButton optAllDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkReturn;
        private System.Windows.Forms.ComboBox cboSalesman;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkLetterPad;
    }
}