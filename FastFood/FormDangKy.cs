using FastFood.DAL_DataLayer;
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
    public partial class FormDangKy : System.Windows.Forms.Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()!=""&&txtNumberPhone.Text.Trim()!=""&&txtPass.Text.Trim()!=""&&txtRePass.Text.Trim()!="")
            {
                btnRegis.Enabled = true;

            }
            else { btnRegis.Enabled = false; }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void txtRePass_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        //ĐĂNG KÝ KHÁCH HÀNG
        private void btnRegis_Click(object sender, EventArgs e)
        {
            string accountName = txtNumberPhone.Text;
            string userName = txtName.Text;
            string password = txtPass.Text;
            string rePassword =txtRePass.Text;
            int kindAccess = 3;

            //Thông báo đăng ký
            /*Kiểm tra nhập lại mật khẩu*/
            if (password != rePassword)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!","Thông báo", MessageBoxButtons.OK);

            }
            else if (SignUpCustomer(accountName, userName, password, kindAccess) && password == rePassword /*Kiểm tra nhập lại mật khẩu*/) 
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp! Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã có người sử dụng", "Thông báo", MessageBoxButtons.OK);
            }
        }
        bool SignUpCustomer(string accountName, string userName, string password, int kindAccess)
        {
            bool result1 = AccountDAO.Instance.SignUpAccoutCustomer(accountName, password, kindAccess);
            bool result2 = false;
            if (result1 == true)
            {
                result2 = AccountDAO.Instance.SignUpCustomer(accountName, userName);
            }
            return result2;
        }


        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

    }
}
