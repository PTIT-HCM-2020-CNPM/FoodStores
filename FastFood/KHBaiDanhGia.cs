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
    
    public partial class KHBaiDanhGia : UserControl
    {
        public string customerNumber;
        public KHBaiDanhGia()
        {
            InitializeComponent();
        }
        //LOAD DANH SÁCH BÀI DÁNH GIÁ
        private void KHBaiDanhGia_Load(object sender, EventArgs e)
        {
            LoadBDG();
        }
        public void LoadBDG()
        {
            try
            {
                dataGridView_bài_đánh_giá.DataSource = ReviewDAO.Instance.GetReview(customerNumber);
            }
            catch
            {
                MessageBox.Show("Không thể load bài đánh giá!");
            }
        }

        private void button_tìm_kiếm_Click(object sender, EventArgs e)
        {
            string strSearch = textBox_tìm_kiếm.Text.ToString();
            dataGridView_bài_đánh_giá.DataSource = ReviewDAO.Instance.SearchReview(customerNumber,strSearch);
            if (dataGridView_bài_đánh_giá.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bài đánh giá nào!");
            }
        }
    }

}
