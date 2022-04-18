
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtNguoibaocao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTieude = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rptNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.txtNguoibaocao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTieude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1420, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(980, 52);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(106, 32);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Xác nhận";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtNguoibaocao
            // 
            this.txtNguoibaocao.Location = new System.Drawing.Point(699, 52);
            this.txtNguoibaocao.Name = "txtNguoibaocao";
            this.txtNguoibaocao.Size = new System.Drawing.Size(217, 26);
            this.txtNguoibaocao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người lập báo cáo";
            // 
            // cbTieude
            // 
            this.cbTieude.FormattingEnabled = true;
            this.cbTieude.Location = new System.Drawing.Point(143, 51);
            this.cbTieude.Name = "cbTieude";
            this.cbTieude.Size = new System.Drawing.Size(335, 28);
            this.cbTieude.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn báo cáo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rptNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1420, 580);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo";
            // 
            // rptNhanVien
            // 
            this.rptNhanVien.ActiveViewIndex = -1;
            this.rptNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNhanVien.Location = new System.Drawing.Point(3, 22);
            this.rptNhanVien.Name = "rptNhanVien";
            this.rptNhanVien.Size = new System.Drawing.Size(1414, 555);
            this.rptNhanVien.TabIndex = 0;
            // 
            // FormReportNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportNhanVien";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReportNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtNguoibaocao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTieude;
    }
}