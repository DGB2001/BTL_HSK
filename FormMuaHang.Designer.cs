
namespace BTL_HSK
{
    partial class FormMuaHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNgayGiaoHang = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayDatHang = new System.Windows.Forms.MaskedTextBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemChiTietDatHang = new System.Windows.Forms.Button();
            this.btnThemDonDatHang = new System.Windows.Forms.Button();
            this.btnXemChiTietDatHang = new System.Windows.Forms.Button();
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.cbMaDDH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDatHang = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1420, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mua hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNgayGiaoHang);
            this.groupBox3.Controls.Add(this.txtNgayDatHang);
            this.groupBox3.Controls.Add(this.cbMaKH);
            this.groupBox3.Controls.Add(this.cbMaNV);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(50, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 300);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn đặt hàng";
            // 
            // txtNgayGiaoHang
            // 
            this.txtNgayGiaoHang.Location = new System.Drawing.Point(524, 87);
            this.txtNgayGiaoHang.Mask = "00/00/0000";
            this.txtNgayGiaoHang.Name = "txtNgayGiaoHang";
            this.txtNgayGiaoHang.Size = new System.Drawing.Size(161, 26);
            this.txtNgayGiaoHang.TabIndex = 4;
            this.txtNgayGiaoHang.ValidatingType = typeof(System.DateTime);
            // 
            // txtNgayDatHang
            // 
            this.txtNgayDatHang.Location = new System.Drawing.Point(524, 30);
            this.txtNgayDatHang.Mask = "00/00/0000";
            this.txtNgayDatHang.Name = "txtNgayDatHang";
            this.txtNgayDatHang.Size = new System.Drawing.Size(161, 26);
            this.txtNgayDatHang.TabIndex = 4;
            this.txtNgayDatHang.ValidatingType = typeof(System.DateTime);
            // 
            // cbMaKH
            // 
            this.cbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(155, 147);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(161, 28);
            this.cbMaKH.TabIndex = 3;
            // 
            // cbMaNV
            // 
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(152, 87);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(164, 28);
            this.cbMaNV.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(152, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(164, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày giao hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTinhTien);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThemChiTietDatHang);
            this.groupBox4.Controls.Add(this.btnThemDonDatHang);
            this.groupBox4.Location = new System.Drawing.Point(1085, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 300);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(15, 150);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(110, 41);
            this.btnTinhTien.TabIndex = 1;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(137, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemChiTietDatHang
            // 
            this.btnThemChiTietDatHang.Location = new System.Drawing.Point(15, 91);
            this.btnThemChiTietDatHang.Name = "btnThemChiTietDatHang";
            this.btnThemChiTietDatHang.Size = new System.Drawing.Size(148, 40);
            this.btnThemChiTietDatHang.TabIndex = 0;
            this.btnThemChiTietDatHang.Text = "Thêm sản phẩm";
            this.btnThemChiTietDatHang.UseVisualStyleBackColor = true;
            this.btnThemChiTietDatHang.Click += new System.EventHandler(this.btnThemChiTietDatHang_Click);
            // 
            // btnThemDonDatHang
            // 
            this.btnThemDonDatHang.Location = new System.Drawing.Point(15, 33);
            this.btnThemDonDatHang.Name = "btnThemDonDatHang";
            this.btnThemDonDatHang.Size = new System.Drawing.Size(148, 40);
            this.btnThemDonDatHang.TabIndex = 0;
            this.btnThemDonDatHang.Text = "Thêm đơn hàng";
            this.btnThemDonDatHang.UseVisualStyleBackColor = true;
            this.btnThemDonDatHang.Click += new System.EventHandler(this.btnThemDonDatHang_Click);
            // 
            // btnXemChiTietDatHang
            // 
            this.btnXemChiTietDatHang.Location = new System.Drawing.Point(55, 219);
            this.btnXemChiTietDatHang.Name = "btnXemChiTietDatHang";
            this.btnXemChiTietDatHang.Size = new System.Drawing.Size(181, 40);
            this.btnXemChiTietDatHang.TabIndex = 0;
            this.btnXemChiTietDatHang.Text = "Xem chi tiết đặt hàng";
            this.btnXemChiTietDatHang.UseVisualStyleBackColor = true;
            this.btnXemChiTietDatHang.Click += new System.EventHandler(this.btnXemChiTietDatHang_Click);
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuongMua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnXemChiTietDatHang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMaHang);
            this.groupBox1.Controls.Add(this.cbMaDDH);
            this.groupBox1.Location = new System.Drawing.Point(786, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết đặt hàng";
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(130, 147);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(120, 26);
            this.txtSoLuongMua.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã hóa đơn";
            // 
            // cbMaHang
            // 
            this.cbMaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHang.FormattingEnabled = true;
            this.cbMaHang.Location = new System.Drawing.Point(130, 84);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(141, 28);
            this.cbMaHang.TabIndex = 2;
            // 
            // cbMaDDH
            // 
            this.cbMaDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaDDH.FormattingEnabled = true;
            this.cbMaDDH.Location = new System.Drawing.Point(130, 33);
            this.cbMaDDH.Name = "cbMaDDH";
            this.cbMaDDH.Size = new System.Drawing.Size(141, 28);
            this.cbMaDDH.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietDatHang);
            this.groupBox2.Location = new System.Drawing.Point(50, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1320, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết đơn hàng";
            // 
            // dgvChiTietDatHang
            // 
            this.dgvChiTietDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDatHang.Location = new System.Drawing.Point(10, 25);
            this.dgvChiTietDatHang.Name = "dgvChiTietDatHang";
            this.dgvChiTietDatHang.RowHeadersWidth = 62;
            this.dgvChiTietDatHang.RowTemplate.Height = 28;
            this.dgvChiTietDatHang.Size = new System.Drawing.Size(1304, 281);
            this.dgvChiTietDatHang.TabIndex = 0;
            // 
            // FormMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMuaHang";
            this.Text = "FormMuaHang";
            this.Load += new System.EventHandler(this.FormMuaHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNgayGiaoHang;
        private System.Windows.Forms.MaskedTextBox txtNgayDatHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThemDonDatHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorCheck;
        private System.Windows.Forms.Button btnThemChiTietDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMaDDH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtSoLuongMua;
        private System.Windows.Forms.DataGridView dgvChiTietDatHang;
        private System.Windows.Forms.Button btnXemChiTietDatHang;
        private System.Windows.Forms.Button btnTinhTien;
    }
}