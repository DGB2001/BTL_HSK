using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormMuaHang : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormMuaHang()
        {
            InitializeComponent();
        }

        private void FormMuaHang_Load(object sender, EventArgs e)
        {
            LoadNVList();
            LoadKHList();
            LoadDDHList();
            LoadMHList();
        }

        private void LoadNVList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblNhanVien", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "iMaNV";
            cbMaNV.ValueMember = "iMaNV";

            //checkedListBox1.DataSource = dt;
            //checkedListBox1.DisplayMember = "iMaNV";
            //checkedListBox1.ValueMember = "iMaNV";
        }

        private void LoadKHList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblKhachHang", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "iMaKH";
            cbMaKH.ValueMember = "iMaKH";
        }

        private void LoadDDHList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblDonDatHang", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbMaDDH.DataSource = dt;
            cbMaDDH.DisplayMember = "iSoHD";
            cbMaDDH.ValueMember = "iSoHD";
        }

        private void LoadMHList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblMatHang", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbMaHang.DataSource = dt;
            cbMaHang.DisplayMember = "sMaHang";
            cbMaHang.ValueMember = "sMaHang";
        }

        private void HienCTDDH(int ma_ddh)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "xem_ctddh";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ma_ddh", ma_ddh);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblChiTietDatHang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvChiTietDatHang.DataSource = dataView;
                    }
                }
            }
        }

        private void btnThemChiTietDatHang_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"them_ctddh";
            cmd.Parameters.AddWithValue("@so_hd", int.Parse(cbMaDDH.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@ma_mh", cbMaHang.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@so_luong_mua", txtSoLuongMua.Value);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienCTDDH(int.Parse(cbMaDDH.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDonDatHang_Click(object sender, EventArgs e)
        {
            int ma_nv = int.Parse(cbMaNV.SelectedValue.ToString());
            int ma_kh = int.Parse(cbMaKH.SelectedValue.ToString());
            //checkedListBox1.CheckedItems.ToString();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"them_ddh";
            cmd.Parameters.AddWithValue("@so_hd", int.Parse(txtMaHD.Text));
            cmd.Parameters.AddWithValue("@ma_nv", ma_nv);
            cmd.Parameters.AddWithValue("@ma_kh", ma_kh);
            cmd.Parameters.AddWithValue("@ngay_dat_hang", DateTime.Parse(txtNgayDatHang.Text));
            cmd.Parameters.AddWithValue("@ngay_giao_hang", DateTime.Parse(txtNgayGiaoHang.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Thêm đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDDHList();
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemChiTietDatHang_Click(object sender, EventArgs e)
        {
            int ma_dh = int.Parse(cbMaDDH.SelectedValue.ToString());
            HienCTDDH(ma_dh);
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            int ma_nv = int.Parse(cbMaNV.SelectedValue.ToString());
            int ma_kh = int.Parse(cbMaKH.SelectedValue.ToString());
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"them_ddh";
            cmd.Parameters.AddWithValue("@so_hd", int.Parse(txtMaHD.Text));
            cmd.Parameters.AddWithValue("@ma_nv", ma_nv);
            cmd.Parameters.AddWithValue("@ma_kh", ma_kh);
            cmd.Parameters.AddWithValue("@ngay_dat_hang", DateTime.Parse(txtNgayDatHang.Text));
            cmd.Parameters.AddWithValue("@ngay_giao_hang", DateTime.Parse(txtNgayGiaoHang.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Thêm đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDDHList();
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"them_tongtienddh";
            cmd.Parameters.AddWithValue("@so_hd", int.Parse(cbMaDDH.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@tong_tien", 1);
            int i = cmd.ExecuteNonQuery();
            //SqlDataReader r = cmd.ExecuteReader();
            //if (r.Read())
            //{
            //    txtTongTien.Text = r["fTongTienHD"].ToString();
            //}
        }
    }
}
