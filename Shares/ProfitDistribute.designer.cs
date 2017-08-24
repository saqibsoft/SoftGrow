namespace SoftGrow.Shares
{
    partial class ProfitDistribute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitDistribute));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.dt_Entry = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGetProfit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDistID = new System.Windows.Forms.TextBox();
            this.cboScheme = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDistribute = new System.Windows.Forms.Button();
            this.txtTotalShares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Location = new System.Drawing.Point(20, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 271);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.MemberID,
            this.MemberName,
            this.Shares,
            this.Rate,
            this.Amount});
            this.Grid.Location = new System.Drawing.Point(9, 11);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 30;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.Size = new System.Drawing.Size(644, 254);
            this.Grid.TabIndex = 0;
            this.Grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValidated);
            // 
            // dt_Entry
            // 
            this.dt_Entry.CustomFormat = "dd-MMM-yyyy";
            this.dt_Entry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Entry.Location = new System.Drawing.Point(202, 100);
            this.dt_Entry.Name = "dt_Entry";
            this.dt_Entry.Size = new System.Drawing.Size(108, 20);
            this.dt_Entry.TabIndex = 3;
            this.dt_Entry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Remarks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Net Profit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Distributed Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entry Date";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(76, 460);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(605, 20);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNetProfit.Location = new System.Drawing.Point(531, 130);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.Size = new System.Drawing.Size(82, 20);
            this.txtNetProfit.TabIndex = 7;
            this.txtNetProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNetProfit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToNextCont);
            this.txtNetProfit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ForAmount_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(553, 433);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(91, 20);
            this.txtTotalAmount.TabIndex = 14;
            this.txtTotalAmount.TabStop = false;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Eras Bold ITC", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(41, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 35);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Profit Distribution";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 50);
            this.panel1.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(411, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(474, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(345, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(62, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(151, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGetProfit
            // 
            this.btnGetProfit.Location = new System.Drawing.Point(278, 130);
            this.btnGetProfit.Name = "btnGetProfit";
            this.btnGetProfit.Size = new System.Drawing.Size(41, 23);
            this.btnGetProfit.TabIndex = 8;
            this.btnGetProfit.Text = "Load";
            this.btnGetProfit.UseVisualStyleBackColor = true;
            this.btnGetProfit.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // txtDistID
            // 
            this.txtDistID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDistID.Location = new System.Drawing.Point(77, 100);
            this.txtDistID.Name = "txtDistID";
            this.txtDistID.ReadOnly = true;
            this.txtDistID.Size = new System.Drawing.Size(59, 20);
            this.txtDistID.TabIndex = 1;
            this.txtDistID.TabStop = false;
            this.txtDistID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboScheme
            // 
            this.cboScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScheme.FormattingEnabled = true;
            this.cboScheme.Location = new System.Drawing.Point(77, 131);
            this.cboScheme.Name = "cboScheme";
            this.cboScheme.Size = new System.Drawing.Size(195, 21);
            this.cboScheme.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Scheme";
            // 
            // btnDistribute
            // 
            this.btnDistribute.Location = new System.Drawing.Point(616, 128);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(65, 23);
            this.btnDistribute.TabIndex = 9;
            this.btnDistribute.Text = "Distribute";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // txtTotalShares
            // 
            this.txtTotalShares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalShares.Location = new System.Drawing.Point(374, 131);
            this.txtTotalShares.Name = "txtTotalShares";
            this.txtTotalShares.ReadOnly = true;
            this.txtTotalShares.Size = new System.Drawing.Size(99, 20);
            this.txtTotalShares.TabIndex = 1;
            this.txtTotalShares.TabStop = false;
            this.txtTotalShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shares";
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.Frozen = true;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 40;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MemberID.DefaultCellStyle = dataGridViewCellStyle2;
            this.MemberID.HeaderText = "ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.ToolTipText = "Product ID";
            this.MemberID.Width = 60;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "MemberName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MemberName.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 225;
            // 
            // Shares
            // 
            this.Shares.DataPropertyName = "Bought";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Shares.DefaultCellStyle = dataGridViewCellStyle4;
            this.Shares.HeaderText = "Shares";
            this.Shares.Name = "Shares";
            this.Shares.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rate.DataPropertyName = "ProfitRate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Rate.DefaultCellStyle = dataGridViewCellStyle5;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 55;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "ProfitAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // ProfitDistribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 537);
            this.Controls.Add(this.cboScheme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDistribute);
            this.Controls.Add(this.btnGetProfit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_Entry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtNetProfit);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtTotalShares);
            this.Controls.Add(this.txtDistID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfitDistribute";
            this.Text = "Profit Distribution";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker dt_Entry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtNetProfit;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGetProfit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDistID;
        private System.Windows.Forms.ComboBox cboScheme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.TextBox txtTotalShares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}