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
    public partial class FormDangNhap : System.Windows.Forms.Form
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
            //Quản lý
            if (LoginManager(userName,password,managerAccess)) {
                FormNVQL formNVQL = new FormNVQL();
                formNVQL.userName = userName;
                this.Hide();
                formNVQL.ShowDialog();
                this.Show();
            }
            //Nhân viên
            else if (LoginEmployee(userName, password, employeeAccess))
            {
                if (AccountDAO.Instance.CheckLoginStopStore(userName))//check tài khoản thuộc cửa hàng ngừng hoạt động
                {
                    MessageBox.Show("Không thể đăng nhập vì tài khoản thuộc cửa hàng ngừng hoạt đông", "Thông báo", MessageBoxButtons.OK);
                }         
                else {
                    FormNVCH formNVCH = new FormNVCH();
                    // lay tai khoan va mat khau hien tai trong textbox qua cho formNVCH
                    
                    formNVCH.nhan = txtUser.Text;
                    formNVCH.layMatKhauCuFormNVCH = txtPass.Text;
                    this.Hide();
                    formNVCH.ShowDialog();
                    this.Show();
                }
            }

            //khách hàng
            else if (LoginCustomer(userName, password, customerAccess))
            {
                FormKhachHang formKhachHang = new FormKhachHang(userName);
                this.Hide();
                formKhachHang.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu không chính xác!");
            }
            //Lưu mật khẩu:
            if (checkBox_lưu_mật_khẩu.Checked)//nhấn lưu
            {
                Properties.Settings.Default.username = txtUser.Text;
                Properties.Settings.Default.password = txtPass.Text;
                Properties.Settings.Default.Save();
            }
            else//ngược lại không nhấn lưu
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }
        bool LoginManager(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginManager(userName, password, kindAccess);
        }
        bool LoginEmployee(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginEmployee(userName, password, kindAccess);
        }
        bool LoginCustomer(string userName, string password, int kindAccess)
        {
            return AccountDAO.Instance.LoginCustomer(userName, password, kindAccess);
        }

        //Load form lấy dữ liệu tk đã nhớ điền vào tài khoản và mật khẩu
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.username;
            txtPass.Text = Properties.Settings.Default.password;
            if (Properties.Settings.Default.username == "" && Properties.Settings.Default.password == "")
                checkBox_lưu_mật_khẩu.Checked = false;
            else checkBox_lưu_mật_khẩu.Checked = true;
        }

       
       
    }
}
