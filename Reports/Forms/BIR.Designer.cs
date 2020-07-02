namespace Reports
{
    partial class BIR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIR));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgBIR = new System.Windows.Forms.DataGridView();
            this.dtlDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlBeginningOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEndingOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlBeginningSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEndingSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDiscountSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDiscountPWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDiscountOthers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlGrossAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVatable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVatExempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlZeroRated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlResetCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlZCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbTerminal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTerminal);
            this.groupBox1.Controls.Add(this.cboYear);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(154, 74);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(306, 31);
            this.cboYear.TabIndex = 1;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(154, 32);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(306, 31);
            this.cboMonth.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(154, 161);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgBIR);
            this.splitContainer1.Size = new System.Drawing.Size(934, 619);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 5;
            // 
            // dgBIR
            // 
            this.dgBIR.AllowUserToAddRows = false;
            this.dgBIR.AllowUserToDeleteRows = false;
            this.dgBIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBIR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlDate,
            this.dtlBeginningOR,
            this.dtlEndingOR,
            this.dtlBeginningSales,
            this.dtlEndingSales,
            this.dtlTotalSales,
            this.dtlDiscountSC,
            this.dtlDiscountPWD,
            this.dtlDiscountOthers,
            this.dtlGrossAmount,
            this.dtlVatable,
            this.dtlVat,
            this.dtlVatExempt,
            this.dtlZeroRated,
            this.dtlResetCount,
            this.dtlZCounter,
            this.dtlRemarks});
            this.dgBIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBIR.Location = new System.Drawing.Point(0, 0);
            this.dgBIR.Name = "dgBIR";
            this.dgBIR.ReadOnly = true;
            this.dgBIR.RowHeadersWidth = 51;
            this.dgBIR.RowTemplate.Height = 24;
            this.dgBIR.Size = new System.Drawing.Size(934, 382);
            this.dgBIR.TabIndex = 0;
            // 
            // dtlDate
            // 
            this.dtlDate.HeaderText = "Date";
            this.dtlDate.MinimumWidth = 6;
            this.dtlDate.Name = "dtlDate";
            this.dtlDate.ReadOnly = true;
            this.dtlDate.Width = 200;
            // 
            // dtlBeginningOR
            // 
            this.dtlBeginningOR.HeaderText = "Beginning OR";
            this.dtlBeginningOR.MinimumWidth = 6;
            this.dtlBeginningOR.Name = "dtlBeginningOR";
            this.dtlBeginningOR.ReadOnly = true;
            this.dtlBeginningOR.Width = 200;
            // 
            // dtlEndingOR
            // 
            this.dtlEndingOR.HeaderText = "Ending OR";
            this.dtlEndingOR.MinimumWidth = 6;
            this.dtlEndingOR.Name = "dtlEndingOR";
            this.dtlEndingOR.ReadOnly = true;
            this.dtlEndingOR.Width = 200;
            // 
            // dtlBeginningSales
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dtlBeginningSales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtlBeginningSales.HeaderText = "Beginning Sales";
            this.dtlBeginningSales.MinimumWidth = 6;
            this.dtlBeginningSales.Name = "dtlBeginningSales";
            this.dtlBeginningSales.ReadOnly = true;
            this.dtlBeginningSales.Width = 200;
            // 
            // dtlEndingSales
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dtlEndingSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlEndingSales.HeaderText = "Ending Sales";
            this.dtlEndingSales.MinimumWidth = 6;
            this.dtlEndingSales.Name = "dtlEndingSales";
            this.dtlEndingSales.ReadOnly = true;
            this.dtlEndingSales.Width = 200;
            // 
            // dtlTotalSales
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dtlTotalSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtlTotalSales.HeaderText = "Total Sales";
            this.dtlTotalSales.MinimumWidth = 6;
            this.dtlTotalSales.Name = "dtlTotalSales";
            this.dtlTotalSales.ReadOnly = true;
            this.dtlTotalSales.Width = 200;
            // 
            // dtlDiscountSC
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dtlDiscountSC.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtlDiscountSC.HeaderText = "Discount (SC)";
            this.dtlDiscountSC.MinimumWidth = 6;
            this.dtlDiscountSC.Name = "dtlDiscountSC";
            this.dtlDiscountSC.ReadOnly = true;
            this.dtlDiscountSC.Width = 200;
            // 
            // dtlDiscountPWD
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dtlDiscountPWD.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtlDiscountPWD.HeaderText = "Discount(PWD)";
            this.dtlDiscountPWD.MinimumWidth = 6;
            this.dtlDiscountPWD.Name = "dtlDiscountPWD";
            this.dtlDiscountPWD.ReadOnly = true;
            this.dtlDiscountPWD.Width = 200;
            // 
            // dtlDiscountOthers
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dtlDiscountOthers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtlDiscountOthers.HeaderText = "Discount (Others)";
            this.dtlDiscountOthers.MinimumWidth = 6;
            this.dtlDiscountOthers.Name = "dtlDiscountOthers";
            this.dtlDiscountOthers.ReadOnly = true;
            this.dtlDiscountOthers.Width = 200;
            // 
            // dtlGrossAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dtlGrossAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtlGrossAmount.HeaderText = "Gross Amount";
            this.dtlGrossAmount.MinimumWidth = 6;
            this.dtlGrossAmount.Name = "dtlGrossAmount";
            this.dtlGrossAmount.ReadOnly = true;
            this.dtlGrossAmount.Width = 200;
            // 
            // dtlVatable
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dtlVatable.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtlVatable.HeaderText = "Vatable";
            this.dtlVatable.MinimumWidth = 6;
            this.dtlVatable.Name = "dtlVatable";
            this.dtlVatable.ReadOnly = true;
            this.dtlVatable.Width = 200;
            // 
            // dtlVat
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.dtlVat.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtlVat.HeaderText = "Vat";
            this.dtlVat.MinimumWidth = 6;
            this.dtlVat.Name = "dtlVat";
            this.dtlVat.ReadOnly = true;
            this.dtlVat.Width = 200;
            // 
            // dtlVatExempt
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dtlVatExempt.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtlVatExempt.HeaderText = "Vat Exempt";
            this.dtlVatExempt.MinimumWidth = 6;
            this.dtlVatExempt.Name = "dtlVatExempt";
            this.dtlVatExempt.ReadOnly = true;
            this.dtlVatExempt.Width = 200;
            // 
            // dtlZeroRated
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.dtlZeroRated.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtlZeroRated.HeaderText = "Zero Rated";
            this.dtlZeroRated.MinimumWidth = 6;
            this.dtlZeroRated.Name = "dtlZeroRated";
            this.dtlZeroRated.ReadOnly = true;
            this.dtlZeroRated.Width = 200;
            // 
            // dtlResetCount
            // 
            this.dtlResetCount.HeaderText = "Reset Count";
            this.dtlResetCount.MinimumWidth = 6;
            this.dtlResetCount.Name = "dtlResetCount";
            this.dtlResetCount.ReadOnly = true;
            this.dtlResetCount.Width = 200;
            // 
            // dtlZCounter
            // 
            this.dtlZCounter.HeaderText = "Z Counter";
            this.dtlZCounter.MinimumWidth = 6;
            this.dtlZCounter.Name = "dtlZCounter";
            this.dtlZCounter.ReadOnly = true;
            this.dtlZCounter.Width = 200;
            // 
            // dtlRemarks
            // 
            this.dtlRemarks.HeaderText = "Remarks";
            this.dtlRemarks.MinimumWidth = 6;
            this.dtlRemarks.Name = "dtlRemarks";
            this.dtlRemarks.ReadOnly = true;
            this.dtlRemarks.Width = 200;
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 24);
            this.btnFind.Text = "&Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 24);
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 24);
            this.btnExcel.Text = "&Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Image = ((System.Drawing.Image)(resources.GetObject("btnCsv.Image")));
            this.btnCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(59, 24);
            this.btnCsv.Text = "&CSV";
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 24);
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnCsv,
            this.btnExcel,
            this.btnPrint,
            this.btnFind});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(934, 27);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Terminal";
            // 
            // cbTerminal
            // 
            this.cbTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(154, 117);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(306, 31);
            this.cbTerminal.TabIndex = 2;
            // 
            // BIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 646);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BIR";
            this.Text = "BIR Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.DataGridView dgBIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlBeginningOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlEndingOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlBeginningSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlEndingSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDiscountSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDiscountPWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDiscountOthers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlGrossAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVatable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVatExempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlZeroRated;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlResetCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlZCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTerminal;
    }
}