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
    public partial class FormNVCH : Form
    {
        public FormNVCH()
        {
            InitializeComponent();
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
        }

        private void button_tạo_tài_khoản_Click(object sender, EventArgs e)
        {
            
        }

        private void button_món_ăn_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_món_ăn.Height;
            panel_chọn.Top = button_món_ăn.Top;
        }

        private void button_đơn_hàng_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_đơn_hàng.Height;
            panel_chọn.Top = button_đơn_hàng.Top;
        }
    }
}
