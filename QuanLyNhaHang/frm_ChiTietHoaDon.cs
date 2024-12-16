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
    public partial class frm_ChiTietHoaDon : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
            LoadHD();
        }

        public void LoadHD()
        {
            string sql = "select * from CTHOADON";
            dgv_ChiTietHoaDon.DataSource = LopDungChung.LoadDL(sql);
        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string sql = "select * from MONAN";
            cb_Mon.DataSource = LopDungChung.LoadDL(sql);
            cb_Mon.DisplayMember = "TENMON";
            cb_Mon.ValueMember = "MAMON";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "insert into CTHOADON values ('" + txt_MaHoaDon.Text + "', '" + cb_Mon.SelectedValue + "', '" + txt_SoLuong.Text + "')";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadHD();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "UpdateCTHOADON set MAMON = '" + cb_Mon.SelectedValue + "', SOLUONG = '" + txt_SoLuong.Text + "' where MAHD = '" + txt_MaHoaDon.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadHD();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete CTHOADON where MAHD ='" + txt_MaHoaDon.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa thất bại!");
            LoadHD();
        }

        private void dgv_ChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHoaDon.Text = dgv_ChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
            cb_Mon.SelectedValue = dgv_ChiTietHoaDon.CurrentRow.Cells["MAMON"].Value.ToString();
            txt_SoLuong.Text = dgv_ChiTietHoaDon.CurrentRow.Cells["SOLUONG"].Value.ToString();
        }

        private void dgv_ChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
