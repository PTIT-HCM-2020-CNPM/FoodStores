using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.DAL_DataLayer;
using FastFood.DTO_DataTranferObject;

namespace FastFood
{
    public partial class NVCHTaiKhoan : UserControl
    {
        public NVCHTaiKhoan()
        {
            InitializeComponent();
        }
        string taiKhoan;
        public string layTaiKhoanHienTai
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }

        private void TextBox_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Luu_Click(object sender, EventArgs e)
        {
            string matKhauMoi = textBox_MatKhauMoi.Text;
            string nhapLaiMatKhau = textBox_NhapLaiMatKhaiMoi.Text;

            if (matKhauMoi == nhapLaiMatKhau)
            {
                if (MessageBox.Show("Bạn đồng ý thay đổi !", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (AccountDAO.Instance.doiMatKhauNhanVienCuaHang(taiKhoan, matKhauMoi))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK);
                    }
                }

            }
        }
    }
}
