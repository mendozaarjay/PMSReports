namespace Reports
{
    partial class AuditTrail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditTrail));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTerminal = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.dtlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlGate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.bindingNavigator1.Size = new System.Drawing.Size(900, 31);
            this.bindingNavigator1.TabIndex = 10;
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
            this.btnCsv.Size = new System.Drawing.Size(59, 28);
            this.btnCsv.Text = "&CSV";
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 28);
            this.btnExcel.Text = "&Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(63, 28);
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(61, 28);
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
            this.splitContainer1.Panel2.Controls.Add(this.dgDetails);
            this.splitContainer1.Size = new System.Drawing.Size(900, 647);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeTo);
            this.groupBox1.Controls.Add(this.timeFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTerminal);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // timeTo
            // 
            this.timeTo.CustomFormat = "hh:mm:ss tt";
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo.Location = new System.Drawing.Point(314, 81);
            this.timeTo.Name = "timeTo";
            this.timeTo.ShowUpDown = true;
            this.timeTo.Size = new System.Drawing.Size(127, 30);
            this.timeTo.TabIndex = 3;
            // 
            // timeFrom
            // 
            this.timeFrom.CustomFormat = "hh:mm:ss tt";
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom.Location = new System.Drawing.Point(314, 42);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.ShowUpDown = true;
            this.timeFrom.Size = new System.Drawing.Size(127, 30);
            this.timeFrom.TabIndex = 1;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MM/dd/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(135, 81);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(171, 30);
            this.dtTo.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MM/dd/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(135, 42);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(171, 30);
            this.dtFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Terminal";
            // 
            // cbTerminal
            // 
            this.cbTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerminal.FormattingEnabled = true;
            this.cbTerminal.Location = new System.Drawing.Point(135, 118);
            this.cbTerminal.Name = "cbTerminal";
            this.cbTerminal.Size = new System.Drawing.Size(306, 31);
            this.cbTerminal.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(135, 190);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(306, 32);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Keyword";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(135, 154);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(306, 30);
            this.txtKeyword.TabIndex = 5;
            // 
            // dgDetails
            // 
            this.dgDetails.AllowUserToAddRows = false;
            this.dgDetails.AllowUserToDeleteRows = false;
            this.dgDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlId,
            this.dtlDescription,
            this.dtlGate,
            this.dtlUsername,
            this.dtlDate});
            this.dgDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetails.Location = new System.Drawing.Point(0, 0);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.RowHeadersWidth = 51;
            this.dgDetails.RowTemplate.Height = 24;
            this.dgDetails.Size = new System.Drawing.Size(900, 392);
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
            // dtlDescription
            // 
            this.dtlDescription.HeaderText = "Description";
            this.dtlDescription.MinimumWidth = 6;
            this.dtlDescription.Name = "dtlDescription";
            this.dtlDescription.ReadOnly = true;
            this.dtlDescription.Width = 125;
            // 
            // dtlGate
            // 
            this.dtlGate.HeaderText = "Gate";
            this.dtlGate.MinimumWidth = 6;
            this.dtlGate.Name = "dtlGate";
            this.dtlGate.ReadOnly = true;
            this.dtlGate.Width = 125;
            // 
            // dtlUsername
            // 
            this.dtlUsername.HeaderText = "Username";
            this.dtlUsername.MinimumWidth = 6;
            this.dtlUsername.Name = "dtlUsername";
            this.dtlUsername.ReadOnly = true;
            this.dtlUsername.Width = 125;
            // 
            // dtlDate
            // 
            this.dtlDate.HeaderText = "Date";
            this.dtlDate.MinimumWidth = 6;
            this.dtlDate.Name = "dtlDate";
            this.dtlDate.ReadOnly = true;
            this.dtlDate.Width = 125;
            // 
            // AuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuditTrail";
            this.Text = "Audit Trail Report";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker timeTo;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTerminal;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlGate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDate;
    }
}