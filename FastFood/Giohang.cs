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
            // nguồn cái giỏ hàng ở đâu m
            //khi nhan cai dat hang no them vao cai datagrid luon a h muon load cai datagrid do len database
            // thế thì m phải viết code xử lý đa chứ lấy datagridbill
            //còn cái data grird view mày đưa vào bằng lệnh
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
    }
}
