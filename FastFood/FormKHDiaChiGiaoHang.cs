using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Utils.Animation;
using FastFood.DAL_DataLayer;

namespace FastFood
{
    public partial class FormKHDiaChiGiaoHang : System.Windows.Forms.Form
    {
        public int totalPayment;
        public FormKHDiaChiGiaoHang(string numberPhone)
        {
            InitializeComponent();
            //Lấy sđt từ form giỏ hàng->form xác nhận
            textBox_số_điện_thoại.Text = numberPhone;
            //Phí giao hàng
            feeDelivery();
            //Lấy tổng tiền từ giỏ hàng->form xác nhận
            textBox_tổng_tiền.Text = ( Convert.ToInt32(totalPayment.ToString()) + Convert.ToInt32(textBox_phí.Text.ToString()) ).ToString();           
            //
            FillComboBoxCuaHang();
        }
        //Phí giao hàng
        private void feeDelivery()
        {
            if (radioButton_giao_hàng.Checked == true)
            {
               textBox_phí.Text = "15000";
            }
            else
            {
                textBox_phí.Text = "0";
            }
        }
        //Load combo box cửa hàng
        public void FillComboBoxCuaHang()
        {
            string query = "select * from dbo.CUA_HANG where [TRẠNG THÁI HOẠT ĐỘNG]=1";
            comboBox_chọn_cửa_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query);

            comboBox_chọn_cửa_hàng.DisplayMember = "ĐỊA CHỈ";
            comboBox_chọn_cửa_hàng.ValueMember = "MÃ CỬA HÀNG";

        }
        
        private void FormKHDiaChiGiaoHang_Load(object sender, EventArgs e)
        {
            
        }
        //
        //Thêm đơn hàng tử khách hàng
        private void button_xác_nhận_Click(object sender, EventArgs e)
        {
            string storeNumber = comboBox_chọn_cửa_hàng.SelectedValue.ToString();
            int numBillCurent = BillDAO.Instance.GetNumberOfRowSQLData(storeNumber);
            string customerNumber = textBox_số_điện_thoại.Text;
            string billNumber = storeNumber + "DH" + (numBillCurent+1).ToString();
            int totalBill = Convert.ToInt32(textBox_tổng_tiền.Text);
            DateTime dateNow = DateTime.Now;
            string address = textBox_địa_chỉ_giao_hàng.Text;
            string date = dateNow.ToString("yyyy/MM/dd");
            int kindBill = 0;
            if (textBox_địa_chỉ_giao_hàng.Text == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (radioButton_giao_hàng.Checked == false && radioButton_lấy_trực_tiếp.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn hình thức đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BillDAO.Instance.InsertBillByCustomer(billNumber, storeNumber, customerNumber, totalBill, date, address, kindBill))
            {
                string foodNam;
                int foodMount;
                foreach (DataGridViewRow row in dataGridView_đơn_hàng.Rows)
                {
                    foodNam= dataGridView_đơn_hàng.Rows[row.Index].Cells[0].Value.ToString();
                    foodMount = Convert.ToInt32(dataGridView_đơn_hàng.Rows[row.Index].Cells[1].Value.ToString());
                    BillDAO.Instance.InsertBillIfByCus(billNumber, foodNam, foodMount);
                }              
                MessageBox.Show("Đơn hàng đã gửi tới cửa hàng!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi! Không thể đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton_giao_hàng_CheckedChanged(object sender, EventArgs e)
        {
            feeDelivery();
            textBox_tổng_tiền.Text = (Convert.ToInt32(totalPayment.ToString()) + Convert.ToInt32(textBox_phí.Text.ToString())).ToString();
        }
        //
    }
}
