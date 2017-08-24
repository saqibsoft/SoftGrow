namespace SoftGrow.Reports
{
    partial class RptStockStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptStockStatement));
            this.chkSaleable = new System.Windows.Forms.CheckBox();
            this.chkConsumable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.optAllDates = new System.Windows.Forms.RadioButton();
            this.optRange = new System.Windows.Forms.RadioButton();
            this.dt_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSaleable
            // 
            this.chkSaleable.AutoSize = true;
            this.chkSaleable.Location = new System.Drawing.Point(212, 188);
            this.chkSaleable.Name = "chkSaleable";
            this.chkSaleable.Size = new System.Drawing.Size(65, 17);
            this.chkSaleable.TabIndex = 3;
            this.chkSaleable.Text = "For Sale";
            this.chkSaleable.UseVisualStyleBackColor = true;
            // 
            // chkConsumable
            // 
            this.chkConsumable.AutoSize = true;
            this.chkConsumable.Location = new System.Drawing.Point(84, 188);
            this.chkConsumable.Name = "chkConsumable";
            this.chkConsumable.Size = new System.Drawing.Size(105, 17);
            this.chkConsumable.TabIndex = 2;
            this.chkConsumable.Text = "For Consumption";
            this.chkConsumable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Location = new System.Drawing.Point(149, 156);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(273, 20);
            this.txt_ProductName.TabIndex = 6;
            this.txt_ProductName.TabStop = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductID.Location = new System.Drawing.Point(84, 156);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(59, 20);
            this.txt_ProductID.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(-1, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(202, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 28);
            this.lblTitle.TabIndex = 76;
            this.lblTitle.Text = "Stock Flow Statement";
            // 
            // optAllDates
            // 
            this.optAllDates.AutoSize = true;
            this.optAllDates.Checked = true;
            this.optAllDates.Location = new System.Drawing.Point(76, 75);
            this.optAllDates.Name = "optAllDates";
            this.optAllDates.Size = new System.Drawing.Size(67, 17);
            this.optAllDates.TabIndex = 89;
            this.optAllDates.TabStop = true;
            this.optAllDates.Text = "All Dates";
            this.optAllDates.UseVisualStyleBackColor = true;
            // 
            // optRange
            // 
            this.optRange.AutoSize = true;
            this.optRange.Location = new System.Drawing.Point(76, 110);
            this.optRange.Name = "optRange";
            this.optRange.Size = new System.Drawing.Size(57, 17);
            this.optRange.TabIndex = 90;
            this.optRange.Text = "Range";
            this.optRange.UseVisualStyleBackColor = true;
            // 
            // dt_ToDate
            // 
            this.dt_ToDate.CustomFormat = "dd/MMM/yyyy";
            this.dt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ToDate.Location = new System.Drawing.Point(349, 108);
            this.dt_ToDate.Name = "dt_ToDate";
            this.dt_ToDate.Size = new System.Drawing.Size(110, 20);
            this.dt_ToDate.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "To Date";
            // 
            // dt_From
            // 
            this.dt_From.CustomFormat = "dd/MMM/yyyy";
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_From.Location = new System.Drawing.Point(193, 108);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(110, 20);
            this.dt_From.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "From Date";
            // 
            // RptStockStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 272);
            this.Controls.Add(this.optAllDates);
            this.Controls.Add(this.optRange);
            this.Controls.Add(this.dt_ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.chkSaleable);
            this.Controls.Add(this.chkConsumable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RptStockStatement";
            this.Text = "Stock Flow Statement Report";
            this.Load += new System.EventHandler(this.RptCurrentStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSaleable;
        private System.Windows.Forms.CheckBox chkConsumable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton optAllDates;
        private System.Windows.Forms.RadioButton optRange;
        private System.Windows.Forms.DateTimePicker dt_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.Label label2;
    }
}