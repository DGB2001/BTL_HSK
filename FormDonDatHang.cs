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
    public partial class FormDonDatHang : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            LoadcbMaNV();
            LoadcbMaKH();
            HienDDH();
        }

        private void LoadcbMaNV()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from tblNhanVien", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "iMaNV";
            cbMaNV.ValueMember = "iMaNV";
        }

        private void LoadcbMaKH()
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

        private void HienDDH()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "xem_ddh";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblDonDatHang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvDonDatHang.DataSource = dataView;
                    }
                }
            }
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
                        DataTable dataTable = new DataTable("tblDonDatHang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvChiTietDatHang.DataSource = dataView;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dgvDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //errorCheck.SetError(txtMaNCC, "");
            txtMaHD.Text = dgvDonDatHang.CurrentRow.Cells["iSoHD"].Value.ToString();
            cbMaNV.SelectedIndex = cbMaNV.FindStringExact(dgvDonDatHang.CurrentRow.Cells["iMaNV"].Value.ToString());
            cbMaKH.SelectedIndex = cbMaKH.FindStringExact(dgvDonDatHang.CurrentRow.Cells["iMaKH"].Value.ToString());
            txtNgayDatHang.Text = dgvDonDatHang.CurrentRow.Cells["dNgayDatHang"].Value.ToString();
            txtNgayGiaoHang.Text = dgvDonDatHang.CurrentRow.Cells["dNgayGiaoHang"].Value.ToString();
            txtTongTien.Text = dgvDonDatHang.CurrentRow.Cells["fTongTienHD"].Value.ToString();
            int ma_ddh = int.Parse(dgvDonDatHang.CurrentRow.Cells["iSoHD"].Value.ToString());
            HienCTDDH(ma_ddh);
        }
    }
}
