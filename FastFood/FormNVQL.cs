using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormNVQL : Form
    {
        public FormNVQL()
        {
            InitializeComponent();
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.BringToFront();
        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.BringToFront();
        }

        private void button_tạo_tài_khoản_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_tạo_tài_khoản.Height;
            panel_chọn.Top = button_tạo_tài_khoản.Top;
            nvqlQuanLyTaiKhoan1.BringToFront();
        }

        private void button_đơn_hàng_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_đơn_hàng.Height;
            panel_chọn.Top = button_đơn_hàng.Top;
            nvqlDonHang1.BringToFront();
        }

        private void button_cửa_hàng_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_cửa_hàng.Height;
            panel_chọn.Top = button_cửa_hàng.Top;
            nvqlCuaHang1.BringToFront();
        }

        private void button_doanh_thu_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_doanh_thu.Height;
            panel_chọn.Top = button_doanh_thu.Top;
            nvqlDoanhThu1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_chọn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNVQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void hinhtrangchu1_Load(object sender, EventArgs e)
        {

        }

        private void nvqlCuaHang1_Load(object sender, EventArgs e)
        {

        }

        private void nvqlDonHang1_Load(object sender, EventArgs e)
        {

        }
    }
}
