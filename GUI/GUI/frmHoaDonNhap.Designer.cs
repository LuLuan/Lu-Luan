namespace GUI
{
    partial class frmHoaDonNhap
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
            this.rptHoaDonNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptHoaDonNhap
            // 
            this.rptHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptHoaDonNhap.Location = new System.Drawing.Point(0, 0);
            this.rptHoaDonNhap.Name = "rptHoaDonNhap";
            this.rptHoaDonNhap.Size = new System.Drawing.Size(601, 517);
            this.rptHoaDonNhap.TabIndex = 0;
            this.rptHoaDonNhap.Load += new System.EventHandler(this.rptHoaDonNhap_Load);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 517);
            this.Controls.Add(this.rptHoaDonNhap);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDonNhap;
    }
}