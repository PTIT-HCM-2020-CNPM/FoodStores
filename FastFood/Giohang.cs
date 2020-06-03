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
   
    public partial class Giohang : UserControl
    {
        public string numberPhone;
        public int totalPayment;
        public int totalNumOfFood;
        public Giohang()
        {
            InitializeComponent();
            subBillPay();
        }
        //Trừ item đã xóa
        public void subBillPay()
        {
            int totalPay = 0;
            for (int i=0;i<dataGridView1_giỏ_hàng.Rows.Count;i++)
            {
                totalPay = totalPay +
                    (int.Parse(dataGridView1_giỏ_hàng.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1_giỏ_hàng.Rows[i].Cells[1].Value.ToString()));
                textBox_tổng_tiền.Text = totalPay.ToString();
            }
            totalPayment = totalPay;
        }
        //Tính tổng đơn hàng
        public void sumBillPay()
        {
            foreach (DataGridViewRow row in dataGridView1_giỏ_hàng.Rows)
            {
                totalPayment = totalPayment +
                    (int.Parse(dataGridView1_giỏ_hàng.Rows[row.Index].Cells[2].Value.ToString()) * int.Parse(dataGridView1_giỏ_hàng.Rows[row.Index].Cells[1].Value.ToString()));
                textBox_tổng_tiền.Text = totalPayment.ToString();
            }
        }
        //
        public void Giohang_Load(object sender, EventArgs e)
        {
            
            foreach (DataRow item in FormKhachHang.GioHang)
            {
                bool f=false;
                foreach(DataGridViewRow row in dataGridView1_giỏ_hàng.Rows)
                {
                    if(row.Cells[0].Value!=null && row.Cells[0].Value.ToString().Equals(item["TÊN MÓN ĂN"].ToString()))
                    {
                        f = true;
                        break;
                    }
                }
                if (f) continue;
                {
                    int cnt = 0;
                    foreach (DataRow item2 in FormKhachHang.GioHang)
                    {
                        if(item["TÊN MÓN ĂN"].ToString().Equals(item["TÊN MÓN ĂN"].ToString()))
                            ++cnt;
                    }
                    dataGridView1_giỏ_hàng.Rows.Add(item["TÊN MÓN ĂN"].ToString(), cnt, item["GIÁ TIỀN"].ToString());
                }
            }
            if (totalPayment == 0)
            {
                textBox_tổng_tiền.Text = "0";
            }
            //tính tổng tiền của đơn hàng
            sumBillPay();

        }
       //Chuyển bảng giỏ hàng -> xác nhận
        private void button_thanh_toán_Click(object sender, EventArgs e)
        {
            if (totalPayment == 0)
            {
                MessageBox.Show("Bạn chưa thêm món ăn vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (totalPayment<30000)
            {
                MessageBox.Show("Tổng đơn hàng cần lớn hơn 30,000đ! Xin vui lòng chọn thêm món!");
            }
            else if (BillDAO.Instance.GetNumBillCus(numberPhone,3)>0)
            {
                MessageBox.Show("Bạn đã đặt một đơn hàng, không thể đặt đơn khác!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                KHDiaChiGiaoHang formKHDiaChiGiao = new KHDiaChiGiaoHang(numberPhone);
                formKHDiaChiGiao.totalPayment = totalPayment;
                //Lấy giá trị datagridview giỏ hàng -> datagirdview xác nhận
                foreach (DataGridViewRow row in dataGridView1_giỏ_hàng.Rows)
                {
                    int n = formKHDiaChiGiao.dataGridView_đơn_hàng.Rows.Add();
                    foreach(DataGridViewColumn col in dataGridView1_giỏ_hàng.Columns) {
                        formKHDiaChiGiao.dataGridView_đơn_hàng.Rows[n].Cells[col.Index].Value= dataGridView1_giỏ_hàng.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }
                formKHDiaChiGiao.ShowDialog();
            }
        }
        //Xóa một vật phẩm trong giỏ hàng datagridview
        private void button_xóa_Click(object sender, EventArgs e)
        {
            try {
                if (dataGridView1_giỏ_hàng.Rows.Count-1 == 0)//sau khi xóa hết dòng vẫn lưu giá trị dòng là 1
                {
                    textBox_tổng_tiền.Text = "0";
                }               
                int rowIndex = dataGridView1_giỏ_hàng.CurrentCell.RowIndex;               
                if (totalPayment == 0)
                {
                    textBox_tổng_tiền.Text = "0";
                }
                else
                {
                    dataGridView1_giỏ_hàng.Rows.RemoveAt(rowIndex);
                    subBillPay();
                }
            }
            catch
            {
                MessageBox.Show("Giỏ hàng rỗng, không thể xóa!");
                textBox_tổng_tiền.Text = "0";
            }
        }
    }
}
