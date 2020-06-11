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
    public partial class FormKHKiemtradonhang : Form
    {
        public string numCus;
        public FormKHKiemtradonhang()
        {
            InitializeComponent();
            timer_reload.Start();
        }
        public bool CheckBillCurrent()
        {
            return BillDAO.Instance.GetBillCus(numCus).Rows.Count>0;
        }

        private void FormKHKiemtradonhang_Load(object sender, EventArgs e)
        {
            if (CheckBillCurrent()==false)
            {
                timer_reload.Stop();
                MessageBox.Show("Bạn chưa đặt đơn hàng nào!");
                this.Close();
                
            }
            else
            {
                DataRow row = BillDAO.Instance.GetBillCus(numCus).Rows[0];
                string numBill = row["MÃ ĐƠN HÀNG"].ToString();
                textBox_cửa_hàng.Text = row["ĐỊA CHỈ CỬA HÀNG"].ToString();
                textBox_địa_chỉ_giao_hàng.Text = row["ĐỊA CHỈ"].ToString();
                if (Convert.ToInt32(row["TRẠNG THÁI ĐƠN HÀNG"]) == 0)
                    checkBox_chuẩn_bị.Checked = true;
                else if(Convert.ToInt32(row["TRẠNG THÁI ĐƠN HÀNG"]) == 1)
                {
                    checkBox_đang_giao.Checked= true;
                }
                else if(Convert.ToInt32(row["TRẠNG THÁI ĐƠN HÀNG"]) == 2)
                {
                    checkBox_tại_c_hàng.Checked = true;
                }

                dataGridView_đơn_hàng.DataSource =BillDAO.Instance.SelectBillInfo(numBill);
            }
        }
        //reload đơn hàng
        public void reloadBill()
        {

        }
        private void FormKHKiemtradonhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer_reload.Stop();
        }
        private void timer_reload_Tick(object sender, EventArgs e)
        {
            FormKHKiemtradonhang_Load(sender, e);
        }

        
    }
}
