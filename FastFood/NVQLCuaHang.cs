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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_thêm_cửa_hàng_Click(object sender, EventArgs e)
        {

        }

        private void button_xóa_cửa_hàng_Click(object sender, EventArgs e)
        {

        }
    }
}
