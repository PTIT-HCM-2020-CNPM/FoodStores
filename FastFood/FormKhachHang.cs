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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            hinhtrangchu1.BringToFront();
        }

        private void button_cà_phê_Click(object sender, EventArgs e)
        {
            coffee1.BringToFront();
        }

        private void button_đồ_uống_có_ga_Click(object sender, EventArgs e)
        {
            douongcoga1.BringToFront();
        }

        private void button_món_chính_Click(object sender, EventArgs e)
        {
            monChinh1.BringToFront();
        }

        private void button_đồ_ăn_nhanh_Click(object sender, EventArgs e)
        {
            thucannhanh1.BringToFront();
        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            hinhtrangchu1.BringToFront();
        }
    }
}
