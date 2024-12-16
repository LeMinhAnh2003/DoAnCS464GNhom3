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
    public partial class frm_DanhMuc : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_DanhMuc()
        {
            InitializeComponent();
            LoadDM();
        }

        public void LoadDM()
        {
            string sql = "select * from DANHMUCMONAN";
            dgv_DanhMuc.DataSource = LopDungChung.LoadDL(sql);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "insert into DANHMUCMONAN values ('" + txt_MaDanhMuc.Text + "', N'" + txt_TenDanhMuc.Text + "')";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadDM();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update DANHMUCMONAN set TENDANHMUC = N'" + txt_TenDanhMuc.Text + "' where MADANHMUC = '" + txt_MaDanhMuc.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadDM();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete DANHMUCMONAN where MADANHMUC ='" + txt_MaDanhMuc.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã xóa!");
            else MessageBox.Show("Thất bại!");
            LoadDM();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDanhMuc.Text = dgv_DanhMuc.CurrentRow.Cells[0].Value.ToString();
            txt_TenDanhMuc.Text = dgv_DanhMuc.CurrentRow.Cells["TENDANHMUC"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
