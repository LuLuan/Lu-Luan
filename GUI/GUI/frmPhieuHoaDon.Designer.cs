namespace GUI
{
    partial class frmPhieuHoaDon
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
            this.rptChiTietHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptChiTietHoaDon
            // 
            this.rptChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.rptChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rptChiTietHoaDon.Name = "rptChiTietHoaDon";
            this.rptChiTietHoaDon.Size = new System.Drawing.Size(413, 499);
            this.rptChiTietHoaDon.TabIndex = 0;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.BackColor = System.Drawing.Color.White;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoanTat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHoanTat.Image = global::GUI.Properties.Resources.icons8_Ok_25px;
            this.btnHoanTat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoanTat.Location = new System.Drawing.Point(0, 498);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(413, 38);
            this.btnHoanTat.TabIndex = 77;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoanTat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoanTat.UseVisualStyleBackColor = false;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // frmPhieuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 536);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.rptChiTietHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPhieuHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuHoaDon";
            this.Load += new System.EventHandler(this.frmPhieuHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptChiTietHoaDon;
        private System.Windows.Forms.Button btnHoanTat;
    }
}