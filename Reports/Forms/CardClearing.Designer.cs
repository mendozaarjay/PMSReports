namespace Reports
{
    partial class CardClearing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardClearing));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTerminal = new System.Windows.Forms.ComboBox();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dgCardClearing = new System.Windows.Forms.DataGridView();
            this.dtlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEntranceGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlClearedUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardClearing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(154, 150);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 6;
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
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date To";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTerminal);
            this.groupBox1.Controls.Add(this.timeTo);
            this.groupBox1.Controls.Add(this.timeFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Terminal";
            // 
            // cboTerminal
            // 
            this.cboTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerminal.FormattingEnabled = true;
            this.cboTerminal.Location = new System.Drawing.Point(154, 113);
            this.cboTerminal.Name = "cboTerminal";
            this.cboTerminal.Size = new System.Drawing.Size(306, 31);
            this.cboTerminal.TabIndex = 17;
            // 
            // timeTo
            // 
            this.timeTo.CustomFormat = "hh:mm:ss tt";
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo.Location = new System.Drawing.Point(333, 74);
            this.timeTo.Name = "timeTo";
            this.timeTo.ShowUpDown = true;
            this.timeTo.Size = new System.Drawing.Size(127, 30);
            this.timeTo.TabIndex = 12;
            // 
            // timeFrom
            // 
            this.timeFrom.CustomFormat = "hh:mm:ss tt";
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom.Location = new System.Drawing.Point(333, 35);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.ShowUpDown = true;
            this.timeFrom.Size = new System.Drawing.Size(127, 30);
            this.timeFrom.TabIndex = 11;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MM/dd/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(154, 74);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(171, 30);
            this.dtTo.TabIndex = 10;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MM/dd/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(154, 35);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(171, 30);
            this.dtFrom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date From";
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
            this.splitContainer1.Panel2.Controls.Add(this.dgCardClearing);
            this.splitContainer1.Size = new System.Drawing.Size(1059, 621);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 3;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1059, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dgCardClearing
            // 
            this.dgCardClearing.AllowUserToAddRows = false;
            this.dgCardClearing.AllowUserToDeleteRows = false;
            this.dgCardClearing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCardClearing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardClearing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlId,
            this.dtlRow,
            this.dtlEntranceGate,
            this.dtlPlateNo,
            this.dtlTicketNo,
            this.dtlTimeIn,
            this.dtlComment,
            this.dtlClearedUser,
            this.dtlView});
            this.dgCardClearing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCardClearing.Location = new System.Drawing.Point(0, 0);
            this.dgCardClearing.Name = "dgCardClearing";
            this.dgCardClearing.ReadOnly = true;
            this.dgCardClearing.RowHeadersWidth = 51;
            this.dgCardClearing.RowTemplate.Height = 24;
            this.dgCardClearing.Size = new System.Drawing.Size(1059, 405);
            this.dgCardClearing.TabIndex = 0;
            this.dgCardClearing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCardClearing_CellContentClick);
            // 
            // dtlId
            // 
            this.dtlId.HeaderText = "Id";
            this.dtlId.MinimumWidth = 6;
            this.dtlId.Name = "dtlId";
            this.dtlId.ReadOnly = true;
            this.dtlId.Visible = false;
            this.dtlId.Width = 125;
            // 
            // dtlRow
            // 
            this.dtlRow.HeaderText = "Row";
            this.dtlRow.MinimumWidth = 6;
            this.dtlRow.Name = "dtlRow";
            this.dtlRow.ReadOnly = true;
            this.dtlRow.Width = 125;
            // 
            // dtlEntranceGate
            // 
            this.dtlEntranceGate.HeaderText = "Entrance Gate";
            this.dtlEntranceGate.MinimumWidth = 6;
            this.dtlEntranceGate.Name = "dtlEntranceGate";
            this.dtlEntranceGate.ReadOnly = true;
            this.dtlEntranceGate.Width = 150;
            // 
            // dtlPlateNo
            // 
            this.dtlPlateNo.HeaderText = "PlateNo";
            this.dtlPlateNo.MinimumWidth = 6;
            this.dtlPlateNo.Name = "dtlPlateNo";
            this.dtlPlateNo.ReadOnly = true;
            this.dtlPlateNo.Width = 125;
            // 
            // dtlTicketNo
            // 
            this.dtlTicketNo.HeaderText = "Ticket No";
            this.dtlTicketNo.MinimumWidth = 6;
            this.dtlTicketNo.Name = "dtlTicketNo";
            this.dtlTicketNo.ReadOnly = true;
            this.dtlTicketNo.Width = 125;
            // 
            // dtlTimeIn
            // 
            this.dtlTimeIn.HeaderText = "Time In";
            this.dtlTimeIn.MinimumWidth = 6;
            this.dtlTimeIn.Name = "dtlTimeIn";
            this.dtlTimeIn.ReadOnly = true;
            this.dtlTimeIn.Width = 125;
            // 
            // dtlComment
            // 
            this.dtlComment.HeaderText = "Comment";
            this.dtlComment.MinimumWidth = 6;
            this.dtlComment.Name = "dtlComment";
            this.dtlComment.ReadOnly = true;
            this.dtlComment.Width = 125;
            // 
            // dtlClearedUser
            // 
            this.dtlClearedUser.HeaderText = "Cleared User";
            this.dtlClearedUser.MinimumWidth = 6;
            this.dtlClearedUser.Name = "dtlClearedUser";
            this.dtlClearedUser.ReadOnly = true;
            this.dtlClearedUser.Width = 150;
            // 
            // dtlView
            // 
            this.dtlView.HeaderText = "View";
            this.dtlView.MinimumWidth = 6;
            this.dtlView.Name = "dtlView";
            this.dtlView.ReadOnly = true;
            this.dtlView.Width = 125;
            // 
            // CardClearing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 648);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CardClearing";
            this.Text = "Sales Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardClearing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTerminal;
        private System.Windows.Forms.DataGridView dgCardClearing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlEntranceGate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlClearedUser;
        private System.Windows.Forms.DataGridViewButtonColumn dtlView;
    }
}