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
    public partial class NVQLCuaHang : UserControl
    {
        public NVQLCuaHang()
        {
            InitializeComponent();
            LoadStoreList();
        }
        //1.LOAD CỬA HÀNG
        void LoadStoreList()
        {
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select * from dbo.CUA_HANG";


            // đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_cửa_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void dataGridView_cửa_hàng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NVQLCuaHang_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        //2.THÊM CỬA HÀNG

        private void button_thêm_cửa_hàng_Click(object sender, EventArgs e)
        {
            string storeNumber = textBox_mã_cửa_hàng.Text;
            string address = textBox_địa_chỉ.Text;
            int status = 0;
            if (radioButton_hoạt_động.Checked == true)
            {
                status = 1;
            }
            else if (radioButton_ngừng_hoạt_động.Checked == true)
            {
                status = 0;
            }

            if (StoresDAO.Instance.InsertStore(storeNumber,address,status))//Kiểm tra trùng mã nhân viên
            {
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadStoreList();   
            }
            else
            {
                MessageBox.Show("Mã cửa hàng vừa nhập bị trùng lặp! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }


        //3.RESET TRƯỜNG DỮ LIỆU + LOAD BẢNG
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_mã_cửa_hàng.Text = "";
            textBox_địa_chỉ.Text = "";
            radioButton_hoạt_động.Checked = false; radioButton_ngừng_hoạt_động.Checked = false;
            LoadStoreList();
        }

        //4.SỬA CỬA HÀNG
        private void button_sửa_Click(object sender, EventArgs e)
        {
            string storeNumber = textBox_mã_cửa_hàng.Text;
            string address = textBox_địa_chỉ.Text;
            int status = 0;
            if (radioButton_hoạt_động.Checked == true)
            {
                status = 1;
            }
            else if (radioButton_ngừng_hoạt_động.Checked == true)
            {
                status = 0;
            }
            if (StoresDAO.Instance.UpdateStore(storeNumber, address, status))
            {
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadStoreList();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi chỉnh sửa", "Thông báo", MessageBoxButtons.OK);
            }
        }
        //5. TÌM KIẾM CỬA HÀNG
        List<Store> SearchStore(string searchString)
        {
            List<Store> listStore = StoresDAO.Instance.SearchStore(searchString, searchString);
            return listStore;
        }

        private void button_tìm_cửa_hàng_Click(object sender, EventArgs e)
        {
            dataGridView_cửa_hàng.DataSource = SearchStore(textBox_tìm_cửa_hàng.Text);
        }

        //BINDING: CHỌN DÒNG TÀI KHOẢN HIỆN THỊ VÀO TRƯỜNG CÓ SẴN
        private void dataGridView_cửa_hàng_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_cửa_hàng.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox_mã_cửa_hàng.Text = row.Cells[0].Value.ToString();
                textBox_địa_chỉ.Text = row.Cells[1].Value.ToString();

                int status = (int)row.Cells[2].Value;
                if (status == 1)
                {
                    radioButton_hoạt_động.Checked = true;
                }
                else if (status == 0)
                {
                    radioButton_ngừng_hoạt_động.Checked = true;
                }
            }
        }
        
    }
}
