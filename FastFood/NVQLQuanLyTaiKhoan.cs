using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FastFood.DAL_DataLayer;
using FastFood.DTO_DataTranferObject;

namespace FastFood
{
    public partial class NVQLQuanLyTaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();
        public NVQLQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadAcountList();
            //AddAccountBinding();
        }

        //LOAD TÀI KHOẢN NHÂN VIÊN
        void LoadAcountList()
        {
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select t.[TÊN TÀI KHOẢN] as [TÊN TÀI KHOẢN(MÃ NHÂN VIÊN)],t.[MẬT KHẨU] as [MẬT KHẨU],n.[MÃ CỬA HÀNG] as [MÃ CỬA HÀNG],n.[HỌ TÊN NHÂN VIÊN] as [HỌ TÊN NHÂN VIÊN]," +
                "n.[NĂM SINH] as [NĂM SINH],n.[GIỚI TÍNH] as [GIỚI TÍNH],n.[ĐỊA CHỈ] as [ĐỊA CHỈ],n.[SỐ ĐIỆN THOẠI] as [SỐ ĐIỆN THOẠI]" +
                "from TAI_KHOAN as t , NHAN_VIEN as n " +
                "where t.[TÊN TÀI KHOẢN] = n.[MÃ NHÂN VIÊN]" +
                "and t.[LOẠI TRUY CẬP]=2";

            //đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_tài_khoản.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        ////////////////

        //BINDING: CHỌN DÒNG TÀI KHOẢN HIỆN THỊ VÀO TRƯỜNG CÓ SẴN

        void AddAccountBinding()
        {
            textBox__qltk_tên_tài_khoản.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "TÊN TÀI KHOẢN(MÃ NHÂN VIÊN)", true, DataSourceUpdateMode.Never));
            textBox_mật_khẩu.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "MẬT KHẨU", true, DataSourceUpdateMode.Never));
            textBox_mã_cửa_hàng_tk.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "MÃ CỬA HÀNG", true, DataSourceUpdateMode.Never));
            textBox_họ_tên_nhân_viên.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "HỌ TÊN NHÂN VIÊN", true, DataSourceUpdateMode.Never));
            textBox_năm_sinh.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "NĂM SINH", true, DataSourceUpdateMode.Never));
            textBox_địa_chỉ.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "ĐỊA CHỈ", true, DataSourceUpdateMode.Never));
            textBox_số_điện_thoại.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "SỐ ĐIỆN THOẠI", true, DataSourceUpdateMode.Never));

        }

        private void dataGridView_tài_khoản_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_tài_khoản_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_tài_khoản.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox__qltk_tên_tài_khoản.Text = row.Cells[0].Value.ToString();
                textBox_mật_khẩu.Text = row.Cells[1].Value.ToString();
                textBox_mã_cửa_hàng_tk.Text = row.Cells[2].Value.ToString();
                textBox_họ_tên_nhân_viên.Text = row.Cells[3].Value.ToString();
                textBox_năm_sinh.Text = row.Cells[4].Value.ToString();
                textBox_địa_chỉ.Text = row.Cells[6].Value.ToString();
                textBox_số_điện_thoại.Text = row.Cells[7].Value.ToString();
                string gender = row.Cells[5].Value.ToString();
                if (gender == "Nam")
                {
                    radioButton_nam.Checked = true;
                }
                else if (gender == "Nữ")
                {
                    radioButton_nữ.Checked = true;
                }
            }
        }
        ///////////////////

        //THÊM TÀI KHOẢN NHÂN VIÊN: Thêm tài khoản -> thêm nhân viên

        public bool InsertEmployee(string accountName, string password, int kindAccess,
             string numberStore, string name, int birthYear, string gender, string address, string numberPhone)
        {
            bool result = false;
            if (AccountDAO.Instance.InsertAccoutEmployee(accountName, password, kindAccess))
            {
                result = AccountDAO.Instance.InsertEmployee(accountName, numberStore, name, birthYear, gender, address, numberPhone);
            }
            return result;
        }
        private void button_thêm_tài_khoản_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox__qltk_tên_tài_khoản.Text;
            string password = textBox_mật_khẩu.Text;
            int kindAccess = 2;
            string numberStore = textBox_mã_cửa_hàng_tk.Text;
            string name = textBox_họ_tên_nhân_viên.Text;
            int birthYear = Convert.ToInt32(textBox_năm_sinh.Text);
            string gender="";
            if (radioButton_nam.Checked == true)
            {
                gender = radioButton_nam.Text;
            }
            else if (radioButton_nữ.Checked == true)
            {
                gender = radioButton_nữ.Text;
            }
            string address = textBox_địa_chỉ.Text;
            string numberPhone = textBox_số_điện_thoại.Text;

            if (AccountDAO.Instance.CheckDuplicateAccount(accountNumber))//Kiểm tra trùng mã nhân viên
            {
                MessageBox.Show("Tên tài khoản vừa nhập bị trùng lặp! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }

            else if (InsertEmployee(accountNumber, password, kindAccess,
             numberStore, name, birthYear, gender, address, numberPhone))
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAcountList();
            }
            
        }
        ////////////////

        private void textBox__qltk_tên_tài_khoản_TextChanged(object sender, EventArgs e)
        {
            //string accountNumber = textBox__qltk_tên_tài_khoản.Text;
            //if (AccountDAO.Instance.CheckDuplicateAccount(accountNumber))
            //{
            //    MessageBox.Show("Tên tài khoản vừa nhập bị trùng lặp! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        //RESET TRƯỜNG DỮ LIỆU + LOAD BẢNG
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox__qltk_tên_tài_khoản.Text = null;
            textBox_mật_khẩu.Text = null;
            textBox_mã_cửa_hàng_tk.Text = null;
            textBox_họ_tên_nhân_viên.Text = null;
            textBox_năm_sinh.Text = null;
            radioButton_nam.Checked = false; radioButton_nữ.Checked = false;
            textBox_địa_chỉ.Text = null;
            textBox_số_điện_thoại.Text = null;
            LoadAcountList();
        }
        ///////////////
        
        //CHỈNH SỬA THÔNG TIN NHÂN VIÊN: 
        public bool EditEmployee(string accountName, string password, int kindAccess,
             string numberStore, string name, int birthYear, string gender, string address, string numberPhone)
        {
            bool result = false;
            if (AccountDAO.Instance.UpdateAccountEmployee(accountName, password))
            {
                result = AccountDAO.Instance.UpdateEmployee(accountName, numberStore, name, birthYear, gender, address, numberPhone);
            }
            return result;
        }
        private void button_sửa_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox__qltk_tên_tài_khoản.Text;
            string password = textBox_mật_khẩu.Text;
            int kindAccess = 2;
            string numberStore = textBox_mã_cửa_hàng_tk.Text;
            string name = textBox_họ_tên_nhân_viên.Text;
            int birthYear = Convert.ToInt32(textBox_năm_sinh.Text);
            string gender = "";
            if (radioButton_nam.Checked == true)
            {
                gender = radioButton_nam.Text;
            }
            else if (radioButton_nữ.Checked == true)
            {
                gender = radioButton_nữ.Text;
            }
            string address = textBox_địa_chỉ.Text;
            string numberPhone = textBox_số_điện_thoại.Text;

            
            if (EditEmployee(accountNumber, password, kindAccess,
             numberStore, name, birthYear, gender, address, numberPhone))
            {
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAcountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi chỉnh sửa", "Thông báo", MessageBoxButtons.OK);
            }

        }
        ///////////
        
        //XÓA NHÂN VIÊN
        private void button_xóa_Click(object sender, EventArgs e)
        {
            string employeeNumber = textBox__qltk_tên_tài_khoản.Text;

            if (AccountDAO.Instance.DeleteAccountEmployee(employeeNumber))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAcountList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //TÌM GẦN ĐÚNG TÀI KHOẢN
        List<EmployeeAccount> SearchAcountByName (string employeeNumber)
        {
            List<EmployeeAccount> listAccount = AccountDAO.Instance.SearchAccountByName(employeeNumber);
            return listAccount;
        }

        private void button_tìm_tài_khoản_Click(object sender, EventArgs e)
        {
            dataGridView_tài_khoản.DataSource= SearchAcountByName(textBox_tìm_tài_khoản.Text);
            
        }
    }
}
