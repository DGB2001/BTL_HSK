
namespace BTL_HSK
{
    partial class FormReportNhanVien
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
            this.rptNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptNhanVien
            // 
            this.rptNhanVien.ActiveViewIndex = -1;
            this.rptNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNhanVien.Location = new System.Drawing.Point(0, 0);
            this.rptNhanVien.Name = "rptNhanVien";
            this.rptNhanVien.Size = new System.Drawing.Size(1420, 700);
            this.rptNhanVien.TabIndex = 0;
            this.rptNhanVien.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FormReportNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.rptNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportNhanVien";
            this.Text = "FormReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptNhanVien;
    }
}