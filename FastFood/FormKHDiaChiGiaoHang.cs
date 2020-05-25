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
    public partial class FormKHDiaChiGiaoHang : Form
    {
        public FormKHDiaChiGiaoHang()
        {
            InitializeComponent();
            FillComboBoxCuaHang();
        }
        //Load combo box cửa hàng
        public void FillComboBoxCuaHang()
        {
            string query = "select * from dbo.CUA_HANG";
            comboBox_chọn_cửa_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query);

            comboBox_chọn_cửa_hàng.DisplayMember = "ĐỊA CHỈ";
            comboBox_chọn_cửa_hàng.ValueMember = "MÃ CỬA HÀNG";

        }
        //

        //Thêm đơn hàng tử khách hàng
        public void InsetBillByCustomer()
        {
            int i = 10;
            string billNumber="DH"+i.ToString();
            string storeNumber=comboBox_chọn_cửa_hàng.SelectedItem.ToString();
            string customerNumber=textBox_số_điện_thoại.Text;
            int totalBill = Convert.ToInt32(textBox_tổng_tiền.Text);
            DateTime dateNow = DateTime.Now;
            string date = dateNow.ToString("yyyy/MM/dd");
            int kindBill = 0;

            if (BillDAO.Instance.InsertBillByCustomer(billNumber, storeNumber, customerNumber, totalBill, date, kindBill))
            {
                ++i;
            }
        }
        //
    }
}
