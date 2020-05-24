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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            hinhtrangchu1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //food

        private void Trangchu_Load(object sender, EventArgs e)
        {
            pnlDropFood.Height = 60;
            pnlDropDrink.Height = 60;
        }

        private void btnDrink_Click_2(object sender, EventArgs e)
        {
            //Hiện panel chọn
            
            //hinhtrangchu1.BringToFront();
            //
            if (pnlDropDrink.Height == 186)
            {
                pnlDropDrink.Height = 60;
            }
            else { pnlDropDrink.Height = 186; }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap formdn = new FormDangNhap();
            formdn.ShowDialog();
            this.Show();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormDangKy formdk = new FormDangKy();
            formdk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            
            hinhtrangchu1.BringToFront();
        }

        private void button_đồ_ăn_Click(object sender, EventArgs e)
        {
            if (pnlDropFood.Height == 170)
            {
                pnlDropFood.Height = 60;
            }
            else { pnlDropFood.Height = 170; }
        }

        private void button_món_chính_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("MC");
            panel3.Controls.Add(monan);
            monan.BringToFront();

        }

        private void button_cà_phê_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("CF");
            panel3.Controls.Add(monan);
            monan.BringToFront();


        }

        private void button_đồ_ăn_nhanh_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("AV");
            panel3.Controls.Add(monan);
            monan.BringToFront();

        }

        private void button_đồ_uống_có_ga_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("DU");
            panel3.Controls.Add(monan);
            monan.BringToFront();

        }
    }
}
