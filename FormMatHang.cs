using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormMatHang : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormMatHang()
        {
            InitializeComponent();
        }

        private void LoadNCCList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblNhaCungCap", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "sTenNhaCC";
            cbNCC.ValueMember = "iMaNCC";
        }

        private void LoadTenLoaiHangList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblLoaiHang", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbLoaiHang.DataSource = dt;
            cbLoaiHang.DisplayMember = "sTenLoaiHang";
            cbLoaiHang.ValueMember = "sMaLoaiHang";
        }

        private void hienDSMH()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string procname = "xem_mh";
                using (SqlCommand cmd = new SqlCommand(procname, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblMatHang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvMatHang.DataSource = dataView;
                    }
                }
            }
        }

        private void FormMatHang_Load(object sender, EventArgs e)
        {
            txtMaHang.Focus();
            LoadNCCList();
            LoadTenLoaiHangList();
            hienDSMH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            errorCheck.SetError(txtMaHang, "");
            errorCheck.SetError(txtTenHang, "");
            errorCheck.SetError(cbNCC, "");
            errorCheck.SetError(cbLoaiHang, "");
            errorCheck.SetError(txtSoLuong, "");
            errorCheck.SetError(txtGiaHang, "");
            check = true;
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cbNCC.Text = "";
            cbLoaiHang.Text = "";
            txtSoLuong.Text = "";
            txtGiaHang.Text = "";
            txtMaHang.Focus();
            hienDSMH();
        }

        private static bool checkDuplicate(string mahang, string tenhang, int mancc, string maloaihang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string procname = "kt_mh";
                using (SqlCommand sqlCommand = new SqlCommand(procname, conn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ma_mh", mahang);
                    sqlCommand.Parameters.AddWithValue("@ten_mh", tenhang);
                    sqlCommand.Parameters.AddWithValue("@ma_ncc", mancc);
                    sqlCommand.Parameters.AddWithValue("@ma_loaihang", maloaihang);
                    conn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string cbncc = cbNCC.SelectedValue.ToString();
                string cbloaihang = cbLoaiHang.SelectedValue.ToString();
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"them_mh";
                cmd.Parameters.AddWithValue("@ma_mh", txtMaHang.Text);
                cmd.Parameters.AddWithValue("@ten_mh", txtTenHang.Text);
                cmd.Parameters.AddWithValue("@ma_ncc", cbncc);
                cmd.Parameters.AddWithValue("@ma_loaihang", cbloaihang);
                cmd.Parameters.AddWithValue("@so_luong", float.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@gia_hang", float.Parse(txtGiaHang.Text));
                if (checkDuplicate(txtMaHang.Text, txtTenHang.Text, int.Parse(cbncc), cbloaihang))
                {
                    MessageBox.Show("Mặt hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSMH();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cbncc = cbNCC.SelectedValue.ToString();
            string cbloaihang = cbLoaiHang.SelectedValue.ToString();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"sua_mh";
            cmd.Parameters.AddWithValue("@ma_mh", txtMaHang.Text);
            cmd.Parameters.AddWithValue("@ten_mh", txtTenHang.Text);
            cmd.Parameters.AddWithValue("@ma_ncc", cbncc);
            cmd.Parameters.AddWithValue("@ma_loaihang", cbloaihang);
            cmd.Parameters.AddWithValue("@so_luong", float.Parse(txtSoLuong.Text));
            cmd.Parameters.AddWithValue("@gia_hang", float.Parse(txtGiaHang.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienDSMH();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string ma_mh = dgvMatHang.CurrentRow.Cells["sMaHang"].Value.ToString();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"xoa_mh";
                cmd.Parameters.AddWithValue("@ma_mh", ma_mh);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienDSMH();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorCheck.SetError(txtMaHang, "");
            txtMaHang.Text = dgvMatHang.CurrentRow.Cells["sMaHang"].Value.ToString();
            txtTenHang.Text = dgvMatHang.CurrentRow.Cells["sTenHang"].Value.ToString();
            cbNCC.SelectedValue = dgvMatHang.CurrentRow.Cells["iMaNCC"].Value.ToString();
            cbLoaiHang.SelectedValue = dgvMatHang.CurrentRow.Cells["sMaLoaiHang"].Value.ToString();
            txtSoLuong.Text = dgvMatHang.CurrentRow.Cells["fSoLuong"].Value.ToString();
            txtGiaHang.Text = dgvMatHang.CurrentRow.Cells["fGiaHang"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma_mh = txtMaHang.Text;
            string ten_mh = txtTenHang.Text;
            string ma_ncc = cbNCC.SelectedValue.ToString();
            string ma_loaihang = cbLoaiHang.SelectedValue.ToString();
            string so_luong = txtSoLuong.Text;
            string gia_hang = txtGiaHang.Text;
            string cond = "[sMaHang] <> ''";
            if (!string.IsNullOrEmpty(ma_mh))
            {
                cond += string.Format(" AND [sMaHang] LIKE '%{0}%' ", ma_mh);
            }
            if (!string.IsNullOrEmpty(ten_mh))
            {
                cond += string.Format(" AND [sTenHang] LIKE '%{0}%' ", ten_mh);
            }
            if (!string.IsNullOrEmpty(ma_ncc))
            {
                cond += string.Format(" AND [iMaNCC] = '{0}' ", int.Parse(ma_ncc));
            }
            if (!string.IsNullOrEmpty(ma_loaihang))
            {
                cond += string.Format(" AND [sMaLoaiHang] LIKE '%{0}%' ", ma_loaihang);
            }
            if (!string.IsNullOrEmpty(so_luong))
            {
                cond += string.Format(" AND [fSoLuong] = '{0}' ", float.Parse(so_luong));
            }
            if (!string.IsNullOrEmpty(ma_ncc))
            {
                cond += string.Format(" AND [fGiaHang] = '{0}' ", float.Parse(gia_hang));
            }
            DataView dataView = dgvMatHang.DataSource as DataView;
            dataView.RowFilter = cond;
            dgvMatHang.DataSource = dataView;
        }

        private void txtMaHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaHang.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtMaHang, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtMaHang, "");
                check = true;
            }
        }

        private void txtTenHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenHang.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtTenHang, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtTenHang, "");
                check = true;
            }
        }

        private void txtGiaHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtGiaHang.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtGiaHang, "Không được bỏ trống");
                check = false;
            }
            else if (!Regex.IsMatch(txtGiaHang.Text, @"\d+"))
            {
                errorCheck.SetError(txtGiaHang, "Lương chỉ bao gồm số");
                check = false;
            }
            else if (!Regex.IsMatch(txtGiaHang.Text, @"^\d*(\.\d+)?$"))
            {
                errorCheck.SetError(txtGiaHang, "Giá hàng phải lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtGiaHang, "");
                check = true;
            }
        }

        private void txtSoLuong_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "0")
            {
                errorCheck.SetError(txtSoLuong, "Số lượng phải lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtSoLuong, "");
                check = true;
            }
        }
    }
}
