using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormNhanVien : Form
    {
        //public static string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormNhanVien()
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

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            rdbNam.Checked = true;
            hienDSNV();
        }

        private void hienDSNV()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "xem_nv";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblNhanVien");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvNhanVien.DataSource = dataView;
                        dgvNhanVien.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvNhanVien.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            errorCheck.SetError(txtHoten, "");
            errorCheck.SetError(txtDiachi, "");
            errorCheck.SetError(txtSodienthoai, "");
            errorCheck.SetError(txtNgaysinh, "");
            errorCheck.SetError(txtNgayvaolam, "");
            errorCheck.SetError(txtLuongcoban, "");
            errorCheck.SetError(txtPhucap, "");
            check = true;
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSodienthoai.Text = "";
            txtNgaysinh.Text = "";
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            txtNgayvaolam.Text = "";
            txtLuongcoban.Text = "";
            txtPhucap.Text = "";
            hienDSNV();
        }

        private static bool checkDuplicate(string hoten, string diachi, string sdt, string ngaysinh, string gioitinh, string ngayvaolam, string luongcoban, string phucap)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "kt_nv";
                using (SqlCommand sqlCommand = new SqlCommand(procname, cnn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ten_nv", hoten);
                    sqlCommand.Parameters.AddWithValue("@dia_chi", diachi);
                    sqlCommand.Parameters.AddWithValue("@sdt", sdt);
                    sqlCommand.Parameters.AddWithValue("@ngay_sinh", DateTime.Parse(ngaysinh));
                    sqlCommand.Parameters.AddWithValue("@gioi_tinh", gioitinh);
                    sqlCommand.Parameters.AddWithValue("@ngay_vao_lam", DateTime.Parse(ngayvaolam));
                    sqlCommand.Parameters.AddWithValue("@luong_co_ban", float.Parse(luongcoban));
                    sqlCommand.Parameters.AddWithValue("@phu_cap", float.Parse(phucap));
                    cnn.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        //check query da execute
                        return false;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                string gioi_tinh = "";
                if (rdbNam.Checked) gioi_tinh = "Nam";
                else gioi_tinh = "Nữ";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"them_nv";
                cmd.Parameters.AddWithValue("@ten_nv", txtHoten.Text);
                cmd.Parameters.AddWithValue("@dia_chi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@sdt", txtSodienthoai.Text);
                cmd.Parameters.AddWithValue("@ngay_sinh", DateTime.Parse(txtNgaysinh.Text));
                cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
                cmd.Parameters.AddWithValue("@ngay_vao_lam", DateTime.Parse(txtNgayvaolam.Text));
                cmd.Parameters.AddWithValue("@luong_co_ban", float.Parse(txtLuongcoban.Text));
                cmd.Parameters.AddWithValue("@phu_cap", float.Parse(txtPhucap.Text));
                if (checkDuplicate(txtHoten.Text, txtDiachi.Text, txtSodienthoai.Text, txtNgaysinh.Text, gioi_tinh, txtNgayvaolam.Text, txtLuongcoban.Text, txtPhucap.Text))
                {
                    MessageBox.Show("Nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSNV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorCheck.SetError(txtHoten, "");
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells["Họ và tên"].Value.ToString();
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtSodienthoai.Text = dgvNhanVien.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            txtNgaysinh.Text = dgvNhanVien.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtNgayvaolam.Text = dgvNhanVien.CurrentRow.Cells["Ngày vào làm"].Value.ToString();
            txtLuongcoban.Text = dgvNhanVien.CurrentRow.Cells["Lương cơ bản"].Value.ToString();
            txtPhucap.Text = dgvNhanVien.CurrentRow.Cells["Phụ cấp"].Value.ToString();
            string gioi_tinh = dgvNhanVien.CurrentRow.Cells["Giới tính"].Value.ToString();
            if (gioi_tinh == "Nam")
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else
            {
                rdbNam.Checked = false;
                rdbNu.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma_nv = int.Parse(dgvNhanVien.CurrentRow.Cells["Mã NV"].Value.ToString());
            string gioi_tinh = "";
            if (rdbNam.Checked) gioi_tinh = "Nam";
            else gioi_tinh = "Nữ";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"sua_nv";
            cmd.Parameters.AddWithValue("@ma_nv", ma_nv);
            cmd.Parameters.AddWithValue("@ten_nv", txtHoten.Text);
            cmd.Parameters.AddWithValue("@dia_chi", txtDiachi.Text);
            cmd.Parameters.AddWithValue("@sdt", txtSodienthoai.Text);
            cmd.Parameters.AddWithValue("@ngay_sinh", DateTime.Parse(txtNgaysinh.Text));
            cmd.Parameters.AddWithValue("@gioi_tinh", gioi_tinh);
            cmd.Parameters.AddWithValue("@ngay_vao_lam", DateTime.Parse(txtNgayvaolam.Text));
            cmd.Parameters.AddWithValue("@luong_co_ban", float.Parse(txtLuongcoban.Text));
            cmd.Parameters.AddWithValue("@phu_cap", float.Parse(txtPhucap.Text));
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienDSNV();
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
                int ma_nv = int.Parse(dgvNhanVien.CurrentRow.Cells["Mã NV"].Value.ToString());
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"xoa_nv";
                cmd.Parameters.AddWithValue("@ma_nv", ma_nv);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienDSNV();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            if (txtHoten.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtHoten, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtHoten, "");
                check = true;
            }
        }

        private void txtDiachi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachi.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtDiachi, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtDiachi, "");
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

        private void txtNgaysinh_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNgaysinh.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
            {
                errorCheck.SetError(txtNgaysinh, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtNgaysinh, "");
                check = true;
            }
        }

        private void txtNgayvaolam_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNgayvaolam.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
            {
                errorCheck.SetError(txtNgayvaolam, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtNgayvaolam, "");
                check = true;
            }
        }

        private void txtLuongcoban_Validating(object sender, CancelEventArgs e)
        {
            if (txtLuongcoban.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtLuongcoban, "Không được bỏ trống");
                check = false;
            }
            else if (!Regex.IsMatch(txtLuongcoban.Text, @"\d+"))
            {
                errorCheck.SetError(txtLuongcoban, "Lương chỉ bao gồm số");
                check = false;
            }
            else if (!Regex.IsMatch(txtLuongcoban.Text, @"^\d*(\.\d+)?$"))
            {
                errorCheck.SetError(txtLuongcoban, "Lương phải lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtLuongcoban, "");
                check = true;
            }
        }

        private void txtPhucap_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhucap.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtPhucap, "Không được bỏ trống");
                check = false;
            }
            else if (!Regex.IsMatch(txtPhucap.Text, @"\d+"))
            {
                errorCheck.SetError(txtPhucap, "Phụ cấp chỉ bao gồm số");
                check = false;
            }
            else if (!Regex.IsMatch(txtPhucap.Text, @"^\d*(\.\d+)?$"))
            {
                errorCheck.SetError(txtPhucap, "Phụ cấp phải lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtPhucap, "");
                check = true;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string hoten = txtHoten.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSodienthoai.Text;
            string luongcoban = txtLuongcoban.Text;
            string phucap = txtPhucap.Text;
            string gioitinh = "";
            if (rdbNam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            string cond = "[Mã NV] > 0";
            if (!string.IsNullOrEmpty(hoten))
            {
                cond += string.Format(" AND [Họ và tên] LIKE '%{0}%' ", hoten);
            }
            if (!string.IsNullOrEmpty(diachi))
            {
                cond += string.Format(" AND [Địa chỉ] LIKE '%{0}%' ", diachi);
            }
            if (!string.IsNullOrEmpty(sdt))
            {
                cond += string.Format(" AND [Số điện thoại] LIKE '%{0}%' ", sdt);
            }
            if (Regex.IsMatch(txtNgaysinh.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
            {
                DateTime ngaysinh = DateTime.ParseExact(txtNgaysinh.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cond += string.Format(" AND [Ngày sinh] >= '{0}' AND [Ngày sinh] <= '{0}' ", ngaysinh);
            }
            if (Regex.IsMatch(txtNgayvaolam.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$"))
            {
                DateTime ngayvaolam = DateTime.ParseExact(txtNgayvaolam.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cond += string.Format(" AND [Ngày vào làm] >= '{0}' AND [Ngày vào làm] <= '{0}' ", ngayvaolam);
            }
            DialogResult dialogResult = MessageBox.Show("Có tìm kiếm theo giới tính không", "Tìm kiếm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cond += string.Format(" AND [Giới tính]  LIKE '%{0}%'", gioitinh);
            }
            if (!string.IsNullOrEmpty(luongcoban))
            {
                cond += string.Format(" AND [Lương cơ bản] = '{0}' ", float.Parse(luongcoban));
            }
            if (!string.IsNullOrEmpty(phucap))
            {
                cond += string.Format(" AND [Phụ cấp] = '{0}' ", float.Parse(phucap));
            }

            DataView dataView = dgvNhanVien.DataSource as DataView;
            dataView.RowFilter = cond;
            dgvNhanVien.DataSource = dataView;
        }
    }
}
