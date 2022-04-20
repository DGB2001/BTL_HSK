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
    public partial class FormNhaCungCap : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void hienDSNCC()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "xem_ncc";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblNhaCungCap");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvNhaCungCap.DataSource = dataView;
                    }
                }
            }
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            hienDSNCC();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            errorCheck.SetError(txtMaNCC, "");
            errorCheck.SetError(txtTenNCC, "");
            errorCheck.SetError(txtTenGiaoDich, "");
            errorCheck.SetError(txtDiaChi, "");
            errorCheck.SetError(txtSodienthoai, "");
            check = true;
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtTenGiaoDich.Text = "";
            txtDiaChi.Text = "";
            txtSodienthoai.Text = "";
            hienDSNCC();
        }

        private static bool checkPrimaryKey(int ma_ncc)
        {
            string sql = "SELECT * FROM tblNhaCungCap WHERE iMaNCC=" + ma_ncc + "";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool checkDuplicate(int ma_ncc, string ten_ncc, string ten_giao_dich, string dia_chi, string sdt)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "kt_ncc";
                using (SqlCommand sqlCommand = new SqlCommand(procname, cnn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ma_ncc", ma_ncc);
                    sqlCommand.Parameters.AddWithValue("@ten_ncc", ten_ncc);
                    sqlCommand.Parameters.AddWithValue("@ten_giao_dich", ten_giao_dich);
                    sqlCommand.Parameters.AddWithValue("@dia_chi", dia_chi);
                    sqlCommand.Parameters.AddWithValue("@sdt", sdt);
                    cnn.Open();
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
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"them_ncc";
                cmd.Parameters.AddWithValue("@ma_ncc", Int32.Parse(txtMaNCC.Text));
                cmd.Parameters.AddWithValue("@ten_ncc", txtTenNCC.Text);
                cmd.Parameters.AddWithValue("@ten_giao_dich", txtTenGiaoDich.Text);
                cmd.Parameters.AddWithValue("@dia_chi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSodienthoai.Text);
                if (checkDuplicate(Int32.Parse(txtMaNCC.Text), txtTenNCC.Text, txtTenGiaoDich.Text, txtDiaChi.Text, txtSodienthoai.Text))
                {
                    MessageBox.Show("Nhà cung cấp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkPrimaryKey(Int32.Parse(txtMaNCC.Text)))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSNCC();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorCheck.SetError(txtMaNCC, "");
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells["Mã NCC"].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells["Tên nhà cung cấp"].Value.ToString();
            txtTenGiaoDich.Text = dgvNhaCungCap.CurrentRow.Cells["Tên giao dịch"].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtSodienthoai.Text = dgvNhaCungCap.CurrentRow.Cells["Số điện thoại"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"sua_ncc";
            cmd.Parameters.AddWithValue("@ma_ncc", int.Parse(txtMaNCC.Text));
            cmd.Parameters.AddWithValue("@ten_ncc", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("@ten_giao_dich", txtTenGiaoDich.Text);
            cmd.Parameters.AddWithValue("@dia_chi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSodienthoai.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienDSNCC();
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
                int ma_ncc = int.Parse(dgvNhaCungCap.CurrentRow.Cells["Mã NCC"].Value.ToString());
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"xoa_ncc";
                cmd.Parameters.AddWithValue("@ma_ncc", ma_ncc);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienDSNCC();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMaNCC_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaNCC.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtMaNCC, "Không được bỏ trống");
                check = false;
            }
            else if (!Regex.IsMatch(txtMaNCC.Text, @"\d+"))
            {
                errorCheck.SetError(txtMaNCC, "Mã chỉ bao gồm số");
                check = false;
            }
            else if (!Regex.IsMatch(txtMaNCC.Text, @"^\d*(\.\d+)?$"))
            {
                errorCheck.SetError(txtMaNCC, "Mã phải là số lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtMaNCC, "");
                check = true;
            }
        }

        private void txtTenNCC_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNCC.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtTenNCC, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtTenNCC, "");
                check = true;
            }
        }

        private void txtTenGiaoDich_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenGiaoDich.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtTenGiaoDich, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtTenGiaoDich, "");
                check = true;
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtDiaChi, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtDiaChi, "");
                check = true;
            }
        }

        private void txtSodienthoai_Validating(object sender, CancelEventArgs e)
        {
            if (txtSodienthoai.Text == "")
            {
                errorCheck.SetError(txtSodienthoai, "Không được bỏ trống");
                check = false;
            }
            else if (txtSodienthoai.Text.Length > 0 && txtSodienthoai.Text.Length < 10)
            {
                errorCheck.SetError(txtSodienthoai, "Số điện thoại bao gồm 10 số");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtSodienthoai, "");
                check = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string ma_ncc = txtMaNCC.Text;
            string ten_ncc = txtTenNCC.Text;
            string ten_giao_dich = txtTenGiaoDich.Text;
            string dia_chi = txtDiaChi.Text;
            string sdt = txtSodienthoai.Text;
            string cond = "[Mã NCC] > 0";
            if (!string.IsNullOrEmpty(ma_ncc))
            {
                cond += string.Format(" AND [Mã NCC] = '{0}' ", int.Parse(ma_ncc));
            }
            if (!string.IsNullOrEmpty(ten_ncc))
            {
                cond += string.Format(" AND [Tên nhà cung cấp] LIKE '%{0}%' ", ten_ncc);
            }
            if (!string.IsNullOrEmpty(ten_giao_dich))
            {
                cond += string.Format(" AND [Tên giao dịch] LIKE '%{0}%' ", ten_giao_dich);
            }
            if (!string.IsNullOrEmpty(dia_chi))
            {
                cond += string.Format(" AND [Địa chỉ] LIKE '%{0}%' ", dia_chi);
            }
            if (!string.IsNullOrEmpty(sdt))
            {
                cond += string.Format(" AND [Số điện thoại] LIKE '%{0}%' ", sdt);
            }
            DataView dataView = dgvNhaCungCap.DataSource as DataView;
            dataView.RowFilter = cond;
            dgvNhaCungCap.DataSource = dataView;
        }
    }
}
