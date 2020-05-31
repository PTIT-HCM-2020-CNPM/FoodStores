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
    public partial class FormDanhGia : Form
    {
        public string numCus;
        public FormDanhGia()
        {
            InitializeComponent();
        }
        //Lấy địa chỉ cửa hàng
        public void FillComboBoxCuaHang()
        {
            string query = "select * from dbo.CUA_HANG where [TRẠNG THÁI HOẠT ĐỘNG]=1";
            comboBox_chọn_cửa_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query);

            comboBox_chọn_cửa_hàng.DisplayMember = "ĐỊA CHỈ";
            comboBox_chọn_cửa_hàng.ValueMember = "MÃ CỬA HÀNG";

        }
        
        private void FormDanhGia_Load(object sender, EventArgs e)
        {
            FillComboBoxCuaHang();
        }

        //NÚT ĐÁNH GIÁ
        private void button_đánh_giá_1_Click(object sender, EventArgs e)
        {
            textBox_đánh_giá.Text = textBox_đánh_giá.Text + " " + button_đánh_giá_1.Text.ToString();
        }

        private void button_đánh_giá_2_Click(object sender, EventArgs e)
        {
            textBox_đánh_giá.Text = textBox_đánh_giá.Text + " " + button_đánh_giá_2.Text.ToString();
        }

        private void button_đánh_giá_4_Click(object sender, EventArgs e)
        {
            textBox_đánh_giá.Text = textBox_đánh_giá.Text + " " + button_đánh_giá_4.Text.ToString();
        }

        private void button_đánh_giá_3_Click(object sender, EventArgs e)
        {
            textBox_đánh_giá.Text = textBox_đánh_giá.Text + " " + button_đánh_giá_3.Text.ToString();
        }

        private void button_đánh_giá_5_Click(object sender, EventArgs e)
        {
            textBox_đánh_giá.Text = textBox_đánh_giá.Text + " " + button_đánh_giá_5.Text.ToString();
        }

        //GỬI BÀI ĐÁNH GIÁ
        private void button_đánh_giá_Click(object sender, EventArgs e)
        {
            string numStore="";
            for (int i = 0; i < comboBox_chọn_cửa_hàng.Items.Count; i++)
            {
                if (comboBox_chọn_cửa_hàng.SelectedIndex == i)
                {
                    numStore = comboBox_chọn_cửa_hàng.SelectedValue.ToString();
                }
            }           
            int numCurrent = ReviewDAO.Instance.GetNumberOfRowSQLData(numStore);
            string numReview = numStore + "DG" + (numCurrent + 1).ToString();
            string infReview = textBox_đánh_giá.Text.ToString();
            if (ReviewDAO.Instance.InsertReview(numReview, numStore, numCus, infReview))
            {
                MessageBox.Show("Gửi bài đánh giá thành công! Cảm ơn góp ý của bạn");
            }
            else
            {
                MessageBox.Show("Có lỗi! Không gửi được bài đánh giá!");
            }
        }
    }
}
