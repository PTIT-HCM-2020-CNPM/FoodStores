﻿using System;
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        //food
        private void button3_Click(object sender, EventArgs e)
        {
            if (pnlDropFood.Height == 170)
            {
                pnlDropFood.Height = 60;
            }
            else { pnlDropFood.Height = 170; }
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            pnlDropFood.Height = 60;
            pnlDropDrink.Height = 60;
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {

        }

        private void btnDrink_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDrink_Click_2(object sender, EventArgs e)
        {
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
            FormDangNhap formdn = new FormDangNhap();
            formdn.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FormDangKy formdk = new FormDangKy();
            formdk.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
