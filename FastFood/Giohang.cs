using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
   
    public partial class Giohang : UserControl
    {
       
        public Giohang()
        {
            InitializeComponent();
            
        }

        public void Giohang_Load(object sender, EventArgs e)
        {
            foreach (DataRow item in FormKhachHang.GioHang)
            {
                dataGridView1.Rows.Add(item["TÊN MÓN ĂN"].ToString(), 10, item["GIÁ TIỀN"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
          
        }
        private void Giohang_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button_thanh_toán_Click(object sender, EventArgs e)
        {
            FormKHDiaChiGiaoHang formKHDiaChiGiao = new FormKHDiaChiGiaoHang();
            formKHDiaChiGiao.ShowDialog();
        }
    }
}
