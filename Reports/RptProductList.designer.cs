namespace SoftGrow.Reports
{
    partial class RptProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptProductList));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.chkSaleable = new System.Windows.Forms.CheckBox();
            this.chkConsumable = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optBothPrices = new System.Windows.Forms.RadioButton();
            this.optPurOnly = new System.Windows.Forms.RadioButton();
            this.optSaleOnly = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Location = new System.Drawing.Point(109, 91);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.ReadOnly = true;
            this.txt_ProductName.Size = new System.Drawing.Size(140, 20);
            this.txt_ProductName.TabIndex = 6;
            this.txt_ProductName.TabStop = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductID.Location = new System.Drawing.Point(44, 91);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(59, 20);
            this.txt_ProductID.TabIndex = 0;
            this.txt_ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged);
            this.txt_ProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            this.txt_ProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductID_KeyPress);
            // 
            // chkSaleable
            // 
            this.chkSaleable.AutoSize = true;
            this.chkSaleable.Location = new System.Drawing.Point(181, 127);
            this.chkSaleable.Name = "chkSaleable";
            this.chkSaleable.Size = new System.Drawing.Size(65, 17);
            this.chkSaleable.TabIndex = 2;
            this.chkSaleable.Text = "For Sale";
            this.chkSaleable.UseVisualStyleBackColor = true;
            // 
            // chkConsumable
            // 
            this.chkConsumable.AutoSize = true;
            this.chkConsumable.Location = new System.Drawing.Point(53, 127);
            this.chkConsumable.Name = "chkConsumable";
            this.chkConsumable.Size = new System.Drawing.Size(105, 17);
            this.chkConsumable.TabIndex = 1;
            this.chkConsumable.Text = "For Consumption";
            this.chkConsumable.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Location = new System.Drawing.Point(-1, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 50);
            this.panel1.TabIndex = 74;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(149, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(81, 14);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(62, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 28);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.Text = "Product List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSaleOnly);
            this.groupBox1.Controls.Add(this.optPurOnly);
            this.groupBox1.Controls.Add(this.optBothPrices);
            this.groupBox1.Location = new System.Drawing.Point(22, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 41);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Prices";
            // 
            // optBothPrices
            // 
            this.optBothPrices.AutoSize = true;
            this.optBothPrices.Checked = true;
            this.optBothPrices.Location = new System.Drawing.Point(13, 17);
            this.optBothPrices.Name = "optBothPrices";
            this.optBothPrices.Size = new System.Drawing.Size(47, 17);
            this.optBothPrices.TabIndex = 1;
            this.optBothPrices.TabStop = true;
            this.optBothPrices.Text = "Both";
            this.optBothPrices.UseVisualStyleBackColor = true;
            // 
            // optPurOnly
            // 
            this.optPurOnly.AutoSize = true;
            this.optPurOnly.Location = new System.Drawing.Point(68, 17);
            this.optPurOnly.Name = "optPurOnly";
            this.optPurOnly.Size = new System.Drawing.Size(94, 17);
            this.optPurOnly.TabIndex = 1;
            this.optPurOnly.Text = "Purchase Only";
            this.optPurOnly.UseVisualStyleBackColor = true;
            // 
            // optSaleOnly
            // 
            this.optSaleOnly.AutoSize = true;
            this.optSaleOnly.Location = new System.Drawing.Point(170, 17);
            this.optSaleOnly.Name = "optSaleOnly";
            this.optSaleOnly.Size = new System.Drawing.Size(70, 17);
            this.optSaleOnly.TabIndex = 1;
            this.optSaleOnly.Text = "Sale Only";
            this.optSaleOnly.UseVisualStyleBackColor = true;
            // 
            // RptProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "RptProductList";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.RptProductList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.CheckBox chkSaleable;
        private System.Windows.Forms.CheckBox chkConsumable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSaleOnly;
        private System.Windows.Forms.RadioButton optPurOnly;
        private System.Windows.Forms.RadioButton optBothPrices;
    }
}