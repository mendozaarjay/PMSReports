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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedTransactionSummary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTerminal = new System.Windows.Forms.ComboBox();
            this.cbShowImages = new System.Windows.Forms.CheckBox();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgDetailedTransaction = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dtlRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTransitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEntranceGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlSCPWDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlSCPWDAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlSCPWDId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLCPenalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLCLicenseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlLCORCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOvernight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEntranceImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtlExitImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtlViewImage = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.btnGenerate.Location = new System.Drawing.Point(154, 187);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(306, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 152);
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTerminal);
            this.groupBox1.Controls.Add(this.cbShowImages);
            this.groupBox1.Controls.Add(this.timeTo);
            this.groupBox1.Controls.Add(this.timeFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1360, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Terminal";
            // 
            // cboTerminal
            // 
            this.cboTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerminal.FormattingEnabled = true;
            this.cboTerminal.Location = new System.Drawing.Point(154, 110);
            this.cboTerminal.Name = "cboTerminal";
            this.cboTerminal.Size = new System.Drawing.Size(306, 31);
            this.cboTerminal.TabIndex = 4;
            // 
            // cbShowImages
            // 
            this.cbShowImages.AutoSize = true;
            this.cbShowImages.Location = new System.Drawing.Point(483, 192);
            this.cbShowImages.Name = "cbShowImages";
            this.cbShowImages.Size = new System.Drawing.Size(133, 27);
            this.cbShowImages.TabIndex = 7;
            this.cbShowImages.Text = "Show Images";
            this.cbShowImages.UseVisualStyleBackColor = true;
            this.cbShowImages.CheckedChanged += new System.EventHandler(this.cbShowImages_CheckedChanged);
            // 
            // timeTo
            // 
            this.timeTo.CustomFormat = "hh:mm:ss tt";
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo.Location = new System.Drawing.Point(333, 74);
            this.timeTo.Name = "timeTo";
            this.timeTo.ShowUpDown = true;
            this.timeTo.Size = new System.Drawing.Size(127, 30);
            this.timeTo.TabIndex = 3;
            // 
            // timeFrom
            // 
            this.timeFrom.CustomFormat = "hh:mm:ss tt";
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom.Location = new System.Drawing.Point(333, 35);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.ShowUpDown = true;
            this.timeFrom.Size = new System.Drawing.Size(127, 30);
            this.timeFrom.TabIndex = 1;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MM/dd/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(154, 74);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(171, 30);
            this.dtTo.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MM/dd/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(154, 35);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(171, 30);
            this.dtFrom.TabIndex = 0;
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
            this.splitContainer1.Size = new System.Drawing.Size(1384, 621);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 3;
            // 
            // dgDetailedTransaction
            // 
            this.dgDetailedTransaction.AllowUserToAddRows = false;
            this.dgDetailedTransaction.AllowUserToDeleteRows = false;
            this.dgDetailedTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDetailedTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlRow,
            this.dtlTransitId,
            this.dtlLocation,
            this.dtlEntranceGate,
            this.dtlTerminal,
            this.dtlORNumber,
            this.dtlRateName,
            this.dtlTimeIn,
            this.dtlTimeOut,
            this.dtlDuration,
            this.dtlTotalHours,
            this.dtlPlateNo,
            this.dtlAmount,
            this.dtlSCPWDName,
            this.dtlSCPWDAddress,
            this.dtlSCPWDId,
            this.dtlLCPenalty,
            this.dtlLCName,
            this.dtlLCLicenseNo,
            this.dtlLCORCR,
            this.dtlOvernight,
            this.dtlCardNumber,
            this.dtlCashier,
            this.dtlEntranceImage,
            this.dtlExitImage,
            this.dtlViewImage});
            this.dgDetailedTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetailedTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgDetailedTransaction.Name = "dgDetailedTransaction";
            this.dgDetailedTransaction.ReadOnly = true;
            this.dgDetailedTransaction.RowHeadersWidth = 51;
            this.dgDetailedTransaction.RowTemplate.Height = 24;
            this.dgDetailedTransaction.Size = new System.Drawing.Size(1384, 362);
            this.dgDetailedTransaction.TabIndex = 0;
            this.dgDetailedTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailedTransaction_CellContentClick);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1384, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dtlRow
            // 
            this.dtlRow.HeaderText = "Row";
            this.dtlRow.MinimumWidth = 6;
            this.dtlRow.Name = "dtlRow";
            this.dtlRow.ReadOnly = true;
            this.dtlRow.Width = 125;
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
            // dtlEntranceGate
            // 
            this.dtlEntranceGate.HeaderText = "Entrance";
            this.dtlEntranceGate.MinimumWidth = 6;
            this.dtlEntranceGate.Name = "dtlEntranceGate";
            this.dtlEntranceGate.ReadOnly = true;
            this.dtlEntranceGate.Width = 125;
            // 
            // dtlTerminal
            // 
            this.dtlTerminal.HeaderText = "Terminal";
            this.dtlTerminal.MinimumWidth = 6;
            this.dtlTerminal.Name = "dtlTerminal";
            this.dtlTerminal.ReadOnly = true;
            this.dtlTerminal.Width = 125;
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
            this.dtlDuration.HeaderText = "Duration";
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
            this.dtlTotalHours.Visible = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dtlAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtlAmount.HeaderText = "Amount";
            this.dtlAmount.MinimumWidth = 6;
            this.dtlAmount.Name = "dtlAmount";
            this.dtlAmount.ReadOnly = true;
            this.dtlAmount.Width = 200;
            // 
            // dtlSCPWDName
            // 
            this.dtlSCPWDName.HeaderText = "SC/PWD Name";
            this.dtlSCPWDName.MinimumWidth = 6;
            this.dtlSCPWDName.Name = "dtlSCPWDName";
            this.dtlSCPWDName.ReadOnly = true;
            this.dtlSCPWDName.Width = 125;
            // 
            // dtlSCPWDAddress
            // 
            this.dtlSCPWDAddress.HeaderText = "SC/PWD Address";
            this.dtlSCPWDAddress.MinimumWidth = 6;
            this.dtlSCPWDAddress.Name = "dtlSCPWDAddress";
            this.dtlSCPWDAddress.ReadOnly = true;
            this.dtlSCPWDAddress.Width = 125;
            // 
            // dtlSCPWDId
            // 
            this.dtlSCPWDId.HeaderText = "SC/PWD I.D";
            this.dtlSCPWDId.MinimumWidth = 6;
            this.dtlSCPWDId.Name = "dtlSCPWDId";
            this.dtlSCPWDId.ReadOnly = true;
            this.dtlSCPWDId.Width = 125;
            // 
            // dtlLCPenalty
            // 
            this.dtlLCPenalty.HeaderText = "Lost Card Penalty";
            this.dtlLCPenalty.MinimumWidth = 6;
            this.dtlLCPenalty.Name = "dtlLCPenalty";
            this.dtlLCPenalty.ReadOnly = true;
            this.dtlLCPenalty.Width = 125;
            // 
            // dtlLCName
            // 
            this.dtlLCName.HeaderText = "Lost Card Name";
            this.dtlLCName.MinimumWidth = 6;
            this.dtlLCName.Name = "dtlLCName";
            this.dtlLCName.ReadOnly = true;
            this.dtlLCName.Width = 125;
            // 
            // dtlLCLicenseNo
            // 
            this.dtlLCLicenseNo.HeaderText = "Lost Card License No";
            this.dtlLCLicenseNo.MinimumWidth = 6;
            this.dtlLCLicenseNo.Name = "dtlLCLicenseNo";
            this.dtlLCLicenseNo.ReadOnly = true;
            this.dtlLCLicenseNo.Width = 125;
            // 
            // dtlLCORCR
            // 
            this.dtlLCORCR.HeaderText = "Lost Card OR/CR";
            this.dtlLCORCR.MinimumWidth = 6;
            this.dtlLCORCR.Name = "dtlLCORCR";
            this.dtlLCORCR.ReadOnly = true;
            this.dtlLCORCR.Width = 125;
            // 
            // dtlOvernight
            // 
            this.dtlOvernight.HeaderText = "Overnight Penalty";
            this.dtlOvernight.MinimumWidth = 6;
            this.dtlOvernight.Name = "dtlOvernight";
            this.dtlOvernight.ReadOnly = true;
            this.dtlOvernight.Width = 125;
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
            this.dtlCashier.HeaderText = "Cashier/User";
            this.dtlCashier.MinimumWidth = 6;
            this.dtlCashier.Name = "dtlCashier";
            this.dtlCashier.ReadOnly = true;
            this.dtlCashier.Width = 200;
            // 
            // dtlEntranceImage
            // 
            this.dtlEntranceImage.HeaderText = "Entrance Image";
            this.dtlEntranceImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dtlEntranceImage.MinimumWidth = 6;
            this.dtlEntranceImage.Name = "dtlEntranceImage";
            this.dtlEntranceImage.ReadOnly = true;
            this.dtlEntranceImage.Width = 250;
            // 
            // dtlExitImage
            // 
            this.dtlExitImage.HeaderText = "Exit Image";
            this.dtlExitImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dtlExitImage.MinimumWidth = 6;
            this.dtlExitImage.Name = "dtlExitImage";
            this.dtlExitImage.ReadOnly = true;
            this.dtlExitImage.Width = 250;
            // 
            // dtlViewImage
            // 
            this.dtlViewImage.HeaderText = "View";
            this.dtlViewImage.MinimumWidth = 6;
            this.dtlViewImage.Name = "dtlViewImage";
            this.dtlViewImage.ReadOnly = true;
            this.dtlViewImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtlViewImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtlViewImage.Width = 50;
            // 
            // DetailedTransactionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 648);
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
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.CheckBox cbShowImages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTransitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlEntranceGate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlORNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlSCPWDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlSCPWDAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlSCPWDId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLCPenalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLCLicenseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlLCORCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOvernight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCashier;
        private System.Windows.Forms.DataGridViewImageColumn dtlEntranceImage;
        private System.Windows.Forms.DataGridViewImageColumn dtlExitImage;
        private System.Windows.Forms.DataGridViewButtonColumn dtlViewImage;
    }
}