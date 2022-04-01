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
    }
}
