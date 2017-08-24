namespace SoftGrow.Reports
{
    partial class RptCsutomerAging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCsutomerAging));
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaysExc = new System.Windows.Forms.TextBox();
            this.cboSalesman = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVendorName
            // 
            this.txtVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorName.Location = new System.Drawing.Point(96, 76);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.ReadOnly = true;
            this.txtVendorName.Size = new System.Drawing.Size(168, 20);
            this.txtVendorName.TabIndex = 6;
            // 
            // txtVendorID
            // 
            this.txtVendorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendorID.Location = new System.Drawing.Point(34, 76);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(55, 20);
            this.txtVendorID.TabIndex = 0;
            this.txtVendorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            this.txtVendorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
            this.txtVendorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Party";
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(106, 243);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(70, 17);
            this.chkCustomer.TabIndex = 2;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            this.chkCustomer.Visible = false;
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.Location = new System.Drawing.Point(36, 243);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(64, 17);
            this.chkSupplier.TabIndex = 1;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            this.chkSupplier.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Location = new System.Drawing.Point(-1, 187);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 56);
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
            this.lblTitle.Location = new System.Drawing.Point(10, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 28);
            this.lblTitle.TabIndex = 77;
            this.lblTitle.Text = "Customer\'s Aging";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Day\'s Exceeding";
            // 
            // txtDaysExc
            // 
            this.txtDaysExc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDaysExc.Location = new System.Drawing.Point(121, 104);
            this.txtDaysExc.Name = "txtDaysExc";
            this.txtDaysExc.Size = new System.Drawing.Size(55, 20);
            this.txtDaysExc.TabIndex = 0;
            this.txtDaysExc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDaysExc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            this.txtDaysExc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendor_KeyPress);
            // 
            // cboSalesman
            // 
            this.cboSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSalesman.FormattingEnabled = true;
            this.cboSalesman.Location = new System.Drawing.Point(34, 149);
            this.cboSalesman.Name = "cboSalesman";
            this.cboSalesman.Size = new System.Drawing.Size(196, 21);
            this.cboSalesman.TabIndex = 85;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 84;
            this.label18.Text = "Salesman";
            // 
            // RptCsutomerAging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 231);
            this.Controls.Add(this.cboSalesman);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkCustomer);
            this.Controls.Add(this.chkSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.txtDaysExc);
            this.Controls.Add(this.txtVendorID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RptCsutomerAging";
            this.Text = "Customer\'s Aging";
            this.Load += new System.EventHandler(this.RptPartyList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDaysExc;
        private System.Windows.Forms.ComboBox cboSalesman;
        private System.Windows.Forms.Label label18;
    }
}