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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_thống_kê_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
