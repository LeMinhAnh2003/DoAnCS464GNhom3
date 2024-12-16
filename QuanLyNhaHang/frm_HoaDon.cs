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
    public partial class frm_HoaDon : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_HoaDon()
        {
            InitializeComponent();
            LoadHD();
        }

        public void LoadHD()
        {
            string sql = "select * from HOADON";
            dgv_HoaDon.DataSource = LopDungChung.LoadDL(sql);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HOADON SET NGAYVAO = '" + dt_NgayVao.Value + "' WHERE MAHD = '" + txt_MaHoaDon.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadHD();
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon form1 = new frm_ChiTietHoaDon();
            form1.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete HOADON where MAHD ='" + txt_MaHoaDon.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa thất bại!");
            LoadHD();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHoaDon.Text = dgv_HoaDon.CurrentRow.Cells[0].Value.ToString();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            string sql = "select * from SOBAN";
        }
    }
}
