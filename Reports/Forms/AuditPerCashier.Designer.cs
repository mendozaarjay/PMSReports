namespace Reports
{
    partial class AuditPerCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditPerCashier));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTerminal = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgAuditPerCashier = new System.Windows.Forms.DataGridView();
            this.dtlapcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcCashier6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlapcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgTicketAccountability = new System.Windows.Forms.DataGridView();
            this.dtltaDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaCashier6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgProcessedTickets = new System.Windows.Forms.DataGridView();
            this.dtlptDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptCashier6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditPerCashier)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketAccountability)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessedTickets)).BeginInit();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1013, 27);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1013, 647);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTerminal);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Terminal";
            // 
            // cbTerminal
            // 
            this.cbTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(135, 87);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(306, 31);
            this.cbTerminal.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(135, 124);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "MM/dd/yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(135, 50);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(306, 30);
            this.dtDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgAuditPerCashier);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Audit Per Cashier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgAuditPerCashier
            // 
            this.dgAuditPerCashier.AllowUserToAddRows = false;
            this.dgAuditPerCashier.AllowUserToDeleteRows = false;
            this.dgAuditPerCashier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgAuditPerCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuditPerCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlapcDescription,
            this.dtlapcCashier1,
            this.dtlapcCashier2,
            this.dtlapcCashier3,
            this.dtlapcCashier4,
            this.dtlapcCashier5,
            this.dtlapcCashier6,
            this.dtlapcTotal});
            this.dgAuditPerCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAuditPerCashier.Location = new System.Drawing.Point(3, 3);
            this.dgAuditPerCashier.Name = "dgAuditPerCashier";
            this.dgAuditPerCashier.ReadOnly = true;
            this.dgAuditPerCashier.RowHeadersWidth = 51;
            this.dgAuditPerCashier.RowTemplate.Height = 24;
            this.dgAuditPerCashier.Size = new System.Drawing.Size(999, 393);
            this.dgAuditPerCashier.TabIndex = 0;
            // 
            // dtlapcDescription
            // 
            this.dtlapcDescription.HeaderText = "Description";
            this.dtlapcDescription.MinimumWidth = 6;
            this.dtlapcDescription.Name = "dtlapcDescription";
            this.dtlapcDescription.ReadOnly = true;
            this.dtlapcDescription.Width = 150;
            // 
            // dtlapcCashier1
            // 
            this.dtlapcCashier1.HeaderText = "Cashier-1";
            this.dtlapcCashier1.MinimumWidth = 6;
            this.dtlapcCashier1.Name = "dtlapcCashier1";
            this.dtlapcCashier1.ReadOnly = true;
            this.dtlapcCashier1.Width = 125;
            // 
            // dtlapcCashier2
            // 
            this.dtlapcCashier2.HeaderText = "Cashier-2";
            this.dtlapcCashier2.MinimumWidth = 6;
            this.dtlapcCashier2.Name = "dtlapcCashier2";
            this.dtlapcCashier2.ReadOnly = true;
            this.dtlapcCashier2.Width = 125;
            // 
            // dtlapcCashier3
            // 
            this.dtlapcCashier3.HeaderText = "Cashier-3";
            this.dtlapcCashier3.MinimumWidth = 6;
            this.dtlapcCashier3.Name = "dtlapcCashier3";
            this.dtlapcCashier3.ReadOnly = true;
            this.dtlapcCashier3.Width = 125;
            // 
            // dtlapcCashier4
            // 
            this.dtlapcCashier4.HeaderText = "Cashier-4";
            this.dtlapcCashier4.MinimumWidth = 6;
            this.dtlapcCashier4.Name = "dtlapcCashier4";
            this.dtlapcCashier4.ReadOnly = true;
            this.dtlapcCashier4.Width = 125;
            // 
            // dtlapcCashier5
            // 
            this.dtlapcCashier5.HeaderText = "Cashier-5";
            this.dtlapcCashier5.MinimumWidth = 6;
            this.dtlapcCashier5.Name = "dtlapcCashier5";
            this.dtlapcCashier5.ReadOnly = true;
            this.dtlapcCashier5.Width = 125;
            // 
            // dtlapcCashier6
            // 
            this.dtlapcCashier6.HeaderText = "Cashier-6";
            this.dtlapcCashier6.MinimumWidth = 6;
            this.dtlapcCashier6.Name = "dtlapcCashier6";
            this.dtlapcCashier6.ReadOnly = true;
            this.dtlapcCashier6.Width = 125;
            // 
            // dtlapcTotal
            // 
            this.dtlapcTotal.HeaderText = "Total";
            this.dtlapcTotal.MinimumWidth = 6;
            this.dtlapcTotal.Name = "dtlapcTotal";
            this.dtlapcTotal.ReadOnly = true;
            this.dtlapcTotal.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgTicketAccountability);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ticket Accountability";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgTicketAccountability
            // 
            this.dgTicketAccountability.AllowUserToAddRows = false;
            this.dgTicketAccountability.AllowUserToDeleteRows = false;
            this.dgTicketAccountability.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTicketAccountability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTicketAccountability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtltaDescription,
            this.dtltaCashier1,
            this.dtltaCashier2,
            this.dtltaCashier3,
            this.dtltaCashier4,
            this.dtltaCashier5,
            this.dtltaCashier6,
            this.dtltaTotal});
            this.dgTicketAccountability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTicketAccountability.Location = new System.Drawing.Point(3, 3);
            this.dgTicketAccountability.Name = "dgTicketAccountability";
            this.dgTicketAccountability.ReadOnly = true;
            this.dgTicketAccountability.RowHeadersWidth = 51;
            this.dgTicketAccountability.RowTemplate.Height = 24;
            this.dgTicketAccountability.Size = new System.Drawing.Size(999, 400);
            this.dgTicketAccountability.TabIndex = 1;
            // 
            // dtltaDescription
            // 
            this.dtltaDescription.HeaderText = "Description";
            this.dtltaDescription.MinimumWidth = 6;
            this.dtltaDescription.Name = "dtltaDescription";
            this.dtltaDescription.ReadOnly = true;
            this.dtltaDescription.Width = 150;
            // 
            // dtltaCashier1
            // 
            this.dtltaCashier1.HeaderText = "Cashier-1";
            this.dtltaCashier1.MinimumWidth = 6;
            this.dtltaCashier1.Name = "dtltaCashier1";
            this.dtltaCashier1.ReadOnly = true;
            this.dtltaCashier1.Width = 125;
            // 
            // dtltaCashier2
            // 
            this.dtltaCashier2.HeaderText = "Cashier-2";
            this.dtltaCashier2.MinimumWidth = 6;
            this.dtltaCashier2.Name = "dtltaCashier2";
            this.dtltaCashier2.ReadOnly = true;
            this.dtltaCashier2.Width = 125;
            // 
            // dtltaCashier3
            // 
            this.dtltaCashier3.HeaderText = "Cashier-3";
            this.dtltaCashier3.MinimumWidth = 6;
            this.dtltaCashier3.Name = "dtltaCashier3";
            this.dtltaCashier3.ReadOnly = true;
            this.dtltaCashier3.Width = 125;
            // 
            // dtltaCashier4
            // 
            this.dtltaCashier4.HeaderText = "Cashier-4";
            this.dtltaCashier4.MinimumWidth = 6;
            this.dtltaCashier4.Name = "dtltaCashier4";
            this.dtltaCashier4.ReadOnly = true;
            this.dtltaCashier4.Width = 125;
            // 
            // dtltaCashier5
            // 
            this.dtltaCashier5.HeaderText = "Cashier-5";
            this.dtltaCashier5.MinimumWidth = 6;
            this.dtltaCashier5.Name = "dtltaCashier5";
            this.dtltaCashier5.ReadOnly = true;
            this.dtltaCashier5.Width = 125;
            // 
            // dtltaCashier6
            // 
            this.dtltaCashier6.HeaderText = "Cashier-6";
            this.dtltaCashier6.MinimumWidth = 6;
            this.dtltaCashier6.Name = "dtltaCashier6";
            this.dtltaCashier6.ReadOnly = true;
            this.dtltaCashier6.Width = 125;
            // 
            // dtltaTotal
            // 
            this.dtltaTotal.HeaderText = "Total";
            this.dtltaTotal.MinimumWidth = 6;
            this.dtltaTotal.Name = "dtltaTotal";
            this.dtltaTotal.ReadOnly = true;
            this.dtltaTotal.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgProcessedTickets);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1005, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Processed Tickets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgProcessedTickets
            // 
            this.dgProcessedTickets.AllowUserToAddRows = false;
            this.dgProcessedTickets.AllowUserToDeleteRows = false;
            this.dgProcessedTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgProcessedTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcessedTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlptDescription,
            this.dtlptCashier1,
            this.dtlptCashier2,
            this.dtlptCashier3,
            this.dtlptCashier4,
            this.dtlptCashier5,
            this.dtlptCashier6,
            this.dtlptTotal});
            this.dgProcessedTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProcessedTickets.Location = new System.Drawing.Point(3, 3);
            this.dgProcessedTickets.Name = "dgProcessedTickets";
            this.dgProcessedTickets.ReadOnly = true;
            this.dgProcessedTickets.RowHeadersWidth = 51;
            this.dgProcessedTickets.RowTemplate.Height = 24;
            this.dgProcessedTickets.Size = new System.Drawing.Size(999, 400);
            this.dgProcessedTickets.TabIndex = 2;
            // 
            // dtlptDescription
            // 
            this.dtlptDescription.HeaderText = "Description";
            this.dtlptDescription.MinimumWidth = 6;
            this.dtlptDescription.Name = "dtlptDescription";
            this.dtlptDescription.ReadOnly = true;
            this.dtlptDescription.Width = 150;
            // 
            // dtlptCashier1
            // 
            this.dtlptCashier1.HeaderText = "Cashier-1";
            this.dtlptCashier1.MinimumWidth = 6;
            this.dtlptCashier1.Name = "dtlptCashier1";
            this.dtlptCashier1.ReadOnly = true;
            this.dtlptCashier1.Width = 125;
            // 
            // dtlptCashier2
            // 
            this.dtlptCashier2.HeaderText = "Cashier-2";
            this.dtlptCashier2.MinimumWidth = 6;
            this.dtlptCashier2.Name = "dtlptCashier2";
            this.dtlptCashier2.ReadOnly = true;
            this.dtlptCashier2.Width = 125;
            // 
            // dtlptCashier3
            // 
            this.dtlptCashier3.HeaderText = "Cashier-3";
            this.dtlptCashier3.MinimumWidth = 6;
            this.dtlptCashier3.Name = "dtlptCashier3";
            this.dtlptCashier3.ReadOnly = true;
            this.dtlptCashier3.Width = 125;
            // 
            // dtlptCashier4
            // 
            this.dtlptCashier4.HeaderText = "Cashier-4";
            this.dtlptCashier4.MinimumWidth = 6;
            this.dtlptCashier4.Name = "dtlptCashier4";
            this.dtlptCashier4.ReadOnly = true;
            this.dtlptCashier4.Width = 125;
            // 
            // dtlptCashier5
            // 
            this.dtlptCashier5.HeaderText = "Cashier-5";
            this.dtlptCashier5.MinimumWidth = 6;
            this.dtlptCashier5.Name = "dtlptCashier5";
            this.dtlptCashier5.ReadOnly = true;
            this.dtlptCashier5.Width = 125;
            // 
            // dtlptCashier6
            // 
            this.dtlptCashier6.HeaderText = "Cashier-6";
            this.dtlptCashier6.MinimumWidth = 6;
            this.dtlptCashier6.Name = "dtlptCashier6";
            this.dtlptCashier6.ReadOnly = true;
            this.dtlptCashier6.Width = 125;
            // 
            // dtlptTotal
            // 
            this.dtlptTotal.HeaderText = "Total";
            this.dtlptTotal.MinimumWidth = 6;
            this.dtlptTotal.Name = "dtlptTotal";
            this.dtlptTotal.ReadOnly = true;
            this.dtlptTotal.Width = 125;
            // 
            // AuditPerCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 647);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuditPerCashier";
            this.Text = "Audit Per Cashier Report";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditPerCashier)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketAccountability)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessedTickets)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTerminal;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgAuditPerCashier;
        private System.Windows.Forms.DataGridView dgTicketAccountability;
        private System.Windows.Forms.DataGridView dgProcessedTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcCashier6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlapcTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaCashier6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptCashier6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptTotal;
    }
}