namespace Reports
{
    partial class RemainingCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemainingCars));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgRemainingCars = new System.Windows.Forms.DataGridView();
            this.dtlAllNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllRFIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllRFIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAllParkerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRegular = new System.Windows.Forms.DataGridView();
            this.dtlRegularNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularRFIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularRFIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRegularParkerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVisitor = new System.Windows.Forms.DataGridView();
            this.dtlVisitorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorRFIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorRFIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlVisitorParkerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemainingCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitor)).BeginInit();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(903, 31);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 28);
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
            this.splitContainer1.Size = new System.Drawing.Size(903, 590);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(135, 97);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 6;
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
            this.dtDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 56);
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
            this.tabControl1.Size = new System.Drawing.Size(903, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgRemainingCars);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgRegular);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regular Parker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgVisitor);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(895, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visitor Parker";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgRemainingCars
            // 
            this.dgRemainingCars.AllowUserToAddRows = false;
            this.dgRemainingCars.AllowUserToDeleteRows = false;
            this.dgRemainingCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRemainingCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemainingCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlAllNo,
            this.dtlAllTimeIn,
            this.dtlAllPlateNo,
            this.dtlAllTicketNo,
            this.dtlAllRFIDName,
            this.dtlAllRFIDNo,
            this.dtlAllParkerType});
            this.dgRemainingCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRemainingCars.Location = new System.Drawing.Point(3, 3);
            this.dgRemainingCars.Name = "dgRemainingCars";
            this.dgRemainingCars.ReadOnly = true;
            this.dgRemainingCars.RowHeadersWidth = 51;
            this.dgRemainingCars.RowTemplate.Height = 24;
            this.dgRemainingCars.Size = new System.Drawing.Size(889, 373);
            this.dgRemainingCars.TabIndex = 2;
            // 
            // dtlAllNo
            // 
            this.dtlAllNo.HeaderText = "No";
            this.dtlAllNo.MinimumWidth = 6;
            this.dtlAllNo.Name = "dtlAllNo";
            this.dtlAllNo.ReadOnly = true;
            this.dtlAllNo.Width = 125;
            // 
            // dtlAllTimeIn
            // 
            this.dtlAllTimeIn.HeaderText = "Time In";
            this.dtlAllTimeIn.MinimumWidth = 6;
            this.dtlAllTimeIn.Name = "dtlAllTimeIn";
            this.dtlAllTimeIn.ReadOnly = true;
            this.dtlAllTimeIn.Width = 125;
            // 
            // dtlAllPlateNo
            // 
            this.dtlAllPlateNo.HeaderText = "Plate No";
            this.dtlAllPlateNo.MinimumWidth = 6;
            this.dtlAllPlateNo.Name = "dtlAllPlateNo";
            this.dtlAllPlateNo.ReadOnly = true;
            this.dtlAllPlateNo.Width = 125;
            // 
            // dtlAllTicketNo
            // 
            this.dtlAllTicketNo.HeaderText = "Ticket No";
            this.dtlAllTicketNo.MinimumWidth = 6;
            this.dtlAllTicketNo.Name = "dtlAllTicketNo";
            this.dtlAllTicketNo.ReadOnly = true;
            this.dtlAllTicketNo.Width = 125;
            // 
            // dtlAllRFIDName
            // 
            this.dtlAllRFIDName.HeaderText = "RFID Name";
            this.dtlAllRFIDName.MinimumWidth = 6;
            this.dtlAllRFIDName.Name = "dtlAllRFIDName";
            this.dtlAllRFIDName.ReadOnly = true;
            this.dtlAllRFIDName.Width = 125;
            // 
            // dtlAllRFIDNo
            // 
            this.dtlAllRFIDNo.HeaderText = "RFID No";
            this.dtlAllRFIDNo.MinimumWidth = 6;
            this.dtlAllRFIDNo.Name = "dtlAllRFIDNo";
            this.dtlAllRFIDNo.ReadOnly = true;
            this.dtlAllRFIDNo.Width = 125;
            // 
            // dtlAllParkerType
            // 
            this.dtlAllParkerType.HeaderText = "Parker Type";
            this.dtlAllParkerType.MinimumWidth = 6;
            this.dtlAllParkerType.Name = "dtlAllParkerType";
            this.dtlAllParkerType.ReadOnly = true;
            this.dtlAllParkerType.Width = 125;
            // 
            // dgRegular
            // 
            this.dgRegular.AllowUserToAddRows = false;
            this.dgRegular.AllowUserToDeleteRows = false;
            this.dgRegular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRegular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlRegularNo,
            this.dtlRegularTimeIn,
            this.dtlRegularPlateNo,
            this.dtlRegularTicketNo,
            this.dtlRegularRFIDName,
            this.dtlRegularRFIDNo,
            this.dtlRegularParkerType});
            this.dgRegular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegular.Location = new System.Drawing.Point(3, 3);
            this.dgRegular.Name = "dgRegular";
            this.dgRegular.ReadOnly = true;
            this.dgRegular.RowHeadersWidth = 51;
            this.dgRegular.RowTemplate.Height = 24;
            this.dgRegular.Size = new System.Drawing.Size(889, 373);
            this.dgRegular.TabIndex = 2;
            // 
            // dtlRegularNo
            // 
            this.dtlRegularNo.HeaderText = "No";
            this.dtlRegularNo.MinimumWidth = 6;
            this.dtlRegularNo.Name = "dtlRegularNo";
            this.dtlRegularNo.ReadOnly = true;
            this.dtlRegularNo.Width = 125;
            // 
            // dtlRegularTimeIn
            // 
            this.dtlRegularTimeIn.HeaderText = "Time In";
            this.dtlRegularTimeIn.MinimumWidth = 6;
            this.dtlRegularTimeIn.Name = "dtlRegularTimeIn";
            this.dtlRegularTimeIn.ReadOnly = true;
            this.dtlRegularTimeIn.Width = 125;
            // 
            // dtlRegularPlateNo
            // 
            this.dtlRegularPlateNo.HeaderText = "Plate No";
            this.dtlRegularPlateNo.MinimumWidth = 6;
            this.dtlRegularPlateNo.Name = "dtlRegularPlateNo";
            this.dtlRegularPlateNo.ReadOnly = true;
            this.dtlRegularPlateNo.Width = 125;
            // 
            // dtlRegularTicketNo
            // 
            this.dtlRegularTicketNo.HeaderText = "Ticket No";
            this.dtlRegularTicketNo.MinimumWidth = 6;
            this.dtlRegularTicketNo.Name = "dtlRegularTicketNo";
            this.dtlRegularTicketNo.ReadOnly = true;
            this.dtlRegularTicketNo.Width = 125;
            // 
            // dtlRegularRFIDName
            // 
            this.dtlRegularRFIDName.HeaderText = "RFID Name";
            this.dtlRegularRFIDName.MinimumWidth = 6;
            this.dtlRegularRFIDName.Name = "dtlRegularRFIDName";
            this.dtlRegularRFIDName.ReadOnly = true;
            this.dtlRegularRFIDName.Width = 125;
            // 
            // dtlRegularRFIDNo
            // 
            this.dtlRegularRFIDNo.HeaderText = "RFID No";
            this.dtlRegularRFIDNo.MinimumWidth = 6;
            this.dtlRegularRFIDNo.Name = "dtlRegularRFIDNo";
            this.dtlRegularRFIDNo.ReadOnly = true;
            this.dtlRegularRFIDNo.Width = 125;
            // 
            // dtlRegularParkerType
            // 
            this.dtlRegularParkerType.HeaderText = "Parker Type";
            this.dtlRegularParkerType.MinimumWidth = 6;
            this.dtlRegularParkerType.Name = "dtlRegularParkerType";
            this.dtlRegularParkerType.ReadOnly = true;
            this.dtlRegularParkerType.Width = 125;
            // 
            // dgVisitor
            // 
            this.dgVisitor.AllowUserToAddRows = false;
            this.dgVisitor.AllowUserToDeleteRows = false;
            this.dgVisitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlVisitorNo,
            this.dtlVisitorTimeIn,
            this.dtlVisitorPlateNo,
            this.dtlVisitorTicketNo,
            this.dtlVisitorRFIDName,
            this.dtlVisitorRFIDNo,
            this.dtlVisitorParkerType});
            this.dgVisitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVisitor.Location = new System.Drawing.Point(3, 3);
            this.dgVisitor.Name = "dgVisitor";
            this.dgVisitor.ReadOnly = true;
            this.dgVisitor.RowHeadersWidth = 51;
            this.dgVisitor.RowTemplate.Height = 24;
            this.dgVisitor.Size = new System.Drawing.Size(889, 373);
            this.dgVisitor.TabIndex = 2;
            // 
            // dtlVisitorNo
            // 
            this.dtlVisitorNo.HeaderText = "No";
            this.dtlVisitorNo.MinimumWidth = 6;
            this.dtlVisitorNo.Name = "dtlVisitorNo";
            this.dtlVisitorNo.ReadOnly = true;
            this.dtlVisitorNo.Width = 125;
            // 
            // dtlVisitorTimeIn
            // 
            this.dtlVisitorTimeIn.HeaderText = "Time In";
            this.dtlVisitorTimeIn.MinimumWidth = 6;
            this.dtlVisitorTimeIn.Name = "dtlVisitorTimeIn";
            this.dtlVisitorTimeIn.ReadOnly = true;
            this.dtlVisitorTimeIn.Width = 125;
            // 
            // dtlVisitorPlateNo
            // 
            this.dtlVisitorPlateNo.HeaderText = "Plate No";
            this.dtlVisitorPlateNo.MinimumWidth = 6;
            this.dtlVisitorPlateNo.Name = "dtlVisitorPlateNo";
            this.dtlVisitorPlateNo.ReadOnly = true;
            this.dtlVisitorPlateNo.Width = 125;
            // 
            // dtlVisitorTicketNo
            // 
            this.dtlVisitorTicketNo.HeaderText = "Ticket No";
            this.dtlVisitorTicketNo.MinimumWidth = 6;
            this.dtlVisitorTicketNo.Name = "dtlVisitorTicketNo";
            this.dtlVisitorTicketNo.ReadOnly = true;
            this.dtlVisitorTicketNo.Width = 125;
            // 
            // dtlVisitorRFIDName
            // 
            this.dtlVisitorRFIDName.HeaderText = "RFID Name";
            this.dtlVisitorRFIDName.MinimumWidth = 6;
            this.dtlVisitorRFIDName.Name = "dtlVisitorRFIDName";
            this.dtlVisitorRFIDName.ReadOnly = true;
            this.dtlVisitorRFIDName.Width = 125;
            // 
            // dtlVisitorRFIDNo
            // 
            this.dtlVisitorRFIDNo.HeaderText = "RFID No";
            this.dtlVisitorRFIDNo.MinimumWidth = 6;
            this.dtlVisitorRFIDNo.Name = "dtlVisitorRFIDNo";
            this.dtlVisitorRFIDNo.ReadOnly = true;
            this.dtlVisitorRFIDNo.Width = 125;
            // 
            // dtlVisitorParkerType
            // 
            this.dtlVisitorParkerType.HeaderText = "Parker Type";
            this.dtlVisitorParkerType.MinimumWidth = 6;
            this.dtlVisitorParkerType.Name = "dtlVisitorParkerType";
            this.dtlVisitorParkerType.ReadOnly = true;
            this.dtlVisitorParkerType.Width = 125;
            // 
            // RemainingCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 590);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RemainingCars";
            this.Text = "Remaining Cars Report";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemainingCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitor)).EndInit();
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
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgRemainingCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllRFIDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllRFIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAllParkerType;
        private System.Windows.Forms.DataGridView dgRegular;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularRFIDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularRFIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRegularParkerType;
        private System.Windows.Forms.DataGridView dgVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorRFIDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorRFIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlVisitorParkerType;
    }
}