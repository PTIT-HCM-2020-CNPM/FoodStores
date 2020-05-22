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
    public partial class FormNVCH : Form
    {
        
        public FormNVCH()
        {
            InitializeComponent();
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.BringToFront();
        }
        // ham lay du lieu taikhoan dang nhap tu ben formdangnhap de xac dinh Cua hang dang dang nhap vao
        string taiKhoan;
        public string nhan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.BringToFront();
            
        }

        private void button_tạo_tài_khoản_Click(object sender, EventArgs e)
        {
            
        }

        private void button_món_ăn_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_món_ăn.Height;
            panel_chọn.Top = button_món_ăn.Top;
            // lay cua hang hien tai dang dang nhap qua usercontrol danhsachmonan
            nvchDanhSachMonAn1.layCuaHangHienTai = taiKhoan.Substring(0,3);
            nvchDanhSachMonAn1.BringToFront();         
        }

        private void button_đơn_hàng_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_đơn_hàng.Height;
            panel_chọn.Top = button_đơn_hàng.Top;
        }

        private void button_tài_khoản_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_tài_khoản.Height;
            panel_chọn.Top = button_tài_khoản.Top;
        }

        private void Hinhtrangchu1_Load(object sender, EventArgs e)
        {

        }

        private void NvchDanhSachMonAn1_Load(object sender, EventArgs e)
        {

        }
    }
}
