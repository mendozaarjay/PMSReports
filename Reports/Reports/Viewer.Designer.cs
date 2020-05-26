namespace Reports.Reports
{
    partial class Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.mReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // mReportViewer
            // 
            this.mReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mReportViewer.Location = new System.Drawing.Point(0, 0);
            this.mReportViewer.Name = "mReportViewer";
            this.mReportViewer.ServerReport.BearerToken = null;
            this.mReportViewer.Size = new System.Drawing.Size(623, 346);
            this.mReportViewer.TabIndex = 0;
            // 
            // Viewer
            // 
            this.ClientSize = new System.Drawing.Size(623, 346);
            this.Controls.Add(this.mReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Viewer";
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer mReportViewer;
    }
}