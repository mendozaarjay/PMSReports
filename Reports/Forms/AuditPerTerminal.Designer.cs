namespace Reports
{
    partial class AuditPerTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditPerTerminal));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgTicketAccountability = new System.Windows.Forms.DataGridView();
            this.dtltaDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaTerminal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaTerminal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaTerminal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtltaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgProcessedTickets = new System.Windows.Forms.DataGridView();
            this.dtlptDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptTerminal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptTerminal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptTerminal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlptTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgAuditPerTerminal = new System.Windows.Forms.DataGridView();
            this.dtlaptDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlaptTerminal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlaptTerminal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlaptTerminal3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlaptTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketAccountability)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessedTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditPerTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgTicketAccountability);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 447);
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
            this.dtltaTerminal1,
            this.dtltaTerminal2,
            this.dtltaTerminal3,
            this.dtltaTotal});
            this.dgTicketAccountability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTicketAccountability.Location = new System.Drawing.Point(3, 3);
            this.dgTicketAccountability.Name = "dgTicketAccountability";
            this.dgTicketAccountability.ReadOnly = true;
            this.dgTicketAccountability.RowHeadersWidth = 51;
            this.dgTicketAccountability.RowTemplate.Height = 24;
            this.dgTicketAccountability.Size = new System.Drawing.Size(886, 441);
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
            // dtltaTerminal1
            // 
            this.dtltaTerminal1.HeaderText = "Terminal-1";
            this.dtltaTerminal1.MinimumWidth = 6;
            this.dtltaTerminal1.Name = "dtltaTerminal1";
            this.dtltaTerminal1.ReadOnly = true;
            this.dtltaTerminal1.Width = 125;
            // 
            // dtltaTerminal2
            // 
            this.dtltaTerminal2.HeaderText = "Terminal-2";
            this.dtltaTerminal2.MinimumWidth = 6;
            this.dtltaTerminal2.Name = "dtltaTerminal2";
            this.dtltaTerminal2.ReadOnly = true;
            this.dtltaTerminal2.Width = 125;
            // 
            // dtltaTerminal3
            // 
            this.dtltaTerminal3.HeaderText = "Terminal-3";
            this.dtltaTerminal3.MinimumWidth = 6;
            this.dtltaTerminal3.Name = "dtltaTerminal3";
            this.dtltaTerminal3.ReadOnly = true;
            this.dtltaTerminal3.Width = 125;
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
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(892, 447);
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
            this.dtlptTerminal1,
            this.dtlptTerminal2,
            this.dtlptTerminal3,
            this.dtlptTotal});
            this.dgProcessedTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProcessedTickets.Location = new System.Drawing.Point(3, 3);
            this.dgProcessedTickets.Name = "dgProcessedTickets";
            this.dgProcessedTickets.ReadOnly = true;
            this.dgProcessedTickets.RowHeadersWidth = 51;
            this.dgProcessedTickets.RowTemplate.Height = 24;
            this.dgProcessedTickets.Size = new System.Drawing.Size(886, 441);
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
            // dtlptTerminal1
            // 
            this.dtlptTerminal1.HeaderText = "Terminal-1";
            this.dtlptTerminal1.MinimumWidth = 6;
            this.dtlptTerminal1.Name = "dtlptTerminal1";
            this.dtlptTerminal1.ReadOnly = true;
            this.dtlptTerminal1.Width = 125;
            // 
            // dtlptTerminal2
            // 
            this.dtlptTerminal2.HeaderText = "Terminal-2";
            this.dtlptTerminal2.MinimumWidth = 6;
            this.dtlptTerminal2.Name = "dtlptTerminal2";
            this.dtlptTerminal2.ReadOnly = true;
            this.dtlptTerminal2.Width = 125;
            // 
            // dtlptTerminal3
            // 
            this.dtlptTerminal3.HeaderText = "Terminal-3";
            this.dtlptTerminal3.MinimumWidth = 6;
            this.dtlptTerminal3.Name = "dtlptTerminal3";
            this.dtlptTerminal3.ReadOnly = true;
            this.dtlptTerminal3.Width = 125;
            // 
            // dtlptTotal
            // 
            this.dtlptTotal.HeaderText = "Total";
            this.dtlptTotal.MinimumWidth = 6;
            this.dtlptTotal.Name = "dtlptTotal";
            this.dtlptTotal.ReadOnly = true;
            this.dtlptTotal.Width = 125;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(900, 27);
            this.bindingNavigator1.TabIndex = 12;
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
            this.splitContainer1.Size = new System.Drawing.Size(900, 647);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 13;
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
            this.groupBox1.Size = new System.Drawing.Size(876, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(135, 91);
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
            this.tabControl1.Size = new System.Drawing.Size(900, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgAuditPerTerminal);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Audit Per Terminal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgAuditPerTerminal
            // 
            this.dgAuditPerTerminal.AllowUserToAddRows = false;
            this.dgAuditPerTerminal.AllowUserToDeleteRows = false;
            this.dgAuditPerTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgAuditPerTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAuditPerTerminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlaptDescription,
            this.dtlaptTerminal1,
            this.dtlaptTerminal2,
            this.dtlaptTerminal3,
            this.dtlaptTotal});
            this.dgAuditPerTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAuditPerTerminal.Location = new System.Drawing.Point(3, 3);
            this.dgAuditPerTerminal.Name = "dgAuditPerTerminal";
            this.dgAuditPerTerminal.ReadOnly = true;
            this.dgAuditPerTerminal.RowHeadersWidth = 51;
            this.dgAuditPerTerminal.RowTemplate.Height = 24;
            this.dgAuditPerTerminal.Size = new System.Drawing.Size(886, 441);
            this.dgAuditPerTerminal.TabIndex = 0;
            // 
            // dtlaptDescription
            // 
            this.dtlaptDescription.HeaderText = "Description";
            this.dtlaptDescription.MinimumWidth = 6;
            this.dtlaptDescription.Name = "dtlaptDescription";
            this.dtlaptDescription.ReadOnly = true;
            this.dtlaptDescription.Width = 150;
            // 
            // dtlaptTerminal1
            // 
            this.dtlaptTerminal1.HeaderText = "Terminal-1";
            this.dtlaptTerminal1.MinimumWidth = 6;
            this.dtlaptTerminal1.Name = "dtlaptTerminal1";
            this.dtlaptTerminal1.ReadOnly = true;
            this.dtlaptTerminal1.Width = 125;
            // 
            // dtlaptTerminal2
            // 
            this.dtlaptTerminal2.HeaderText = "Terminal-2";
            this.dtlaptTerminal2.MinimumWidth = 6;
            this.dtlaptTerminal2.Name = "dtlaptTerminal2";
            this.dtlaptTerminal2.ReadOnly = true;
            this.dtlaptTerminal2.Width = 125;
            // 
            // dtlaptTerminal3
            // 
            this.dtlaptTerminal3.HeaderText = "Terminal-3";
            this.dtlaptTerminal3.MinimumWidth = 6;
            this.dtlaptTerminal3.Name = "dtlaptTerminal3";
            this.dtlaptTerminal3.ReadOnly = true;
            this.dtlaptTerminal3.Width = 125;
            // 
            // dtlaptTotal
            // 
            this.dtlaptTotal.HeaderText = "Total";
            this.dtlaptTotal.MinimumWidth = 6;
            this.dtlaptTotal.Name = "dtlaptTotal";
            this.dtlaptTotal.ReadOnly = true;
            this.dtlaptTotal.Width = 125;
            // 
            // AuditPerTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuditPerTerminal";
            this.Text = "Audit Per Terminal Report";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTicketAccountability)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessedTickets)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAuditPerTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.DataGridView dgAuditPerTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlaptDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlaptTerminal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlaptTerminal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlaptTerminal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlaptTotal;
        private System.Windows.Forms.DataGridView dgTicketAccountability;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaTerminal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaTerminal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaTerminal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtltaTotal;
        private System.Windows.Forms.DataGridView dgProcessedTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptTerminal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptTerminal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptTerminal3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlptTotal;
    }
}