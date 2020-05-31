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
    public partial class NVQLDoanhThu : UserControl
    {
        public NVQLDoanhThu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePicker_bắt_đầu.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker_kết_thúc.Value = dateTimePicker_bắt_đầu.Value.AddMonths(1).AddDays(-1);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //TỔNG TIỀN ALL BILL
        private string itemSelectedCBDoanhThu;
        private void comboBox_doanh_thu_SelectedValueChanged(object sender, EventArgs e)
        {
            itemSelectedCBDoanhThu = comboBox_doanh_thu.SelectedItem.ToString();

        }

        private void button_thống_kê_Click(object sender, EventArgs e)
        {
            DateTime dateTo = dateTimePicker_bắt_đầu.Value;
            DateTime dateFrom = dateTimePicker_kết_thúc.Value;

            if (itemSelectedCBDoanhThu == null)
            {
                MessageBox.Show("Vui lòng chọn loại thống kê!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (itemSelectedCBDoanhThu == "Doanh thu mỗi cửa hàng")
            {
                dataGridView_doanh_thu.DataSource = BillDAO.Instance.GetTotalMoneyStoreBill(dateTo, dateFrom);
            }
            else if (itemSelectedCBDoanhThu == "Tổng số tiền đơn hàng offline của chuỗi cửa hàng")
            {
                dataGridView_doanh_thu.DataSource = BillDAO.Instance.GetTotalMoneyOfflineBill(dateTo, dateFrom);
            }
            else if (itemSelectedCBDoanhThu == "Tổng số tiền đơn hàng của chuỗi cửa hàng")
            {
                dataGridView_doanh_thu.DataSource = BillDAO.Instance.GetTotalMoneyBill(dateTo, dateFrom);
            }
            else if(itemSelectedCBDoanhThu == "Tổng số tiền đơn hàng online của chuỗi cửa hàng")
            {
                dataGridView_doanh_thu.DataSource = BillDAO.Instance.GetTotalMoneyOnlineBill(dateTo, dateFrom);
            }
        }

        private void button_xuất_excel_Click(object sender, EventArgs e)
        {
            if (dataGridView_doanh_thu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                for(int i=1; i< dataGridView_doanh_thu.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridView_doanh_thu.Columns[i - 1].HeaderText;
                }

                for(int i = 0; i < dataGridView_doanh_thu.Rows.Count; i++)
                {
                    for(int j=0; j < dataGridView_doanh_thu.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2,j+1]=dataGridView_doanh_thu.Rows[i].Cells[j].Value.ToString();
                    }
                }

                excelApp.Columns.AutoFit();
                excelApp.Visible=true;
            }
        }
    }
}
