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
        public static List<DataRow> GioHang = new List<DataRow>();
        public FormKhachHang()
        {
            InitializeComponent();
            hinhtrangchu1.BringToFront();
        }

        private void button_cà_phê_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("CF");
            panel3.Controls.Add(monan);
            monan.BringToFront();
        }

        private void button_đồ_uống_có_ga_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("DU");
            panel3.Controls.Add(monan);
            monan.BringToFront();
        }

        private void button_món_chính_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("MC");
            panel3.Controls.Add(monan);
            monan.BringToFront();
        }

        private void button_đồ_ăn_nhanh_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("AV");
            panel3.Controls.Add(monan);
            monan.BringToFront();
        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            hinhtrangchu1.BringToFront();
        }

        private void button_giỏ_hàng_Click(object sender, EventArgs e)
        {
            giohang1.BringToFront();
            giohang1.Giohang_Load(null, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.ShowDialog();
        }

        private void button_lịch_sử_hóa_đơn_Click(object sender, EventArgs e)
        {
           
            lichsudathang1.BringToFront();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
