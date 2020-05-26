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
            this.dgRemainingCars = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRFIDName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRFIDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlParkerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemainingCars)).BeginInit();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(903, 27);
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
            // dgRemainingCars
            // 
            this.dgRemainingCars.AllowUserToAddRows = false;
            this.dgRemainingCars.AllowUserToDeleteRows = false;
            this.dgRemainingCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgRemainingCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemainingCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlNo,
            this.dtlTimeIn,
            this.dtlPlateNo,
            this.dtlTicketNo,
            this.dtlRFIDName,
            this.dtlRFIDNo,
            this.dtlParkerType});
            this.dgRemainingCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRemainingCars.Location = new System.Drawing.Point(0, 0);
            this.dgRemainingCars.Name = "dgRemainingCars";
            this.dgRemainingCars.ReadOnly = true;
            this.dgRemainingCars.RowHeadersWidth = 51;
            this.dgRemainingCars.RowTemplate.Height = 24;
            this.dgRemainingCars.Size = new System.Drawing.Size(903, 415);
            this.dgRemainingCars.TabIndex = 0;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgRemainingCars);
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
            // dtlNo
            // 
            this.dtlNo.HeaderText = "No";
            this.dtlNo.MinimumWidth = 6;
            this.dtlNo.Name = "dtlNo";
            this.dtlNo.ReadOnly = true;
            this.dtlNo.Width = 125;
            // 
            // dtlTimeIn
            // 
            this.dtlTimeIn.HeaderText = "Time In";
            this.dtlTimeIn.MinimumWidth = 6;
            this.dtlTimeIn.Name = "dtlTimeIn";
            this.dtlTimeIn.ReadOnly = true;
            this.dtlTimeIn.Width = 125;
            // 
            // dtlPlateNo
            // 
            this.dtlPlateNo.HeaderText = "Plate No";
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
            // dtlRFIDName
            // 
            this.dtlRFIDName.HeaderText = "RFID Name";
            this.dtlRFIDName.MinimumWidth = 6;
            this.dtlRFIDName.Name = "dtlRFIDName";
            this.dtlRFIDName.ReadOnly = true;
            this.dtlRFIDName.Width = 125;
            // 
            // dtlRFIDNo
            // 
            this.dtlRFIDNo.HeaderText = "RFID No";
            this.dtlRFIDNo.MinimumWidth = 6;
            this.dtlRFIDNo.Name = "dtlRFIDNo";
            this.dtlRFIDNo.ReadOnly = true;
            this.dtlRFIDNo.Width = 125;
            // 
            // dtlParkerType
            // 
            this.dtlParkerType.HeaderText = "Parker Type";
            this.dtlParkerType.MinimumWidth = 6;
            this.dtlParkerType.Name = "dtlParkerType";
            this.dtlParkerType.ReadOnly = true;
            this.dtlParkerType.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgRemainingCars)).EndInit();
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
        private System.Windows.Forms.DataGridView dgRemainingCars;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRFIDName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRFIDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlParkerType;
    }
}