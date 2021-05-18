namespace Reports
{
    partial class ZReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZReading));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.dgReading = new System.Windows.Forms.DataGridView();
            this.dtlDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlNewORNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOldORNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlNewFRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOldFRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTodaySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlNewSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOldSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTerminal = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1440, 27);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 24);
            this.btnRefresh.Text = "&Refresh";
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
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 24);
            this.btnExcel.Text = "&Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
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
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 24);
            this.btnFind.Text = "&Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgReading
            // 
            this.dgReading.AllowUserToAddRows = false;
            this.dgReading.AllowUserToDeleteRows = false;
            this.dgReading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlDate,
            this.dtlNewORNo,
            this.dtlOldORNo,
            this.dtlNewFRNo,
            this.dtlOldFRNo,
            this.dtlTodaySales,
            this.dtlNewSales,
            this.dtlOldSales});
            this.dgReading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReading.Location = new System.Drawing.Point(0, 0);
            this.dgReading.Name = "dgReading";
            this.dgReading.ReadOnly = true;
            this.dgReading.RowHeadersWidth = 51;
            this.dgReading.RowTemplate.Height = 24;
            this.dgReading.Size = new System.Drawing.Size(1440, 438);
            this.dgReading.TabIndex = 0;
            // 
            // dtlDate
            // 
            this.dtlDate.HeaderText = "Date";
            this.dtlDate.MinimumWidth = 6;
            this.dtlDate.Name = "dtlDate";
            this.dtlDate.ReadOnly = true;
            this.dtlDate.Width = 150;
            // 
            // dtlNewORNo
            // 
            this.dtlNewORNo.HeaderText = "New OR No";
            this.dtlNewORNo.MinimumWidth = 6;
            this.dtlNewORNo.Name = "dtlNewORNo";
            this.dtlNewORNo.ReadOnly = true;
            this.dtlNewORNo.Width = 150;
            // 
            // dtlOldORNo
            // 
            this.dtlOldORNo.HeaderText = "Old OR No";
            this.dtlOldORNo.MinimumWidth = 6;
            this.dtlOldORNo.Name = "dtlOldORNo";
            this.dtlOldORNo.ReadOnly = true;
            this.dtlOldORNo.Width = 150;
            // 
            // dtlNewFRNo
            // 
            this.dtlNewFRNo.HeaderText = "New FR No";
            this.dtlNewFRNo.MinimumWidth = 6;
            this.dtlNewFRNo.Name = "dtlNewFRNo";
            this.dtlNewFRNo.ReadOnly = true;
            this.dtlNewFRNo.Width = 150;
            // 
            // dtlOldFRNo
            // 
            this.dtlOldFRNo.HeaderText = "Old FR No";
            this.dtlOldFRNo.MinimumWidth = 6;
            this.dtlOldFRNo.Name = "dtlOldFRNo";
            this.dtlOldFRNo.ReadOnly = true;
            this.dtlOldFRNo.Width = 150;
            // 
            // dtlTodaySales
            // 
            dataGridViewCellStyle1.Format = "N2";
            this.dtlTodaySales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtlTodaySales.HeaderText = "Today Sales";
            this.dtlTodaySales.MinimumWidth = 6;
            this.dtlTodaySales.Name = "dtlTodaySales";
            this.dtlTodaySales.ReadOnly = true;
            this.dtlTodaySales.Width = 150;
            // 
            // dtlNewSales
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.dtlNewSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlNewSales.HeaderText = "New Sales";
            this.dtlNewSales.MinimumWidth = 6;
            this.dtlNewSales.Name = "dtlNewSales";
            this.dtlNewSales.ReadOnly = true;
            this.dtlNewSales.Width = 150;
            // 
            // dtlOldSales
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.dtlOldSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtlOldSales.HeaderText = "Old Sales";
            this.dtlOldSales.MinimumWidth = 6;
            this.dtlOldSales.Name = "dtlOldSales";
            this.dtlOldSales.ReadOnly = true;
            this.dtlOldSales.Width = 150;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgReading);
            this.splitContainer1.Size = new System.Drawing.Size(1440, 647);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 7;
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
            this.groupBox1.Size = new System.Drawing.Size(1416, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Terminal";
            // 
            // cbTerminal
            // 
            this.cbTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(154, 115);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(306, 31);
            this.cbTerminal.TabIndex = 2;
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
            this.btnGenerate.Location = new System.Drawing.Point(154, 154);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
            // ZReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 647);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZReading";
            this.Text = "Z Reading Report";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReading)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.DataGridView dgReading;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNewORNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOldORNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNewFRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOldFRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTodaySales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNewSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOldSales;
    }
}