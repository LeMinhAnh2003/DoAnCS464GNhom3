using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void tấtCảMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_MonAn"] == null)
            {
                frm_MonAn ma = new frm_MonAn();
                ma.MdiParent = this;
                ma.Show();
            }
            else Application.OpenForms["frm_MonAn"].Activate();
        }

        private void danhSáchThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhMuc"] == null)
            {
                frm_DanhMuc dm = new frm_DanhMuc();
                dm.MdiParent = this;
                dm.Show();
            }
            else Application.OpenForms["frm_DanhMuc"].Activate();
        }

        private void hóaĐơnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoaDon"] == null)
            {
                frm_HoaDon hd = new frm_HoaDon();
                hd.MdiParent = this;
                hd.Show();
            }
            else Application.OpenForms["frm_HoaDon"].Activate();
        }

        private void đặtBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DatBan"] == null)
            {
                frm_DatBan db = new frm_DatBan();
                db.MdiParent = this;
                db.Show();
            }
            else Application.OpenForms["frm_DatBan"].Activate();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThongKe"] == null)
            {
                frm_ThongKe tk = new frm_ThongKe();
                tk.MdiParent = this;
                tk.Show();
            }
            else Application.OpenForms["frm_ThongKe"].Activate();
        }
    }
}
