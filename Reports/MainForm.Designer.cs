namespace Reports
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailedTransactionSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountabilityReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditPerCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierAccountabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourlyAccountabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationHourlyAccountabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthOfStayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationOccupancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peakLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remainingCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingAnalyticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionReportsToolStripMenuItem,
            this.accountabilityReportsToolStripMenuItem,
            this.statisticsReportsToolStripMenuItem,
            this.periodicReportsToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1259, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // transactionReportsToolStripMenuItem
            // 
            this.transactionReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.shiftToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.detailedTransactionSummaryToolStripMenuItem});
            this.transactionReportsToolStripMenuItem.Name = "transactionReportsToolStripMenuItem";
            this.transactionReportsToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.transactionReportsToolStripMenuItem.Text = "Transaction Reports";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click_1);
            // 
            // shiftToolStripMenuItem
            // 
            this.shiftToolStripMenuItem.Name = "shiftToolStripMenuItem";
            this.shiftToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.shiftToolStripMenuItem.Text = "Shift";
            this.shiftToolStripMenuItem.Click += new System.EventHandler(this.shiftToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // detailedTransactionSummaryToolStripMenuItem
            // 
            this.detailedTransactionSummaryToolStripMenuItem.Name = "detailedTransactionSummaryToolStripMenuItem";
            this.detailedTransactionSummaryToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.detailedTransactionSummaryToolStripMenuItem.Text = "Detailed Transaction Summary";
            this.detailedTransactionSummaryToolStripMenuItem.Click += new System.EventHandler(this.detailedTransactionSummaryToolStripMenuItem_Click);
            // 
            // accountabilityReportsToolStripMenuItem
            // 
            this.accountabilityReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditPerCashierToolStripMenuItem,
            this.cashierAccountabilityToolStripMenuItem,
            this.hourlyAccountabilityToolStripMenuItem,
            this.operationHourlyAccountabilityToolStripMenuItem});
            this.accountabilityReportsToolStripMenuItem.Name = "accountabilityReportsToolStripMenuItem";
            this.accountabilityReportsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.accountabilityReportsToolStripMenuItem.Text = "Accountability Reports";
            // 
            // auditPerCashierToolStripMenuItem
            // 
            this.auditPerCashierToolStripMenuItem.Name = "auditPerCashierToolStripMenuItem";
            this.auditPerCashierToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.auditPerCashierToolStripMenuItem.Text = "Audit Per Cashier";
            // 
            // cashierAccountabilityToolStripMenuItem
            // 
            this.cashierAccountabilityToolStripMenuItem.Name = "cashierAccountabilityToolStripMenuItem";
            this.cashierAccountabilityToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.cashierAccountabilityToolStripMenuItem.Text = "Cashier Accountability";
            // 
            // hourlyAccountabilityToolStripMenuItem
            // 
            this.hourlyAccountabilityToolStripMenuItem.Name = "hourlyAccountabilityToolStripMenuItem";
            this.hourlyAccountabilityToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.hourlyAccountabilityToolStripMenuItem.Text = "Hourly Accountability";
            // 
            // operationHourlyAccountabilityToolStripMenuItem
            // 
            this.operationHourlyAccountabilityToolStripMenuItem.Name = "operationHourlyAccountabilityToolStripMenuItem";
            this.operationHourlyAccountabilityToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.operationHourlyAccountabilityToolStripMenuItem.Text = "Operation Hourly Accountability";
            // 
            // statisticsReportsToolStripMenuItem
            // 
            this.statisticsReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthOfStayToolStripMenuItem,
            this.operationOccupancyToolStripMenuItem,
            this.peakLoadToolStripMenuItem,
            this.remainingCarsToolStripMenuItem});
            this.statisticsReportsToolStripMenuItem.Name = "statisticsReportsToolStripMenuItem";
            this.statisticsReportsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.statisticsReportsToolStripMenuItem.Text = "Statistics Reports";
            // 
            // lengthOfStayToolStripMenuItem
            // 
            this.lengthOfStayToolStripMenuItem.Name = "lengthOfStayToolStripMenuItem";
            this.lengthOfStayToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.lengthOfStayToolStripMenuItem.Text = "Length Of Stay";
            this.lengthOfStayToolStripMenuItem.Click += new System.EventHandler(this.lengthOfStayToolStripMenuItem_Click);
            // 
            // operationOccupancyToolStripMenuItem
            // 
            this.operationOccupancyToolStripMenuItem.Name = "operationOccupancyToolStripMenuItem";
            this.operationOccupancyToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.operationOccupancyToolStripMenuItem.Text = "Operation Occupancy";
            this.operationOccupancyToolStripMenuItem.Click += new System.EventHandler(this.operationOccupancyToolStripMenuItem_Click);
            // 
            // peakLoadToolStripMenuItem
            // 
            this.peakLoadToolStripMenuItem.Name = "peakLoadToolStripMenuItem";
            this.peakLoadToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.peakLoadToolStripMenuItem.Text = "Peak Load";
            this.peakLoadToolStripMenuItem.Click += new System.EventHandler(this.peakLoadToolStripMenuItem_Click);
            // 
            // remainingCarsToolStripMenuItem
            // 
            this.remainingCarsToolStripMenuItem.Name = "remainingCarsToolStripMenuItem";
            this.remainingCarsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.remainingCarsToolStripMenuItem.Text = "Remaining Cars";
            this.remainingCarsToolStripMenuItem.Click += new System.EventHandler(this.remainingCarsToolStripMenuItem_Click);
            // 
            // periodicReportsToolStripMenuItem
            // 
            this.periodicReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zReadingToolStripMenuItem,
            this.bIRToolStripMenuItem});
            this.periodicReportsToolStripMenuItem.Name = "periodicReportsToolStripMenuItem";
            this.periodicReportsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.periodicReportsToolStripMenuItem.Text = "Periodic Reports";
            // 
            // zReadingToolStripMenuItem
            // 
            this.zReadingToolStripMenuItem.Name = "zReadingToolStripMenuItem";
            this.zReadingToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.zReadingToolStripMenuItem.Text = "Z Reading";
            this.zReadingToolStripMenuItem.Click += new System.EventHandler(this.zReadingToolStripMenuItem_Click);
            // 
            // bIRToolStripMenuItem
            // 
            this.bIRToolStripMenuItem.Name = "bIRToolStripMenuItem";
            this.bIRToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.bIRToolStripMenuItem.Text = "BIR";
            this.bIRToolStripMenuItem.Click += new System.EventHandler(this.bIRToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parkingAnalyticsToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // parkingAnalyticsToolStripMenuItem
            // 
            this.parkingAnalyticsToolStripMenuItem.Name = "parkingAnalyticsToolStripMenuItem";
            this.parkingAnalyticsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.parkingAnalyticsToolStripMenuItem.Text = "Parking Analytics";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(84, 24);
            this.windowsMenu.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 685);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1259, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 20);
            this.toolStripStatusLabel.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 711);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem transactionReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountabilityReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailedTransactionSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditPerCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierAccountabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourlyAccountabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationHourlyAccountabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthOfStayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationOccupancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peakLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remainingCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingAnalyticsToolStripMenuItem;
    }
}



