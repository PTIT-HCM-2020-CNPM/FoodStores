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

namespace FastFood
{
    public partial class NVQLMatKhau : UserControl
    {
        public string userName;
        public NVQLMatKhau()
        {
            InitializeComponent();
        }

        private void textBox_mật_khẩu_cũ_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_mật_khẩu_cũ.Text == "")
            //{
            //    MessageBox.Show("Mời nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        private void textBox_mật_khẩu_mới_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_mật_khẩu_mới.Text == "")
            //{
            //    MessageBox.Show("Mời nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        private void textBox_nhập_lại_mật_khẩu_mới_TextChanged(object sender, EventArgs e)
        {
            //if (textBox_nhập_lại_mật_khẩu_mới.Text == "")
            //{
            //    MessageBox.Show("Mời nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK);
            //}
        }
        //Đổi mật khẩu tài khoản nhân viên quản lý
        private void button_Luu_Click(object sender, EventArgs e)
        {
            string oldPass = textBox_mật_khẩu_cũ.Text;
            string newPass = textBox_mật_khẩu_mới.Text;
            string reEnterPass = textBox_nhập_lại_mật_khẩu_mới.Text;

            if (oldPass.Equals(""))
            {
                MessageBox.Show("Mật khẩu hiện tại không được để trống!");
            }
            else if (newPass.Equals(""))
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Thông báo");
            }
            else if (reEnterPass.Equals(""))
            {
                MessageBox.Show("Nhập lại mật khẩu mới không được để trống!", "Thông báo");
            }
            else if (!newPass.Equals(reEnterPass))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới");
            }
            else if (oldPass.Equals(newPass))
            {
                MessageBox.Show("Mật khẩu mới trùng mới mật khẩu hiện tại! Vui lòng điền mật khẩu mới khác!");
            }           
            else
            {
                if (AccountDAO.Instance.updatePassCustomer(userName, oldPass, newPass))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!");

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu hiện tại!");
                }
            }
        }
    }
}
