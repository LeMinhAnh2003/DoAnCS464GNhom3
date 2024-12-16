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
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_Thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            dgv_Thongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động giãn cột
            dgv_Thongke.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;  // Tự động giãn hàng

            // dgv_Thongke.ScrollBars = ScrollBars.None; // Tắt thanh cuộn nếu không cần thiết
            // dgv_Thongke.Dock = DockStyle.Fill;
        }
    }
}
