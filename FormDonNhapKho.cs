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
    public partial class FormDonNhapKho : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormDonNhapKho()
        {
            InitializeComponent();
        }

        private DataTable Get_Dulieu(string procname, string tablename)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(procname, cnn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable tbl = new DataTable(tablename);
            da.Fill(tbl);
            return tbl;
        }
        private void hienthi(string procname, string tablename, DataGridView dgv)
        {
            DataTable table = Get_Dulieu(procname, tablename);
            DataView view = new DataView(table);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = view;
        }

        private void FormDonNhapKho_Load(object sender, EventArgs e)
        {
            hienthi("xem_donnk", "tblDonNhapKho", dgvDonNK);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "them_dnk";
                    cmd.Parameters.AddWithValue("@snk", tbSNK.Text);
                    cmd.Parameters.AddWithValue("@ma_nv", tbMNV.Text);
                    cmd.Parameters.AddWithValue("@ngaynhaphang", Convert.ToDateTime(tbNNH.Text));
                    cmd.Parameters.AddWithValue("@soluongnhap", tbSLN.Text);
                    cmd.Parameters.AddWithValue("@gianhap", tbGiaNhap.Text);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
            hienthi("xem_donnk", "tblDonNhapKho", dgvDonNK);
        }
    }
}
