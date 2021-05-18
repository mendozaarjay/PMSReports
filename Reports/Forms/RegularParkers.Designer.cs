
namespace Reports
{
    partial class RegularParkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularParkers));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.dtlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlParker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDateIssued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlValidFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlValidTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(923, 27);
            this.bindingNavigator1.TabIndex = 3;
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDetails);
            this.splitContainer1.Size = new System.Drawing.Size(923, 565);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 37);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgDetails
            // 
            this.dgDetails.AllowUserToAddRows = false;
            this.dgDetails.AllowUserToDeleteRows = false;
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlId,
            this.dtlRFID,
            this.dtlParker,
            this.dtlCompany,
            this.dtlDateIssued,
            this.dtlValidFrom,
            this.dtlValidTo,
            this.dtlStatus});
            this.dgDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetails.Location = new System.Drawing.Point(0, 0);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.RowHeadersWidth = 51;
            this.dgDetails.RowTemplate.Height = 24;
            this.dgDetails.Size = new System.Drawing.Size(923, 494);
            this.dgDetails.TabIndex = 0;
            // 
            // dtlId
            // 
            this.dtlId.HeaderText = "Id";
            this.dtlId.MinimumWidth = 6;
            this.dtlId.Name = "dtlId";
            this.dtlId.ReadOnly = true;
            this.dtlId.Width = 125;
            // 
            // dtlRFID
            // 
            this.dtlRFID.HeaderText = "RFID";
            this.dtlRFID.MinimumWidth = 6;
            this.dtlRFID.Name = "dtlRFID";
            this.dtlRFID.ReadOnly = true;
            this.dtlRFID.Width = 125;
            // 
            // dtlParker
            // 
            this.dtlParker.HeaderText = "Parker";
            this.dtlParker.MinimumWidth = 6;
            this.dtlParker.Name = "dtlParker";
            this.dtlParker.ReadOnly = true;
            this.dtlParker.Width = 125;
            // 
            // dtlCompany
            // 
            this.dtlCompany.HeaderText = "Company";
            this.dtlCompany.MinimumWidth = 6;
            this.dtlCompany.Name = "dtlCompany";
            this.dtlCompany.ReadOnly = true;
            this.dtlCompany.Width = 125;
            // 
            // dtlDateIssued
            // 
            this.dtlDateIssued.HeaderText = "Date Issued";
            this.dtlDateIssued.MinimumWidth = 6;
            this.dtlDateIssued.Name = "dtlDateIssued";
            this.dtlDateIssued.ReadOnly = true;
            this.dtlDateIssued.Width = 125;
            // 
            // dtlValidFrom
            // 
            this.dtlValidFrom.HeaderText = "Valid From";
            this.dtlValidFrom.MinimumWidth = 6;
            this.dtlValidFrom.Name = "dtlValidFrom";
            this.dtlValidFrom.ReadOnly = true;
            this.dtlValidFrom.Width = 125;
            // 
            // dtlValidTo
            // 
            this.dtlValidTo.HeaderText = "Valid Until";
            this.dtlValidTo.MinimumWidth = 6;
            this.dtlValidTo.Name = "dtlValidTo";
            this.dtlValidTo.ReadOnly = true;
            this.dtlValidTo.Width = 125;
            // 
            // dtlStatus
            // 
            this.dtlStatus.HeaderText = "Status";
            this.dtlStatus.MinimumWidth = 6;
            this.dtlStatus.Name = "dtlStatus";
            this.dtlStatus.ReadOnly = true;
            this.dtlStatus.Width = 125;
            // 
            // RegularParkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegularParkers";
            this.Text = "Regular Parkers Report";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
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
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlParker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDateIssued;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlValidFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlValidTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlStatus;
    }
}