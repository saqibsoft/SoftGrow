namespace SoftGrow.Definition
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOpValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPurPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.chkRawMaterial = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName});
            this.Grid.Location = new System.Drawing.Point(298, 112);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(286, 286);
            this.Grid.TabIndex = 18;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductID.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductID.HeaderText = "ID #";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 60;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 170;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(31, 183);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(31, 138);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID #";
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
            this.panel1.Location = new System.Drawing.Point(-1, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 50);
            this.panel1.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(319, 14);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(62, 23);
            this.btnSwitch.TabIndex = 12;
            this.btnSwitch.Text = "Select";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 35);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Products Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Opening  Stock Qty";
            // 
            // txtOpQty
            // 
            this.txtOpQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpQty.Location = new System.Drawing.Point(31, 329);
            this.txtOpQty.MaxLength = 25;
            this.txtOpQty.Name = "txtOpQty";
            this.txtOpQty.Size = new System.Drawing.Size(98, 20);
            this.txtOpQty.TabIndex = 6;
            this.txtOpQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForQty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Opening Stock Value";
            // 
            // txtOpValue
            // 
            this.txtOpValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpValue.Location = new System.Drawing.Point(177, 329);
            this.txtOpValue.MaxLength = 25;
            this.txtOpValue.Name = "txtOpValue";
            this.txtOpValue.Size = new System.Drawing.Size(104, 20);
            this.txtOpValue.TabIndex = 7;
            this.txtOpValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOpValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtOpValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Location = new System.Drawing.Point(298, 86);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(286, 20);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Unit";
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurPrice.Location = new System.Drawing.Point(31, 280);
            this.txtPurPrice.MaxLength = 150;
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.Size = new System.Drawing.Size(88, 20);
            this.txtPurPrice.TabIndex = 4;
            this.txtPurPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPurPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtPurPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Purchase Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalePrice.Location = new System.Drawing.Point(193, 280);
            this.txtSalePrice.MaxLength = 50;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(88, 20);
            this.txtSalePrice.TabIndex = 5;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Sale Price";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(31, 229);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(250, 21);
            this.cboUnit.TabIndex = 3;
            this.cboUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveNext_KeyDown);
            this.cboUnit.Leave += new System.EventHandler(this.cboUnit_Leave);
            // 
            // chkRawMaterial
            // 
            this.chkRawMaterial.AutoSize = true;
            this.chkRawMaterial.Location = new System.Drawing.Point(31, 368);
            this.chkRawMaterial.Name = "chkRawMaterial";
            this.chkRawMaterial.Size = new System.Drawing.Size(88, 17);
            this.chkRawMaterial.TabIndex = 8;
            this.chkRawMaterial.Text = "Raw Material";
            this.chkRawMaterial.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 457);
            this.Controls.Add(this.chkRawMaterial);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPurPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtOpValue);
            this.Controls.Add(this.txtOpQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Products";
            this.Text = "Products Information";
            this.Load += new System.EventHandler(this.PartiesInfo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Products_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOpQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOpValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPurPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.CheckBox chkRawMaterial;
    }
}