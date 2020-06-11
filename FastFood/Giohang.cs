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
        public int storeIndex;
        public string storeID;
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
                    dataGridView1_giỏ_hàng.Rows.Add(item["TÊN MÓN ĂN"].ToString(), item["GIÁ TIỀN"].ToString(),1);
                }
            }
            if (totalPayment == 0)
            {
                textBox_tổng_tiền.Text = "0";
            }
            //tính tổng tiền của đơn hàng
            sumBillPay();

        }
        //Check số lượng món ăn cửa hàng có nhỏ hơn số lượng khách đặt
        private int CheckAmountFood(string storeNumber, string foodName)
        {
            DataRow rowAmount = FoodDAO.Instance.GetAmountFoodStore(storeNumber, foodName).Rows[0];
            int amount = Convert.ToInt32(rowAmount["SỐ LƯỢNG"]);
            return amount;
        }
        //public bool CanOrder(string storeNum, string foodName )
        //{
        //    int result = 0;
        //    foreach (DataGridViewRow row in dataGridView1_giỏ_hàng.Rows)
        //    {
        //        int amount = Convert.ToInt32(row.Cells[3].Value);
        //        result = CheckAmountFood(storeNum, row.Cells[1].Value.ToString()) - amount;              
        //    }
        //    return result > 0;
        //}
        //Check bill hiện tại của khách hàng
        public bool CheckBillCurrent()
        {
            return BillDAO.Instance.GetBillCus(numberPhone).Rows.Count > 0;
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
            else if (CheckBillCurrent())//ràng buộc chỉ được đặt 1 bill
            {
                MessageBox.Show("Bạn đang đặt một đơn hàng không thể đặt đơn hàng khác!");
            }
            else
            {
                int result=0;
                foreach (DataGridViewRow row in dataGridView1_giỏ_hàng.Rows)
                {
                    int amount = Convert.ToInt32(row.Cells[2].Value);
                    int amountOld = CheckAmountFood(storeID, row.Cells[0].Value.ToString());
                    result =  amountOld - amount;
                    if (result < 0) {
                        row.Cells[2].Value= amountOld.ToString();
                        break;
                    }
                }
                if (!(result > 0))
                {
                    MessageBox.Show("Một trong các món ăn bạn đặt tại cửa hàng này không còn đủ số lượng! " +
                        "Xin chọn một cửa hàng khác hoặc thay đổi món ăn!");
                    
                }
                else{ 
                    FormKHDiaChiGiaoHang formKHDiaChiGiao = new FormKHDiaChiGiaoHang(numberPhone);
                    formKHDiaChiGiao.totalPayment = totalPayment;
                    formKHDiaChiGiao.storeIndex = storeIndex;
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
        //

        //Điều chỉnh số lượng
        private int indexRow;
        private void dataGridView1_giỏ_hàng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;           
        }

        private void button_điều_chỉnh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row= dataGridView1_giỏ_hàng.Rows[indexRow];
            try
            {
                if (numericUpDown_số_lượng.Value.Equals(0))
                {
                    dataGridView1_giỏ_hàng.Rows.RemoveAt(indexRow);
                    subBillPay();
                }
                else
                {
                    row.Cells[2].Value = numericUpDown_số_lượng.Value.ToString();
                    subBillPay();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn và cập nhật số lượng theo từng dòng!");
            }
        }

    }
}
