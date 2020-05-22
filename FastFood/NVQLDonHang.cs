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
    public partial class NVQLDonHang : UserControl
    {
        public NVQLDonHang()
        {
            InitializeComponent();
            LoadBillList();
        }

        //LOAD ĐƠN HÀNG
        void LoadBillList()
        {
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select * from dbo.DON_DAT_HANG ";
               

            // đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_đơn_hàng.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void DataGridView_đơn_hàng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
