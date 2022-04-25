
namespace BTL_HSK
{
    partial class FormDonNhapKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNNH = new System.Windows.Forms.MaskedTextBox();
            this.tbSLN = new System.Windows.Forms.TextBox();
            this.tbMNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSNK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvDonNK = new System.Windows.Forms.DataGridView();
            this.colSNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGiaNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNNH);
            this.groupBox1.Controls.Add(this.tbSLN);
            this.groupBox1.Controls.Add(this.tbMNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSNK);
            this.groupBox1.Location = new System.Drawing.Point(50, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1000, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn Nhập Kho";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(689, 102);
            this.tbGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(223, 26);
            this.tbGiaNhap.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá Nhập";
            // 
            // tbNNH
            // 
            this.tbNNH.Location = new System.Drawing.Point(229, 158);
            this.tbNNH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNNH.Mask = "00/00/0000";
            this.tbNNH.Name = "tbNNH";
            this.tbNNH.Size = new System.Drawing.Size(223, 26);
            this.tbNNH.TabIndex = 8;
            this.tbNNH.ValidatingType = typeof(System.DateTime);
            // 
            // tbSLN
            // 
            this.tbSLN.Location = new System.Drawing.Point(689, 37);
            this.tbSLN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSLN.Name = "tbSLN";
            this.tbSLN.Size = new System.Drawing.Size(223, 26);
            this.tbSLN.TabIndex = 7;
            // 
            // tbMNV
            // 
            this.tbMNV.Location = new System.Drawing.Point(229, 102);
            this.tbMNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMNV.Name = "tbMNV";
            this.tbMNV.Size = new System.Drawing.Size(223, 26);
            this.tbMNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Lượng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Nhập Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Nhập Kho";
            // 
            // tbSNK
            // 
            this.tbSNK.Location = new System.Drawing.Point(229, 37);
            this.tbSNK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSNK.Name = "tbSNK";
            this.tbSNK.Size = new System.Drawing.Size(223, 26);
            this.tbSNK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(1070, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(300, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 41);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(163, 135);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 29);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(44, 135);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(163, 41);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // dgvDonNK
            // 
            this.dgvDonNK.AllowUserToAddRows = false;
            this.dgvDonNK.AllowUserToDeleteRows = false;
            this.dgvDonNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSNK,
            this.colMNV,
            this.colNNH,
            this.colSLN,
            this.colGiaNhap});
            this.dgvDonNK.Location = new System.Drawing.Point(5, 20);
            this.dgvDonNK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonNK.Name = "dgvDonNK";
            this.dgvDonNK.ReadOnly = true;
            this.dgvDonNK.RowHeadersWidth = 51;
            this.dgvDonNK.RowTemplate.Height = 24;
            this.dgvDonNK.Size = new System.Drawing.Size(1309, 329);
            this.dgvDonNK.TabIndex = 2;
            // 
            // colSNK
            // 
            this.colSNK.DataPropertyName = "iSoNK";
            this.colSNK.HeaderText = "Số Nhập Kho";
            this.colSNK.MinimumWidth = 6;
            this.colSNK.Name = "colSNK";
            this.colSNK.ReadOnly = true;
            // 
            // colMNV
            // 
            this.colMNV.DataPropertyName = "iMaNV";
            this.colMNV.HeaderText = "Mã Nhân Viên";
            this.colMNV.MinimumWidth = 6;
            this.colMNV.Name = "colMNV";
            this.colMNV.ReadOnly = true;
            // 
            // colNNH
            // 
            this.colNNH.DataPropertyName = "dNgayNhapHang";
            this.colNNH.HeaderText = "Ngày Nhập Hàng";
            this.colNNH.MinimumWidth = 6;
            this.colNNH.Name = "colNNH";
            this.colNNH.ReadOnly = true;
            // 
            // colSLN
            // 
            this.colSLN.DataPropertyName = "fSoLuongNhap";
            this.colSLN.HeaderText = "Số Lượng Nhập";
            this.colSLN.MinimumWidth = 6;
            this.colSLN.Name = "colSLN";
            this.colSLN.ReadOnly = true;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.DataPropertyName = "fGiaNhap";
            this.colGiaNhap.HeaderText = "Giá Nhập";
            this.colGiaNhap.MinimumWidth = 6;
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.label7, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1420, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quản lý đơn nhập kho";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDonNK);
            this.groupBox3.Location = new System.Drawing.Point(50, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1320, 356);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đơn nhập kho";
            // 
            // FormDonNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDonNhapKho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDonNhapKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDonNK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSNK;
        private System.Windows.Forms.TextBox tbSLN;
        private System.Windows.Forms.TextBox tbMNV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.MaskedTextBox tbNNH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}