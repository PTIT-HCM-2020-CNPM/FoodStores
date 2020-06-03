using FastFood.DAL_DataLayer;
using FastFood.DTO_DataTranferObject;
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
    public partial class KHKiemtradonhang : Form
    {
        public string numCus;
        public KHKiemtradonhang()
        {
            InitializeComponent();
        }

        private void KHKiemtradonhang_Load(object sender, EventArgs e)
        {
            if (BillDAO.Instance.GetNumBillCus(numCus,3) == 0)
            {
                MessageBox.Show("Không có đơn đặt hàng nào!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else if(BillDAO.Instance.GetNumBillCus(numCus, 3) > 0)
            {
                DataTable result=BillDAO.Instance.GetNumBillCus1(numCus,3);
                DataRow dataRow = result.Rows[0];
                textBox_mã_đơn_hàng.Text = dataRow["MÃ ĐƠN HÀNG"].ToString();
                textBox_số_điện_thoại.Text = dataRow["MÃ KHÁCH HÀNG(SĐT)"].ToString();
                textBox_địa_chỉ_giao_hàng.Text = dataRow["ĐỊA CHỈ"].ToString();
                int status = Convert.ToInt32(dataRow["TRẠNG THÁI ĐƠN HÀNG"]);
                switch (status)
                {
                    case 0:
                        //radioButton_chuẩn_bị.Checked = true;
                        checkedListBox1.SetItemChecked(0, true);
                        break;
                    case 1:
                        //radioButton_đang_giao.Checked = true;
                        checkedListBox1.SetItemChecked(1, true);
                        break;
                    case 2:
                        //radioButton_tại_cửa_hàng.Checked = true;
                        checkedListBox1.SetItemChecked(2, true);
                        break;
                }
                dataGridView_hóa_đơn.DataSource = BillDAO.Instance.GetBillInfo(textBox_mã_đơn_hàng.Text);
                DataRow billPay = BillDAO.Instance.GetPayBill(textBox_mã_đơn_hàng.Text).Rows[0];
                textBox_tổng_tiền.Text = billPay["TỔNG TIỀN"].ToString();
            }
        }
    }
}
