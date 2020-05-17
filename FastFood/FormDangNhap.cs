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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                button_đăng_nhập.Enabled = true;
            }
            else { button_đăng_nhập.Enabled = false; }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                button_đăng_nhập.Enabled = true;
            }
            else { button_đăng_nhập.Enabled = false; }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }
        //Điều kiện đăng nhập
        private void button_đăng_nhập_Click(object sender, EventArgs e)
        {
            
            string userName = txtUser.Text;
            string password = txtPass.Text;
            int managerAccess = 1, employeeAccess = 2, customerAccess = 3;

            if (LoginManager(userName,password,managerAccess)) {
                FormNVQL formNVQL = new FormNVQL();
                this.Hide();
                formNVQL.ShowDialog();
                this.Show();
            }
            else if (LoginManager(userName, password, employeeAccess))
            {
                FormNVCH formNVCH = new FormNVCH();
                this.Hide();
                formNVCH.ShowDialog();
                this.Show();
            }
            //khách hàng
            else if (LoginCustomer(userName, password, customerAccess))
            {
                FormKhachHang formKH = new FormKhachHang();
                this.Hide();
                formKH.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu không chính xác!");
            }
        }
        bool LoginManager(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginManager(userName,password, kindAccess);
        }
        bool LoginEmployee(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginEmployee(userName, password, kindAccess);
        }
        bool LoginCustomer(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginCustomer(userName, password, kindAccess);
        }
    }
}
