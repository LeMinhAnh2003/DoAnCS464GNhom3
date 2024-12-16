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
    public partial class frm_MonAn : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_MonAn()
        {
            InitializeComponent();
            LoadMA();
        }

        public void LoadMA()
        {
            string sql = "select * from MONAN";
            dgv_DanhSach.DataSource = LopDungChung.LoadDL(sql);
        }

        private void frm_MonAn_Load(object sender, EventArgs e)
        {
            string sql = "select * from DANHMUCMONAN";
            cb_DanhMuc.DataSource = LopDungChung.LoadDL(sql);
            cb_DanhMuc.DisplayMember = "TENDANHMUC";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into MONAN values ('" + txt_TenMon.Text + "', N'" + txt_TenMon.Text + "', '" + cb_DanhMuc.SelectedValue + "', '" + txt_DongGia.Text + "')";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadMA();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update MONAN set TENMON = '" + txt_TenMon.Text + "',MADANHMUC = '" + cb_DanhMuc.SelectedValue + "', GIA = '" + txt_DongGia.Text + "' where MAMON = '" + txt_DongGia.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadMA();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete MONAN where MAMON ='" + txt_MaMon.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa thất bại!");
            LoadMA();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_danhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dgv_DanhSach.CurrentRow.Cells[0].Value.ToString();
            txt_TenMon.Text = dgv_DanhSach.CurrentRow.Cells["TENMON"].Value.ToString();
            cb_DanhMuc.SelectedValue = dgv_DanhSach.CurrentRow.Cells["MADANHMUC"].Value.ToString();
            txt_DongGia.Text = dgv_DanhSach.CurrentRow.Cells["GIA"].Value.ToString();
        }
        private void dgv_danhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dgv_DanhSach.CurrentRow.Cells[0].Value.ToString();
            txt_TenMon.Text = dgv_DanhSach.CurrentRow.Cells["TENMON"].Value.ToString();
            cb_DanhMuc.SelectedValue = dgv_DanhSach.CurrentRow.Cells["MADANHMUC"].Value.ToString();
            txt_DongGia.Text = dgv_DanhSach.CurrentRow.Cells["GIA"].Value.ToString();
        }

        private void dgv_danhsach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_DanhSach.ForeColor = Color.Black;
        }
    }
}
