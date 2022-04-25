
namespace BTL_HSK
{
    partial class FormDonDatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.iSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTienHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDatHang = new System.Windows.Forms.DataGridView();
            this.sMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGiaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMucGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNgayGiaoHang = new System.Windows.Forms.MaskedTextBox();
            this.txtNgayDatHang = new System.Windows.Forms.MaskedTextBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnCapNhatChiTiet = new System.Windows.Forms.Button();
            this.toolTipCapNhat = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipXoa = new System.Windows.Forms.ToolTip(this.components);
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1420, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý đơn đặt hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDonDatHang);
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn đặt hàng";
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSoHD,
            this.iMaNV,
            this.iMaKH,
            this.dNgayDatHang,
            this.dNgayGiaoHang,
            this.fTongTienHD});
            this.dgvDonDatHang.Location = new System.Drawing.Point(5, 20);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.RowHeadersWidth = 62;
            this.dgvDonDatHang.RowTemplate.Height = 28;
            this.dgvDonDatHang.Size = new System.Drawing.Size(990, 250);
            this.dgvDonDatHang.TabIndex = 0;
            this.dgvDonDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDatHang_CellClick);
            // 
            // iSoHD
            // 
            this.iSoHD.DataPropertyName = "iSoHD";
            this.iSoHD.HeaderText = "Mã HĐ";
            this.iSoHD.MinimumWidth = 8;
            this.iSoHD.Name = "iSoHD";
            this.iSoHD.ReadOnly = true;
            // 
            // iMaNV
            // 
            this.iMaNV.DataPropertyName = "iMaNV";
            this.iMaNV.HeaderText = "Mã NV";
            this.iMaNV.MinimumWidth = 8;
            this.iMaNV.Name = "iMaNV";
            this.iMaNV.ReadOnly = true;
            // 
            // iMaKH
            // 
            this.iMaKH.DataPropertyName = "iMaKH";
            this.iMaKH.HeaderText = "Mã KH";
            this.iMaKH.MinimumWidth = 8;
            this.iMaKH.Name = "iMaKH";
            this.iMaKH.ReadOnly = true;
            // 
            // dNgayDatHang
            // 
            this.dNgayDatHang.DataPropertyName = "dNgayDatHang";
            this.dNgayDatHang.HeaderText = "Ngày đặt hàng";
            this.dNgayDatHang.MinimumWidth = 8;
            this.dNgayDatHang.Name = "dNgayDatHang";
            this.dNgayDatHang.ReadOnly = true;
            // 
            // dNgayGiaoHang
            // 
            this.dNgayGiaoHang.DataPropertyName = "dNgayGiaoHang";
            this.dNgayGiaoHang.HeaderText = "Ngày giao hàng";
            this.dNgayGiaoHang.MinimumWidth = 8;
            this.dNgayGiaoHang.Name = "dNgayGiaoHang";
            this.dNgayGiaoHang.ReadOnly = true;
            // 
            // fTongTienHD
            // 
            this.fTongTienHD.DataPropertyName = "fTongTienHD";
            this.fTongTienHD.HeaderText = "Tổng tiền";
            this.fTongTienHD.MinimumWidth = 8;
            this.fTongTienHD.Name = "fTongTienHD";
            this.fTongTienHD.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietDatHang);
            this.groupBox2.Location = new System.Drawing.Point(10, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn đặt hàng";
            // 
            // dgvChiTietDatHang
            // 
            this.dgvChiTietDatHang.AllowUserToAddRows = false;
            this.dgvChiTietDatHang.AllowUserToDeleteRows = false;
            this.dgvChiTietDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHang,
            this.sTenHang,
            this.fGiaHang,
            this.iSoLuongMua,
            this.fMucGiamGia});
            this.dgvChiTietDatHang.Location = new System.Drawing.Point(5, 20);
            this.dgvChiTietDatHang.Name = "dgvChiTietDatHang";
            this.dgvChiTietDatHang.ReadOnly = true;
            this.dgvChiTietDatHang.RowHeadersWidth = 62;
            this.dgvChiTietDatHang.RowTemplate.Height = 28;
            this.dgvChiTietDatHang.Size = new System.Drawing.Size(990, 280);
            this.dgvChiTietDatHang.TabIndex = 0;
            // 
            // sMaHang
            // 
            this.sMaHang.DataPropertyName = "sMaHang";
            this.sMaHang.HeaderText = "Mã sản phẩm";
            this.sMaHang.MinimumWidth = 8;
            this.sMaHang.Name = "sMaHang";
            this.sMaHang.ReadOnly = true;
            // 
            // sTenHang
            // 
            this.sTenHang.DataPropertyName = "sTenHang";
            this.sTenHang.HeaderText = "Tên sản phẩm";
            this.sTenHang.MinimumWidth = 8;
            this.sTenHang.Name = "sTenHang";
            this.sTenHang.ReadOnly = true;
            // 
            // fGiaHang
            // 
            this.fGiaHang.DataPropertyName = "fGiaHang";
            this.fGiaHang.HeaderText = "Giá bán";
            this.fGiaHang.MinimumWidth = 8;
            this.fGiaHang.Name = "fGiaHang";
            this.fGiaHang.ReadOnly = true;
            // 
            // iSoLuongMua
            // 
            this.iSoLuongMua.DataPropertyName = "iSoLuongMua";
            this.iSoLuongMua.HeaderText = "Số lượng mua";
            this.iSoLuongMua.MinimumWidth = 8;
            this.iSoLuongMua.Name = "iSoLuongMua";
            this.iSoLuongMua.ReadOnly = true;
            // 
            // fMucGiamGia
            // 
            this.fMucGiamGia.DataPropertyName = "fMucGiamGia";
            this.fMucGiamGia.HeaderText = "Mức giảm giá";
            this.fMucGiamGia.MinimumWidth = 8;
            this.fMucGiamGia.Name = "fMucGiamGia";
            this.fMucGiamGia.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNgayGiaoHang);
            this.groupBox3.Controls.Add(this.txtNgayDatHang);
            this.groupBox3.Controls.Add(this.cbMaKH);
            this.groupBox3.Controls.Add(this.cbMaNV);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1040, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 370);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn đặt hàng";
            // 
            // txtNgayGiaoHang
            // 
            this.txtNgayGiaoHang.Location = new System.Drawing.Point(155, 267);
            this.txtNgayGiaoHang.Mask = "00/00/0000";
            this.txtNgayGiaoHang.Name = "txtNgayGiaoHang";
            this.txtNgayGiaoHang.Size = new System.Drawing.Size(161, 26);
            this.txtNgayGiaoHang.TabIndex = 4;
            this.txtNgayGiaoHang.ValidatingType = typeof(System.DateTime);
            // 
            // txtNgayDatHang
            // 
            this.txtNgayDatHang.Location = new System.Drawing.Point(155, 207);
            this.txtNgayDatHang.Mask = "00/00/0000";
            this.txtNgayDatHang.Name = "txtNgayDatHang";
            this.txtNgayDatHang.Size = new System.Drawing.Size(161, 26);
            this.txtNgayDatHang.TabIndex = 4;
            this.txtNgayDatHang.ValidatingType = typeof(System.DateTime);
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(155, 147);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(161, 28);
            this.cbMaKH.TabIndex = 3;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(152, 87);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(164, 28);
            this.cbMaNV.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(155, 327);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
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
            this.label6.Location = new System.Drawing.Point(30, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày giao hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày đặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng tiền";
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
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnTimkiem);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnThoat);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Location = new System.Drawing.Point(1040, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 265);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(219, 110);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(40, 180);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 40);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(40, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(216, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(40, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSoLuongMua);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnXoaChiTiet);
            this.groupBox5.Controls.Add(this.btnCapNhatChiTiet);
            this.groupBox5.Location = new System.Drawing.Point(10, 626);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1000, 65);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cập nhật chi tiết đặt hàng";
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(454, 27);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(116, 26);
            this.txtSoLuongMua.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng mua";
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Location = new System.Drawing.Point(819, 20);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(100, 40);
            this.btnXoaChiTiet.TabIndex = 0;
            this.btnXoaChiTiet.Text = "Xóa";
            this.toolTipXoa.SetToolTip(this.btnXoaChiTiet, "Xóa sản phẩm khỏi danh sách đặt hàng");
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatChiTiet
            // 
            this.btnCapNhatChiTiet.Location = new System.Drawing.Point(686, 20);
            this.btnCapNhatChiTiet.Name = "btnCapNhatChiTiet";
            this.btnCapNhatChiTiet.Size = new System.Drawing.Size(100, 40);
            this.btnCapNhatChiTiet.TabIndex = 0;
            this.btnCapNhatChiTiet.Text = "Cập nhật";
            this.toolTipCapNhat.SetToolTip(this.btnCapNhatChiTiet, "Cập nhật số lượng mua");
            this.btnCapNhatChiTiet.UseVisualStyleBackColor = true;
            // 
            // toolTipCapNhat
            // 
            this.toolTipCapNhat.IsBalloon = true;
            this.toolTipCapNhat.ShowAlways = true;
            this.toolTipCapNhat.ToolTipTitle = "Lưu ý";
            // 
            // toolTipXoa
            // 
            this.toolTipXoa.IsBalloon = true;
            this.toolTipXoa.ShowAlways = true;
            this.toolTipXoa.ToolTipTitle = "Lưu ý";
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonDatHang";
            this.Text = "FormDonDatHang";
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDatHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.DataGridView dgvChiTietDatHang;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayGiaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTienHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGiaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMucGiamGia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button btnCapNhatChiTiet;
        private System.Windows.Forms.ToolTip toolTipCapNhat;
        private System.Windows.Forms.ToolTip toolTipXoa;
        private System.Windows.Forms.ErrorProvider errorCheck;
    }
}