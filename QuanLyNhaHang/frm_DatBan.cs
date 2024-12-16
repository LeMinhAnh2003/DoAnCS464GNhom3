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
    public partial class frm_DatBan : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        public frm_DatBan()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            string sql = "select * from SOBAN";
            dgv_DatBan.DataSource = LopDungChung.LoadDL(sql);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "insert into SOBAN values ('" + txt_MaBan.Text + "', N'" + txt_TenBan.Text + "',N'" + cb_TrangThai.SelectedItem + "')";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Thêm thất bại!");
            LoadDB();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SOBAN seT TENBAN = N'" + txt_TenBan.Text + "', TRANGTHAI = N'" + cb_TrangThai.SelectedItem + "' where MABAN = '" + txt_MaBan.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Sửa thất bại!");
            LoadDB();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete SOBAN where MABAN ='" + txt_MaBan.Text + "'";
            int kq = LopDungChung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa thành công!");
            else MessageBox.Show("Xóa thất bại!");
            LoadDB();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_DatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaBan.Text = dgv_DatBan.CurrentRow.Cells[0].Value.ToString();
            txt_TenBan.Text = dgv_DatBan.CurrentRow.Cells["TENBAN"].Value.ToString();
            cb_TrangThai.SelectedItem = dgv_DatBan.CurrentRow.Cells["TRANGTHAI"].Value.ToString();
        }

        private void frm_DatBan_Load(object sender, EventArgs e)
        {

        }
    }
}
