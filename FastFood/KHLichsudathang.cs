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
using FastFood.DTO_DataTranferObject;

namespace FastFood
{
    public partial class KHLichsudathang : UserControl
    {
        public string customerNumber;
        private int totalPayment;
        public KHLichsudathang()
        {
            InitializeComponent();
            timer_reload.Start();
        }

        List<HistoryOrder> ListOrders(){

            List<HistoryOrder> orders = BillDAO.Instance.LoadBillCustomer(customerNumber);
            return orders;
        }
        private void Lichsudathang_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ListOrders();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ////Chọn xem chi tiết đơn hàng
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                string numBillCustomer = row.Cells[3].Value.ToString();
                totalPayment = Convert.ToInt32(row.Cells[1].Value.ToString());
                //Nhấn chọn hóa đơn hiện chi tiết hóa đơn  

                dataGridView_chi_tiết_đơn_hàng.DataSource = BillDAO.Instance.SelectBillInfo(numBillCustomer);
            }
        }
        // //Check bill hiện tại của khách hàng
        public bool CheckBillCurrent()
        {
            return BillDAO.Instance.GetBillCus(customerNumber).Rows.Count > 0;
        }
        ////Đặt lại đơn hàng như cũ
        private void button_reorder_Click(object sender, EventArgs e)
        {
            if (totalPayment == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng muốn đặt lại");
            }
            else if (CheckBillCurrent())//ràng buộc đặt 1 bill
            {
                MessageBox.Show("Bạn đang đặt một đơn hàng không thể đặt đơn hàng khác!");
            }
            else
            {
                FormKHDiaChiGiaoHang diaChiGiaoHang = new FormKHDiaChiGiaoHang(customerNumber);
                diaChiGiaoHang.totalPayment = totalPayment;
                foreach (DataGridViewRow row in dataGridView_chi_tiết_đơn_hàng.Rows)
                {
                    int n = diaChiGiaoHang.dataGridView_đơn_hàng.Rows.Add();
                    foreach (DataGridViewColumn col in dataGridView_chi_tiết_đơn_hàng.Columns)
                    {
                        diaChiGiaoHang.dataGridView_đơn_hàng.Rows[n].Cells[col.Index].Value = dataGridView_chi_tiết_đơn_hàng.Rows[row.Index].Cells[col.Index].Value.ToString();
                    }
                }
                diaChiGiaoHang.ShowDialog();
            }
        }
        //Reload lịch sử theo thời gian
        private void timer_reload_Tick(object sender, EventArgs e)
        {
            Lichsudathang_Load(sender, e);
        }
    }
}
