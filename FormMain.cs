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
            //timer1.Stop();
            //if (MessageBox.Show("Bạn đã hoạt động " + label3.Text + " giây", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMuaHang formMuaHang = new FormMuaHang();
            panelMain.Show();
            panelMain.Controls.Clear();
            formMuaHang.TopLevel = false;
            formMuaHang.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formMuaHang);
            formMuaHang.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            FormMuaHang formMuaHang = new FormMuaHang();
            panelMain.Show();
            panelMain.Controls.Clear();
            formMuaHang.TopLevel = false;
            formMuaHang.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formMuaHang);
            formMuaHang.Show();
        }

        private void đơnNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonNhapKho formDonNhapKho = new FormDonNhapKho();
            panelMain.Show();
            panelMain.Controls.Clear();
            formDonNhapKho.TopLevel = false;
            formDonNhapKho.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formDonNhapKho);
            formDonNhapKho.Show();
        }
        //int i = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    i++;
        //    label3.Text = i.ToString();
        //}
    }
}
