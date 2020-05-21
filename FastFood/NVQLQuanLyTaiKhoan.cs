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

namespace FastFood
{
    public partial class NVQLQuanLyTaiKhoan : UserControl
    {
        public NVQLQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadAcountList();
            AddAccountBinding();
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

        //BINDING: CHỌN DÒNG TÀI KHOẢN HIỆN THỊ VÀO TRƯỜNG CÓ SĂN

        void AddAccountBinding()
        {
            textBox__qltk_tên_tài_khoản.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "Tên tài khoản(mã nhân viên)"));
            textBox_mật_khẩu.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "MẬT KHẨU"));
            textBox_mã_cửa_hàng_tk.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "MÃ CỬA HÀNG"));
            textBox_họ_tên_nhân_viên.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "HỌ TÊN NHÂN VIÊN"));
            textBox_năm_sinh.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "NĂM SINH"));
            textBox_địa_chỉ.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "ĐỊA CHỈ"));
            textBox_số_điện_thoại.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "SỐ ĐIỆN THOẠI"));


            //radioButton_nam.DataBindings.Add(new Binding("Text", dataGridView_tài_khoản.DataSource, "GIỚI TÍNH"));

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
        //

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

            if (InsertEmployee(accountNumber, password, kindAccess,
             numberStore, name, birthYear, gender, address, numberPhone))
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadAcountList();
            }
            
        }
        //

        private void textBox__qltk_tên_tài_khoản_TextChanged(object sender, EventArgs e)
        {
            //string accountNumber = textBox__qltk_tên_tài_khoản.Text;
            //if (AccountDAO.Instance.CheckDuplicateAccount(accountNumber))
            //{
            //    MessageBox.Show("Tên tài khoản vừa nhập bị trùng lặp! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            //}
        }
        //RESET TRƯỜNG DỮ LIỆU
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
            
        }
        //
    }
}
