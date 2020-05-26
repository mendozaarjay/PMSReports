namespace Reports
{
    partial class DetailedTransactionSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedTransactionSummary));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgDetailedTransaction = new System.Windows.Forms.DataGridView();
            this.dtlTransitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailedTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(154, 149);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MM/dd/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(154, 71);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(306, 30);
            this.dtTo.TabIndex = 4;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MM/dd/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(154, 32);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(306, 30);
            this.dtFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
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
            this.splitContainer1.Panel2.Controls.Add(this.dgDetailedTransaction);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 585);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgDetailedTransaction
            // 
            this.dgDetailedTransaction.AllowUserToAddRows = false;
            this.dgDetailedTransaction.AllowUserToDeleteRows = false;
            this.dgDetailedTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDetailedTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlTransitId,
            this.dtlLocation,
            this.dtlORNumber,
            this.dtlRateName,
            this.dtlTimeIn,
            this.dtlTimeOut,
            this.dtlDuration,
            this.dtlTotalHours,
            this.dtlPlateNo,
            this.dtlAmount,
            this.dtlCardNumber,
            this.dtlCashier,
            this.dtlImage});
            this.dgDetailedTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetailedTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgDetailedTransaction.Name = "dgDetailedTransaction";
            this.dgDetailedTransaction.ReadOnly = true;
            this.dgDetailedTransaction.RowHeadersWidth = 51;
            this.dgDetailedTransaction.RowTemplate.Height = 24;
            this.dgDetailedTransaction.Size = new System.Drawing.Size(1071, 368);
            this.dgDetailedTransaction.TabIndex = 0;
            this.dgDetailedTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailedTransaction_CellContentClick);
            // 
            // dtlTransitId
            // 
            this.dtlTransitId.HeaderText = "TransitId";
            this.dtlTransitId.MinimumWidth = 6;
            this.dtlTransitId.Name = "dtlTransitId";
            this.dtlTransitId.ReadOnly = true;
            this.dtlTransitId.Visible = false;
            this.dtlTransitId.Width = 200;
            // 
            // dtlLocation
            // 
            this.dtlLocation.HeaderText = "Location";
            this.dtlLocation.MinimumWidth = 6;
            this.dtlLocation.Name = "dtlLocation";
            this.dtlLocation.ReadOnly = true;
            this.dtlLocation.Width = 200;
            // 
            // dtlORNumber
            // 
            this.dtlORNumber.HeaderText = "OR Number";
            this.dtlORNumber.MinimumWidth = 6;
            this.dtlORNumber.Name = "dtlORNumber";
            this.dtlORNumber.ReadOnly = true;
            this.dtlORNumber.Width = 200;
            // 
            // dtlRateName
            // 
            this.dtlRateName.HeaderText = "Rate";
            this.dtlRateName.MinimumWidth = 6;
            this.dtlRateName.Name = "dtlRateName";
            this.dtlRateName.ReadOnly = true;
            this.dtlRateName.Width = 200;
            // 
            // dtlTimeIn
            // 
            this.dtlTimeIn.HeaderText = "Time In";
            this.dtlTimeIn.MinimumWidth = 6;
            this.dtlTimeIn.Name = "dtlTimeIn";
            this.dtlTimeIn.ReadOnly = true;
            this.dtlTimeIn.Width = 200;
            // 
            // dtlTimeOut
            // 
            this.dtlTimeOut.HeaderText = "Time Out";
            this.dtlTimeOut.MinimumWidth = 6;
            this.dtlTimeOut.Name = "dtlTimeOut";
            this.dtlTimeOut.ReadOnly = true;
            this.dtlTimeOut.Width = 200;
            // 
            // dtlDuration
            // 
            this.dtlDuration.HeaderText = "Duration (mins)";
            this.dtlDuration.MinimumWidth = 6;
            this.dtlDuration.Name = "dtlDuration";
            this.dtlDuration.ReadOnly = true;
            this.dtlDuration.Width = 200;
            // 
            // dtlTotalHours
            // 
            this.dtlTotalHours.HeaderText = "Total Hours";
            this.dtlTotalHours.MinimumWidth = 6;
            this.dtlTotalHours.Name = "dtlTotalHours";
            this.dtlTotalHours.ReadOnly = true;
            this.dtlTotalHours.Width = 200;
            // 
            // dtlPlateNo
            // 
            this.dtlPlateNo.HeaderText = "Plate No";
            this.dtlPlateNo.MinimumWidth = 6;
            this.dtlPlateNo.Name = "dtlPlateNo";
            this.dtlPlateNo.ReadOnly = true;
            this.dtlPlateNo.Width = 200;
            // 
            // dtlAmount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dtlAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlAmount.HeaderText = "Amount";
            this.dtlAmount.MinimumWidth = 6;
            this.dtlAmount.Name = "dtlAmount";
            this.dtlAmount.ReadOnly = true;
            this.dtlAmount.Width = 200;
            // 
            // dtlCardNumber
            // 
            this.dtlCardNumber.HeaderText = "Card Number";
            this.dtlCardNumber.MinimumWidth = 6;
            this.dtlCardNumber.Name = "dtlCardNumber";
            this.dtlCardNumber.ReadOnly = true;
            this.dtlCardNumber.Width = 200;
            // 
            // dtlCashier
            // 
            this.dtlCashier.HeaderText = "Cashier";
            this.dtlCashier.MinimumWidth = 6;
            this.dtlCashier.Name = "dtlCashier";
            this.dtlCashier.ReadOnly = true;
            this.dtlCashier.Width = 200;
            // 
            // dtlImage
            // 
            this.dtlImage.HeaderText = "Image";
            this.dtlImage.MinimumWidth = 6;
            this.dtlImage.Name = "dtlImage";
            this.dtlImage.ReadOnly = true;
            this.dtlImage.Width = 200;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1071, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // DetailedTransactionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 612);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailedTransactionSummary";
            this.Text = "Detailed Transaction Summary Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailedTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridView dgDetailedTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTransitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlORNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCashier;
        private System.Windows.Forms.DataGridViewButtonColumn dtlImage;
    }
}