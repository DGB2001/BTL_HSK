using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormReportNhanVien()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"D:\BaosCode\LAP_TRINH_HSK\BTL_HSK\Report\ReportNhanVien.rpt");
            //report.RecordSelectionFormula = "{tblNhanVien.sGioiTinh} = 'Nữ'";
            rptNhanVien.ReportSource = report;
            rptNhanVien.Refresh();
            rptNhanVien.Zoom(85);
        }
    }
}
