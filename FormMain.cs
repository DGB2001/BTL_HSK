using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            panelMain.Show();
            panelMain.Controls.Clear();
            formNhanVien.TopLevel = false;
            formNhanVien.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formNhanVien);
            formNhanVien.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
            panelMain.Show();
            panelMain.Controls.Clear();
            formNhaCungCap.TopLevel = false;
            formNhaCungCap.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formNhaCungCap);
            formNhaCungCap.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReportNhanVien formReportNhanVien = new FormReportNhanVien();
            panelMain.Show();
            panelMain.Controls.Clear();
            formReportNhanVien.TopLevel = false;
            formReportNhanVien.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formReportNhanVien);
            formReportNhanVien.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            panelMain.Show();
            panelMain.Controls.Clear();
            formKhachHang.TopLevel = false;
            formKhachHang.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formKhachHang);
            formKhachHang.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatHang formMatHang = new FormMatHang();
            panelMain.Show();
            panelMain.Controls.Clear();
            formMatHang.TopLevel = false;
            formMatHang.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formMatHang);
            formMatHang.Show();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonDatHang formDonDatHang = new FormDonDatHang();
            panelMain.Show();
            panelMain.Controls.Clear();
            formDonDatHang.TopLevel = false;
            formDonDatHang.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formDonDatHang);
            formDonDatHang.Show();
        }
    }
}
