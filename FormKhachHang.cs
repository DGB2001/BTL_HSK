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
    public partial class FormKhachHang : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            hienDSKH();
        }

        private void hienDSKH()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "xemKH";
                using (SqlCommand cmd = new SqlCommand(procname, cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable("tblKhachHang");
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dataGridView_KH.DataSource = dataView;
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            errorCheck.SetError(textBox_maKH, "");
            errorCheck.SetError(textBox_tenKH, "");
            errorCheck.SetError(textBox_sdtKH, "");
            errorCheck.SetError(textBox_diachiKH, "");

            check = true;
            textBox_maKH.Text = "";
            textBox_tenKH.Text = "";
            textBox_sdtKH.Text = "";
            textBox_diachiKH.Text = "";
            hienDSKH();
        }

        private static bool checkDuplicate(string makh, string tenkh, string sdtkh, string diachikh)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string procname = "kiemtra_kh";
                using (SqlCommand sqlCommand = new SqlCommand(procname, cnn))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ma_kh", makh);
                    sqlCommand.Parameters.AddWithValue("@ten_kh", tenkh);

                    sqlCommand.Parameters.AddWithValue("@dia_chi", diachikh);
                    sqlCommand.Parameters.AddWithValue("@sdt", sdtkh);
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

        private static bool checkPrimaryKey(int ma_kh)
        {
            string sql = "SELECT * FROM tblKhachHang WHERE iMaKH=" + ma_kh + "";
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

        private void button_themKH_Click(object sender, EventArgs e)
        {
            if (check == true)
            {

                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"ThemKhachhang";
                cmd.Parameters.AddWithValue("@ma_kh", textBox_maKH.Text);
                cmd.Parameters.AddWithValue("@ten_kh", textBox_tenKH.Text);
                cmd.Parameters.AddWithValue("@dia_chi", textBox_diachiKH.Text);
                cmd.Parameters.AddWithValue("@sdt", textBox_sdtKH.Text);

                if (checkDuplicate(textBox_maKH.Text, textBox_tenKH.Text, textBox_sdtKH.Text, textBox_diachiKH.Text))
                {
                    MessageBox.Show("Khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkPrimaryKey(int.Parse(textBox_maKH.Text)))
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienDSKH();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorCheck.SetError(textBox_maKH, "");
            textBox_maKH.Text = dataGridView_KH.CurrentRow.Cells["makh"].Value.ToString();
            textBox_tenKH.Text = dataGridView_KH.CurrentRow.Cells["tenkh"].Value.ToString();
            textBox_diachiKH.Text = dataGridView_KH.CurrentRow.Cells["diachikh"].Value.ToString();
            textBox_sdtKH.Text = dataGridView_KH.CurrentRow.Cells["sdtkh"].Value.ToString();
        }

        private void button_suaKH_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = @"sua_kh";
            cmd.Parameters.AddWithValue("@ma_kh", textBox_maKH.Text);
            cmd.Parameters.AddWithValue("@ten_kh", textBox_tenKH.Text);
            cmd.Parameters.AddWithValue("@sdt", textBox_sdtKH.Text);
            cmd.Parameters.AddWithValue("@dia_chi", textBox_diachiKH.Text);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienDSKH();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_xoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"xoa_kh";
                cmd.Parameters.AddWithValue("@ma_kh", textBox_maKH.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienDSKH();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_timKH_Click(object sender, EventArgs e)
        {
            string ma_kh = textBox_maKH.Text;
            string ten_kh = textBox_tenKH.Text;
            string dia_chi = textBox_diachiKH.Text;
            string sdt = textBox_sdtKH.Text;
            string cond = "iMaKH > 0";
            if (!string.IsNullOrEmpty(ma_kh))
            {
                cond += string.Format(" AND iMaKH = '{0}' ", int.Parse(ma_kh));
            }
            if (!string.IsNullOrEmpty(ten_kh))
            {
                cond += string.Format(" AND sTenKH LIKE '%{0}%' ", ten_kh);
            }
            if (!string.IsNullOrEmpty(dia_chi))
            {
                cond += string.Format(" AND sDiaChi LIKE '%{0}%' ", dia_chi);
            }
            if (!string.IsNullOrEmpty(sdt))
            {
                cond += string.Format(" AND sDienThoai LIKE '%{0}%' ", sdt);
            }
            DataView dataView = dataGridView_KH.DataSource as DataView;
            dataView.RowFilter = cond;
            dataGridView_KH.DataSource = dataView;
        }

        private void textBox_sdtKH_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_sdtKH.Text == "")
            {
                errorCheck.SetError(textBox_sdtKH, "Không được bỏ trống");
                check = false;
            }
            else if (textBox_sdtKH.Text.Length > 0 && textBox_sdtKH.Text.Length < 10)
            {
                errorCheck.SetError(textBox_sdtKH, "Số điện thoại bao gồm 10 số");
                check = false;
            }
            else
            {
                errorCheck.SetError(textBox_sdtKH, "");
                check = true;
            }
        }

        private void textBox_maKH_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_maKH.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(textBox_maKH, "Không được bỏ trống");
                check = false;
            }
            else if (!Regex.IsMatch(textBox_maKH.Text, @"\d+"))
            {
                errorCheck.SetError(textBox_maKH, "Mã chỉ bao gồm số");
                check = false;
            }
            else if (!Regex.IsMatch(textBox_maKH.Text, @"^\d*(\.\d+)?$"))
            {
                errorCheck.SetError(textBox_maKH, "Mã phải là số lớn hơn 0");
                check = false;
            }
            else
            {
                errorCheck.SetError(textBox_maKH, "");
                check = true;
            }
        }

        private void textBox_diachiKH_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_diachiKH.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(textBox_diachiKH, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(textBox_diachiKH, "");
                check = true;
            }
        }

        private void textBox_tenKH_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_tenKH.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(textBox_tenKH, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(textBox_tenKH, "");
                check = true;
            }
        }
    }
}
