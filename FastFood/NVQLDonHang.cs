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
    public partial class NVQLDonHang : UserControl
    {
        public NVQLDonHang()
        {
            InitializeComponent();
            LoadBillList();
        }

        ////LOAD ĐƠN HÀNG
        void LoadBillList()
        {

            dataGridView_đơn_hàng.DataSource = DataProvider.Instance.ExecuteQuery("select * from  DON_DAT_HANG");
        }

        ////BINDING: CHỌN DÒNG TÀI KHOẢN HIỆN THỊ VÀO TRƯỜNG CÓ SẴN
        private void DataGridView_đơn_hàng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_đơn_hàng_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_đơn_hàng.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBox_mã_đơn_hàng.Text = row.Cells[0].Value.ToString();
                textBox_mã_cửa_hàng.Text = row.Cells[1].Value.ToString();
                textBox_mã_nhân_viên.Text = row.Cells[2].Value.ToString();
                textBox_mã_khách_hàng.Text = row.Cells[3].Value.ToString();
                textBox_tổng_tiền.Text = row.Cells[4].Value.ToString();
                textBox_ngày.Text = row.Cells[5].Value.ToString();
                textBox_địa_chỉ.Text = row.Cells[6].Value.ToString();
                
                int status = (int)row.Cells[7].Value;
                if (status == 1)
                {
                    radioButton_giao_hàng.Checked = true;
                }
                else if (status == 2)
                {
                    radioButton_đang_giao.Checked = true;
                }
                else if (status == 3)
                {
                    radioButton_lấy_trực_tiếp.Checked = true;
                }


                //Nhấn chọn hóa đơn hiện chi tiết hóa đơn  
                string billNumber = row.Cells[0].Value.ToString();

                    string query = "USP_SelectBill @madonhang";

                    dataGridView_chi_tiết_đơn_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { billNumber });
                    
                


            }
        }
        ///

        ///TÌM KIẾM ĐƠN HÀNG
        List<Bill> SearchBillList(string searchString)
        {
            List<Bill> listAccount = BillDAO.Instance.SearchBill(searchString);
            return listAccount;
        }

        private void button_tìm_đơn_hàng_Click(object sender, EventArgs e)
        {
            dataGridView_đơn_hàng.DataSource = SearchBillList(textBox_tìm_đơn_hàng.Text);

        }

        ///


    }
}
