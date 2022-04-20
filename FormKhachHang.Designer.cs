
namespace BTL_HSK
{
    partial class FormKhachHang
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
            this.textBox_sdtKH = new System.Windows.Forms.MaskedTextBox();
            this.textBox_diachiKH = new System.Windows.Forms.TextBox();
            this.textBox_tenKH = new System.Windows.Forms.TextBox();
            this.textBox_maKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_timKH = new System.Windows.Forms.Button();
            this.button_xoaKH = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button_suaKH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button_themKH = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_KH = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KH)).BeginInit();
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
            this.label1.Text = "Quản lý khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_sdtKH);
            this.groupBox1.Controls.Add(this.textBox_diachiKH);
            this.groupBox1.Controls.Add(this.textBox_tenKH);
            this.groupBox1.Controls.Add(this.textBox_maKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(50, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // textBox_sdtKH
            // 
            this.textBox_sdtKH.Location = new System.Drawing.Point(712, 105);
            this.textBox_sdtKH.Mask = "9999999999";
            this.textBox_sdtKH.Name = "textBox_sdtKH";
            this.textBox_sdtKH.Size = new System.Drawing.Size(220, 26);
            this.textBox_sdtKH.TabIndex = 2;
            this.textBox_sdtKH.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_sdtKH_Validating);
            // 
            // textBox_diachiKH
            // 
            this.textBox_diachiKH.Location = new System.Drawing.Point(230, 105);
            this.textBox_diachiKH.Name = "textBox_diachiKH";
            this.textBox_diachiKH.Size = new System.Drawing.Size(220, 26);
            this.textBox_diachiKH.TabIndex = 1;
            this.textBox_diachiKH.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_diachiKH_Validating);
            // 
            // textBox_tenKH
            // 
            this.textBox_tenKH.Location = new System.Drawing.Point(712, 40);
            this.textBox_tenKH.Name = "textBox_tenKH";
            this.textBox_tenKH.Size = new System.Drawing.Size(220, 26);
            this.textBox_tenKH.TabIndex = 1;
            this.textBox_tenKH.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_tenKH_Validating);
            // 
            // textBox_maKH
            // 
            this.textBox_maKH.Location = new System.Drawing.Point(230, 40);
            this.textBox_maKH.Name = "textBox_maKH";
            this.textBox_maKH.Size = new System.Drawing.Size(220, 26);
            this.textBox_maKH.TabIndex = 1;
            this.textBox_maKH.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_maKH_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_timKH);
            this.groupBox2.Controls.Add(this.button_xoaKH);
            this.groupBox2.Controls.Add(this.buttonReset);
            this.groupBox2.Controls.Add(this.button_suaKH);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.button_themKH);
            this.groupBox2.Location = new System.Drawing.Point(1070, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // button_timKH
            // 
            this.button_timKH.Location = new System.Drawing.Point(176, 163);
            this.button_timKH.Name = "button_timKH";
            this.button_timKH.Size = new System.Drawing.Size(100, 40);
            this.button_timKH.TabIndex = 0;
            this.button_timKH.Text = "Tìm kiếm";
            this.button_timKH.UseVisualStyleBackColor = true;
            this.button_timKH.Click += new System.EventHandler(this.button_timKH_Click);
            // 
            // button_xoaKH
            // 
            this.button_xoaKH.Location = new System.Drawing.Point(40, 163);
            this.button_xoaKH.Name = "button_xoaKH";
            this.button_xoaKH.Size = new System.Drawing.Size(100, 40);
            this.button_xoaKH.TabIndex = 0;
            this.button_xoaKH.Text = "Xóa";
            this.button_xoaKH.UseVisualStyleBackColor = true;
            this.button_xoaKH.Click += new System.EventHandler(this.button_xoaKH_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(176, 98);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 40);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button_suaKH
            // 
            this.button_suaKH.Location = new System.Drawing.Point(40, 98);
            this.button_suaKH.Name = "button_suaKH";
            this.button_suaKH.Size = new System.Drawing.Size(100, 40);
            this.button_suaKH.TabIndex = 0;
            this.button_suaKH.Text = "Sửa";
            this.button_suaKH.UseVisualStyleBackColor = true;
            this.button_suaKH.Click += new System.EventHandler(this.button_suaKH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(176, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button_themKH
            // 
            this.button_themKH.Location = new System.Drawing.Point(40, 33);
            this.button_themKH.Name = "button_themKH";
            this.button_themKH.Size = new System.Drawing.Size(100, 40);
            this.button_themKH.TabIndex = 0;
            this.button_themKH.Text = "Thêm";
            this.button_themKH.UseVisualStyleBackColor = true;
            this.button_themKH.Click += new System.EventHandler(this.button_themKH_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_KH);
            this.groupBox3.Location = new System.Drawing.Point(50, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1320, 400);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dataGridView_KH
            // 
            this.dataGridView_KH.AllowUserToAddRows = false;
            this.dataGridView_KH.AllowUserToDeleteRows = false;
            this.dataGridView_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.diachikh,
            this.sdtkh});
            this.dataGridView_KH.Location = new System.Drawing.Point(5, 20);
            this.dataGridView_KH.Name = "dataGridView_KH";
            this.dataGridView_KH.RowHeadersWidth = 62;
            this.dataGridView_KH.RowTemplate.Height = 28;
            this.dataGridView_KH.Size = new System.Drawing.Size(1310, 380);
            this.dataGridView_KH.TabIndex = 0;
            this.dataGridView_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KH_CellClick);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "iMaKH";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 8;
            this.makh.Name = "makh";
            this.makh.Width = 160;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "sTenKH";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 8;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 200;
            // 
            // diachikh
            // 
            this.diachikh.DataPropertyName = "sDiaChi";
            this.diachikh.HeaderText = "Địa chỉ";
            this.diachikh.MinimumWidth = 8;
            this.diachikh.Name = "diachikh";
            this.diachikh.Width = 250;
            // 
            // sdtkh
            // 
            this.sdtkh.DataPropertyName = "sDienThoai";
            this.sdtkh.HeaderText = "Số điện thoại";
            this.sdtkh.MinimumWidth = 8;
            this.sdtkh.Name = "sdtkh";
            this.sdtkh.Width = 170;
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhachHang";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_maKH;
        private System.Windows.Forms.TextBox textBox_diachiKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_themKH;
        private System.Windows.Forms.Button button_xoaKH;
        private System.Windows.Forms.Button button_suaKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button_timKH;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.MaskedTextBox textBox_sdtKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_KH;
        private System.Windows.Forms.ErrorProvider errorCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtkh;
    }
}