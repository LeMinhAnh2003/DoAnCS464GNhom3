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
    public partial class frm_DangNhap : Form
    {
        LopDungChung LopDungChung = new LopDungChung();
        int dem = 0; 
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "select COUNT(*) from TAIKHOAN where TENTAIKHOAN = '" + txt_TaiKhoan.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = Convert.ToInt32(LopDungChung.LayGT(sql));
            if (kq >= 1)
            {
                frm_Main form1 = new frm_Main();
                form1.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu " + dem.ToString() + " lần");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn nhập sai quá 3 lần, hệ thống sẽ thoát");
                    Application.Exit();

                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ck_MatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_MatKhau.Checked == true)
                txt_MatKhau.UseSystemPasswordChar = false;
            else txt_MatKhau.UseSystemPasswordChar = true;
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
