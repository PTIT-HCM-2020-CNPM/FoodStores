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
        }
        //TÀI KHOẢN
        void LoadAcountList()
        {
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select * from dbo.TAI_KHOAN " +
                "where[LOẠI TRUY CẬP] = 2";

            
            //đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_tài_khoản.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void button_xóa_tài_khoản_Click(object sender, EventArgs e)
        {

        }

    }
}
