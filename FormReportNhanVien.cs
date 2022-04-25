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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BTL_HSK
{
    public partial class FormReportNhanVien : Form
    {
        public static string connectionString = "Data Source=DELL\\DELL;Initial Catalog=QLKDquanao;Integrated Security=True";
        Boolean check = true;
        public FormReportNhanVien()
        {
            InitializeComponent();
        }

        private void FormReportNhanVien_Load(object sender, EventArgs e)
        {
            cbTieude.Items.Add("Danh sách nhân viên");
            cbTieude.Items.Add("Danh sách nhân viên giới tính nam");
            cbTieude.Items.Add("Danh sách nhân viên giới tính nữ");
            cbTieude.Items.Add("Danh sách nhân viên tại Hà Nội");
            cbTieude.Items.Add("Danh sách nhân viên đạt doanh thu trên 100000 trong tháng ...");
            cbTieude.SelectedItem = "Danh sách nhân viên";
            txtNguoibaocao.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var tieu_de = this.cbTieude.GetItemText(this.cbTieude.SelectedItem);
            ReportDocument report = new ReportDocument();

            if (check)
            {

                if (tieu_de == "Danh sách nhân viên")
                {
                    report.Load(@"D:\BaosCode\LAP_TRINH_HSK\BTL_HSK\Report\ReportNhanVien\ReportNhanVien.rpt");
                    ParameterFieldDefinition pfd_nguoi_bao_cao = report.DataDefinition.ParameterFields["nguoi_lap_bao_cao"];
                    ParameterFieldDefinition pfd_tieu_de_bao_cao = report.DataDefinition.ParameterFields["tieu_de_bao_cao"];
                    ParameterValues pv_nguoi_bao_cao = new ParameterValues();
                    ParameterValues pv_tieu_de_bao_cao = new ParameterValues();
                    ParameterDiscreteValue pdv_nguoi_bao_cao = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdv_tieu_de_bao_cao = new ParameterDiscreteValue();

                    pdv_nguoi_bao_cao.Value = txtNguoibaocao.Text;
                    pdv_tieu_de_bao_cao.Value = tieu_de;
                    pv_nguoi_bao_cao.Add(pdv_nguoi_bao_cao);
                    pv_tieu_de_bao_cao.Add(pdv_tieu_de_bao_cao);
                    pfd_nguoi_bao_cao.CurrentValues.Clear();
                    pfd_tieu_de_bao_cao.CurrentValues.Clear();
                    pfd_nguoi_bao_cao.ApplyCurrentValues(pv_nguoi_bao_cao);
                    pfd_tieu_de_bao_cao.ApplyCurrentValues(pv_tieu_de_bao_cao);
                    rptNhanVien.ReportSource = report;
                    rptNhanVien.Refresh();
                }
                else if (tieu_de == "Danh sách nhân viên giới tính nam")
                {
                    report.Load(@"D:\BaosCode\LAP_TRINH_HSK\BTL_HSK\Report\ReportNhanVien\ReportNhanVien.rpt");
                    ParameterFieldDefinition pfd_nguoi_bao_cao = report.DataDefinition.ParameterFields["nguoi_lap_bao_cao"];
                    ParameterFieldDefinition pfd_tieu_de_bao_cao = report.DataDefinition.ParameterFields["tieu_de_bao_cao"];
                    ParameterValues pv_nguoi_bao_cao = new ParameterValues();
                    ParameterValues pv_tieu_de_bao_cao = new ParameterValues();
                    ParameterDiscreteValue pdv_nguoi_bao_cao = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdv_tieu_de_bao_cao = new ParameterDiscreteValue();

                    pdv_nguoi_bao_cao.Value = txtNguoibaocao.Text;
                    pdv_tieu_de_bao_cao.Value = tieu_de;
                    pv_nguoi_bao_cao.Add(pdv_nguoi_bao_cao);
                    pv_tieu_de_bao_cao.Add(pdv_tieu_de_bao_cao);
                    pfd_nguoi_bao_cao.CurrentValues.Clear();
                    pfd_tieu_de_bao_cao.CurrentValues.Clear();
                    pfd_nguoi_bao_cao.ApplyCurrentValues(pv_nguoi_bao_cao);
                    pfd_tieu_de_bao_cao.ApplyCurrentValues(pv_tieu_de_bao_cao);
                    report.RecordSelectionFormula = "{tblNhanVien.sGioiTinh} = 'Nam'";
                    rptNhanVien.ReportSource = report;
                    rptNhanVien.Refresh();
                }
                else if (tieu_de == "Danh sách nhân viên giới tính nữ")
                {
                    report.Load(@"D:\BaosCode\LAP_TRINH_HSK\BTL_HSK\Report\ReportNhanVien\ReportNhanVien.rpt");
                    ParameterFieldDefinition pfd_nguoi_bao_cao = report.DataDefinition.ParameterFields["nguoi_lap_bao_cao"];
                    ParameterFieldDefinition pfd_tieu_de_bao_cao = report.DataDefinition.ParameterFields["tieu_de_bao_cao"];
                    ParameterValues pv_nguoi_bao_cao = new ParameterValues();
                    ParameterValues pv_tieu_de_bao_cao = new ParameterValues();
                    ParameterDiscreteValue pdv_nguoi_bao_cao = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdv_tieu_de_bao_cao = new ParameterDiscreteValue();

                    pdv_nguoi_bao_cao.Value = txtNguoibaocao.Text;
                    pdv_tieu_de_bao_cao.Value = tieu_de;
                    pv_nguoi_bao_cao.Add(pdv_nguoi_bao_cao);
                    pv_tieu_de_bao_cao.Add(pdv_tieu_de_bao_cao);
                    pfd_nguoi_bao_cao.CurrentValues.Clear();
                    pfd_tieu_de_bao_cao.CurrentValues.Clear();
                    pfd_nguoi_bao_cao.ApplyCurrentValues(pv_nguoi_bao_cao);
                    pfd_tieu_de_bao_cao.ApplyCurrentValues(pv_tieu_de_bao_cao);
                    report.RecordSelectionFormula = "{tblNhanVien.sGioiTinh} = 'Nữ'";
                    rptNhanVien.ReportSource = report;
                    rptNhanVien.Refresh();
                }
                else if (tieu_de == "Danh sách nhân viên tại Hà Nội")
                {
                    report.Load(@"D:\BaosCode\LAP_TRINH_HSK\BTL_HSK\Report\ReportNhanVien\ReportDiaChiNhanVien.rpt");
                    ParameterFieldDefinition pfd_nguoi_bao_cao = report.DataDefinition.ParameterFields["nguoi_lap_bao_cao"];
                    ParameterFieldDefinition pfd_tieu_de_bao_cao = report.DataDefinition.ParameterFields["tieu_de_bao_cao"];
                    ParameterValues pv_nguoi_bao_cao = new ParameterValues();
                    ParameterValues pv_tieu_de_bao_cao = new ParameterValues();
                    ParameterDiscreteValue pdv_nguoi_bao_cao = new ParameterDiscreteValue();
                    ParameterDiscreteValue pdv_tieu_de_bao_cao = new ParameterDiscreteValue();

                    pdv_nguoi_bao_cao.Value = txtNguoibaocao.Text;
                    pdv_tieu_de_bao_cao.Value = tieu_de;
                    pv_nguoi_bao_cao.Add(pdv_nguoi_bao_cao);
                    pv_tieu_de_bao_cao.Add(pdv_tieu_de_bao_cao);
                    pfd_nguoi_bao_cao.CurrentValues.Clear();
                    pfd_tieu_de_bao_cao.CurrentValues.Clear();
                    pfd_nguoi_bao_cao.ApplyCurrentValues(pv_nguoi_bao_cao);
                    pfd_tieu_de_bao_cao.ApplyCurrentValues(pv_tieu_de_bao_cao);

                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"tim_dia_chi_nv";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    rptNhanVien.ReportSource = report;
                    rptNhanVien.Refresh();
                }
                rptNhanVien.Zoom(85);
            }
        }

        private void txtNguoibaocao_Validating(object sender, CancelEventArgs e)
        {
            if (txtNguoibaocao.Text.Trim() == String.Empty)
            {
                errorCheck.SetError(txtNguoibaocao, "Không được bỏ trống");
                check = false;
            }
            else
            {
                errorCheck.SetError(txtNguoibaocao, "");
                check = true;
            }
        }
    }
}
