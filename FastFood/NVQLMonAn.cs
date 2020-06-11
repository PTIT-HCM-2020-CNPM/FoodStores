using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FastFood.DAL_DataLayer;

namespace FastFood
{
    public partial class NVQLMonAn : UserControl
    {
        private string foodNum;
        public NVQLMonAn()
        {
            InitializeComponent();
        }
        private void textBox_giá_tiền_TabIndexChanged(object sender, EventArgs e)
        {
            if (FoodDAO.Instance.CheckDuplicate(foodNum))
            {
                MessageBox.Show("Mã món ăn vừa nhập đã tồn tại");
            }
        }
        //thêm món ăn + món ăn cửa hàng
        private void button_thêm_Click(object sender, EventArgs e)
        {           
            foodNum = textBox_mã_món_ăn.Text;
            string foodName = textBox_tên_món_ăn.Text;
            string imgName = textBox_hình_ảnh.Text;
            int price = 0; int amount = 30;
            bool successed=Int32.TryParse(textBox_giá_tiền.Text, out price);           
            if (!successed)
            {
                MessageBox.Show("Giá tiền cần là giá trị số!");
            }
            else if(FoodDAO.Instance.InsertFood(foodNum,foodName,price,imgName))
            {
                DataTable table = StoresDAO.Instance.SelectFoodNum();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    string idStore = row["MÃ CỬA HÀNG"].ToString();
                    
                    FoodDAO.Instance.InsertFoodStore(idStore, foodNum, amount);
                }
                MessageBox.Show("Thêm món ăn thành công");
                LoadFoodList();
            }
        }
        //Load bảng món ăn
        public void LoadFoodList()
        {
            dataGridView_món_ăn.DataSource = FoodDAO.Instance.GetFood();
        }
        private void NVQLThemMonAn_Load(object sender, EventArgs e)
        {
            LoadFoodList();
        }
        //Chọn dữ liệu trong bảng
        private void dataGridView_món_ăn_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_món_ăn.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox_mã_món_ăn.Text = row.Cells[0].Value.ToString();
                foodNum = row.Cells[0].Value.ToString();
                textBox_tên_món_ăn.Text = row.Cells[1].Value.ToString();
                textBox_giá_tiền.Text = row.Cells[2].Value.ToString();
                textBox_hình_ảnh.Text = row.Cells[3].Value.ToString();                              
            }
        }
        //Sửa dữ liệu món ăn
        private void button_sửa_Click(object sender, EventArgs e)
        {
            string foodNumNew = textBox_mã_món_ăn.Text;
            string foodName = textBox_tên_món_ăn.Text;
            string imgName = textBox_hình_ảnh.Text;
            int price = 0;int amount = 30;
            bool successed = Int32.TryParse(textBox_giá_tiền.Text, out price);
            if (!successed)
            {
                MessageBox.Show("Giá tiền cần là giá trị số");
            }
            DataTable table = StoresDAO.Instance.SelectFoodNum();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string idStore = row["MÃ CỬA HÀNG"].ToString();

                FoodDAO.Instance.DeleteFoodStore(idStore, foodNum);
            }
            if (FoodDAO.Instance.UpdateFood(foodNumNew, foodName, price, imgName,foodNum))
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    string idStore = row["MÃ CỬA HÀNG"].ToString();

                    FoodDAO.Instance.InsertFoodStore(idStore, foodNumNew, amount);
                }
                MessageBox.Show("Chỉnh sửa món ăn thành công");
                LoadFoodList();
            }
        }
        //Reset dữ liệu
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_mã_món_ăn.Text = "";
            textBox_tên_món_ăn.Text = "";
            textBox_giá_tiền.Text = "";
            LoadFoodList();
        }
        //Tìm kiếm món ăn
        private void button_tìm_Click(object sender, EventArgs e)
        {
            string strSearch=textBox_tìm_món_ăn.Text;
            if (FoodDAO.Instance.GetFoodBySearch(strSearch).Rows.Count < 0)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            else
            {
                dataGridView_món_ăn.DataSource = FoodDAO.Instance.GetFoodBySearch(strSearch);
            }
        }
    }
}
