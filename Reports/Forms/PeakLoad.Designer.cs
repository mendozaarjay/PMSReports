namespace Reports
{
    partial class PeakLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeakLoad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.dgPeakLoad = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtlRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlGrossIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlNetIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlInPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlNetOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOutPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeakLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(745, 155);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(769, 27);
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
            // dgPeakLoad
            // 
            this.dgPeakLoad.AllowUserToAddRows = false;
            this.dgPeakLoad.AllowUserToDeleteRows = false;
            this.dgPeakLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPeakLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeakLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlRow,
            this.dtlDuration,
            this.dtlGrossIn,
            this.dtlCancel,
            this.dtlNetIn,
            this.dtlInPercentage,
            this.dtlNetOut,
            this.dtlOutPercentage,
            this.dtlAmount});
            this.dgPeakLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeakLoad.Location = new System.Drawing.Point(0, 0);
            this.dgPeakLoad.Name = "dgPeakLoad";
            this.dgPeakLoad.ReadOnly = true;
            this.dgPeakLoad.RowHeadersWidth = 51;
            this.dgPeakLoad.RowTemplate.Height = 24;
            this.dgPeakLoad.Size = new System.Drawing.Size(769, 386);
            this.dgPeakLoad.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgPeakLoad);
            this.splitContainer1.Size = new System.Drawing.Size(769, 561);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 7;
            // 
            // dtlRow
            // 
            this.dtlRow.HeaderText = "Row";
            this.dtlRow.MinimumWidth = 6;
            this.dtlRow.Name = "dtlRow";
            this.dtlRow.ReadOnly = true;
            this.dtlRow.Width = 50;
            // 
            // dtlDuration
            // 
            this.dtlDuration.HeaderText = "Time";
            this.dtlDuration.MinimumWidth = 6;
            this.dtlDuration.Name = "dtlDuration";
            this.dtlDuration.ReadOnly = true;
            this.dtlDuration.Width = 125;
            // 
            // dtlGrossIn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dtlGrossIn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtlGrossIn.HeaderText = "Gross In";
            this.dtlGrossIn.MinimumWidth = 6;
            this.dtlGrossIn.Name = "dtlGrossIn";
            this.dtlGrossIn.ReadOnly = true;
            this.dtlGrossIn.Width = 125;
            // 
            // dtlCancel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dtlCancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtlCancel.HeaderText = "Cancelled";
            this.dtlCancel.MinimumWidth = 6;
            this.dtlCancel.Name = "dtlCancel";
            this.dtlCancel.ReadOnly = true;
            this.dtlCancel.Width = 125;
            // 
            // dtlNetIn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dtlNetIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtlNetIn.HeaderText = "Net In";
            this.dtlNetIn.MinimumWidth = 6;
            this.dtlNetIn.Name = "dtlNetIn";
            this.dtlNetIn.ReadOnly = true;
            this.dtlNetIn.Width = 125;
            // 
            // dtlInPercentage
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dtlInPercentage.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtlInPercentage.HeaderText = "In (%)";
            this.dtlInPercentage.MinimumWidth = 6;
            this.dtlInPercentage.Name = "dtlInPercentage";
            this.dtlInPercentage.ReadOnly = true;
            this.dtlInPercentage.Width = 125;
            // 
            // dtlNetOut
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dtlNetOut.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtlNetOut.HeaderText = "Net Out";
            this.dtlNetOut.MinimumWidth = 6;
            this.dtlNetOut.Name = "dtlNetOut";
            this.dtlNetOut.ReadOnly = true;
            this.dtlNetOut.Width = 125;
            // 
            // dtlOutPercentage
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dtlOutPercentage.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtlOutPercentage.HeaderText = "Out (%)";
            this.dtlOutPercentage.MinimumWidth = 6;
            this.dtlOutPercentage.Name = "dtlOutPercentage";
            this.dtlOutPercentage.ReadOnly = true;
            this.dtlOutPercentage.Width = 125;
            // 
            // dtlAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dtlAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtlAmount.HeaderText = "Amount";
            this.dtlAmount.MinimumWidth = 6;
            this.dtlAmount.Name = "dtlAmount";
            this.dtlAmount.ReadOnly = true;
            this.dtlAmount.Width = 125;
            // 
            // PeakLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PeakLoad";
            this.Text = "Peak Load Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeakLoad)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.DataGridView dgPeakLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlGrossIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNetIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlInPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNetOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOutPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlAmount;
    }
}