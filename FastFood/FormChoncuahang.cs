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
    public partial class FormChoncuahang : Form
    {
        public string storeAddress;
        public int storeIndex;
        public string storeID;
        private DataTable sourceTable;
        public FormChoncuahang()
        {
            InitializeComponent();
        }

        private void FormChoncuahang_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.CUA_HANG where [TRẠNG THÁI HOẠT ĐỘNG]=1";
             sourceTable= DataProvider.Instance.ExecuteQuery(query);
            comboBox_cửa_hàng.DataSource = sourceTable;
            //comboBox_cửa_hàng.DisplayMember = "ĐỊA CHỈ";
            comboBox_cửa_hàng.ValueMember = "ĐỊA CHỈ";
           
        }

        private void button_bắt_đặt_hàng_Click(object sender, EventArgs e)
        {
            storeAddress = comboBox_cửa_hàng.SelectedValue.ToString();
            storeIndex = comboBox_cửa_hàng.SelectedIndex;
            DataRow row = sourceTable.Rows[storeIndex];
            storeID = row["MÃ CỬA HÀNG"].ToString();
            this.Close();
        }
    }
}
