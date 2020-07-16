namespace Reports
{
    partial class UserAccessMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccessMatrix));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtlRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCanAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanSearch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtlCanAccess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cboUser);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(135, 53);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(306, 31);
            this.cboUser.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
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
            this.bindingNavigator1.Size = new System.Drawing.Size(929, 27);
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
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlRow,
            this.dtlUsername,
            this.dtlRole,
            this.dtlModule,
            this.dtlType,
            this.dtlCanAdd,
            this.dtlCanEdit,
            this.dtlCanSave,
            this.dtlCanDelete,
            this.dtlCanSearch,
            this.dtlCanPrint,
            this.dtlCanExport,
            this.dtlCanAccess});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(0, 0);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.RowHeadersWidth = 51;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(929, 377);
            this.dgItems.TabIndex = 0;
            this.dgItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgItems_DataError);
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
            this.splitContainer1.Panel2.Controls.Add(this.dgItems);
            this.splitContainer1.Size = new System.Drawing.Size(929, 552);
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
            // dtlUsername
            // 
            this.dtlUsername.HeaderText = "User";
            this.dtlUsername.MinimumWidth = 6;
            this.dtlUsername.Name = "dtlUsername";
            this.dtlUsername.ReadOnly = true;
            this.dtlUsername.Width = 125;
            // 
            // dtlRole
            // 
            this.dtlRole.HeaderText = "Role";
            this.dtlRole.MinimumWidth = 6;
            this.dtlRole.Name = "dtlRole";
            this.dtlRole.ReadOnly = true;
            this.dtlRole.Width = 150;
            // 
            // dtlModule
            // 
            this.dtlModule.HeaderText = "Module";
            this.dtlModule.MinimumWidth = 6;
            this.dtlModule.Name = "dtlModule";
            this.dtlModule.ReadOnly = true;
            this.dtlModule.Width = 150;
            // 
            // dtlType
            // 
            this.dtlType.HeaderText = "Type";
            this.dtlType.MinimumWidth = 6;
            this.dtlType.Name = "dtlType";
            this.dtlType.ReadOnly = true;
            this.dtlType.Width = 150;
            // 
            // dtlCanAdd
            // 
            this.dtlCanAdd.FalseValue = "0";
            this.dtlCanAdd.HeaderText = "CanAdd";
            this.dtlCanAdd.MinimumWidth = 6;
            this.dtlCanAdd.Name = "dtlCanAdd";
            this.dtlCanAdd.ReadOnly = true;
            this.dtlCanAdd.TrueValue = "1";
            this.dtlCanAdd.Width = 125;
            // 
            // dtlCanEdit
            // 
            this.dtlCanEdit.FalseValue = "0";
            this.dtlCanEdit.HeaderText = "Can Edit";
            this.dtlCanEdit.MinimumWidth = 6;
            this.dtlCanEdit.Name = "dtlCanEdit";
            this.dtlCanEdit.ReadOnly = true;
            this.dtlCanEdit.TrueValue = "1";
            this.dtlCanEdit.Width = 125;
            // 
            // dtlCanSave
            // 
            this.dtlCanSave.FalseValue = "0";
            this.dtlCanSave.HeaderText = "Can Save";
            this.dtlCanSave.MinimumWidth = 6;
            this.dtlCanSave.Name = "dtlCanSave";
            this.dtlCanSave.ReadOnly = true;
            this.dtlCanSave.TrueValue = "1";
            this.dtlCanSave.Width = 125;
            // 
            // dtlCanDelete
            // 
            this.dtlCanDelete.FalseValue = "0";
            this.dtlCanDelete.HeaderText = "Can Delete";
            this.dtlCanDelete.MinimumWidth = 6;
            this.dtlCanDelete.Name = "dtlCanDelete";
            this.dtlCanDelete.ReadOnly = true;
            this.dtlCanDelete.TrueValue = "1";
            this.dtlCanDelete.Width = 125;
            // 
            // dtlCanSearch
            // 
            this.dtlCanSearch.FalseValue = "0";
            this.dtlCanSearch.HeaderText = "Can Search";
            this.dtlCanSearch.MinimumWidth = 6;
            this.dtlCanSearch.Name = "dtlCanSearch";
            this.dtlCanSearch.ReadOnly = true;
            this.dtlCanSearch.TrueValue = "1";
            this.dtlCanSearch.Width = 125;
            // 
            // dtlCanPrint
            // 
            this.dtlCanPrint.FalseValue = "0";
            this.dtlCanPrint.HeaderText = "Can Print";
            this.dtlCanPrint.MinimumWidth = 6;
            this.dtlCanPrint.Name = "dtlCanPrint";
            this.dtlCanPrint.ReadOnly = true;
            this.dtlCanPrint.TrueValue = "1";
            this.dtlCanPrint.Width = 125;
            // 
            // dtlCanExport
            // 
            this.dtlCanExport.FalseValue = "0";
            this.dtlCanExport.HeaderText = "Can Export";
            this.dtlCanExport.MinimumWidth = 6;
            this.dtlCanExport.Name = "dtlCanExport";
            this.dtlCanExport.ReadOnly = true;
            this.dtlCanExport.TrueValue = "1";
            this.dtlCanExport.Width = 125;
            // 
            // dtlCanAccess
            // 
            this.dtlCanAccess.FalseValue = "0";
            this.dtlCanAccess.HeaderText = "Can Access";
            this.dtlCanAccess.MinimumWidth = 6;
            this.dtlCanAccess.Name = "dtlCanAccess";
            this.dtlCanAccess.ReadOnly = true;
            this.dtlCanAccess.TrueValue = "1";
            this.dtlCanAccess.Width = 125;
            // 
            // UserAccessMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 579);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserAccessMatrix";
            this.Text = "User Access Matrix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCsv;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanPrint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanExport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtlCanAccess;
    }
}