﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.DAL_DataLayer;
using DevExpress.Utils.Extensions;

namespace FastFood
{
    public partial class MonAn : UserControl
    {
        public string storeNum;
        public string TypeMonAn = "";
        public MonAn(string TypeMonAn)
        {
            this.TypeMonAn = TypeMonAn;
            InitializeComponent();
            InDanhSachMonAn();
        }

        public void InDanhSachMonAn()
        {

            // List<Table> tableList = TableDAO.Instance.LoadTableList();
            string query = "USP_GetFoodList @type";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TypeMonAn });

            foreach (DataRow item in result.Rows)
            {
                
                PictureBox pictureBox1 = new PictureBox()
                {
                    Dock = DockStyle.Top,
                    Image = Image.FromFile(@"C:\Users\Admin\Desktop\CNPM\FastFood\ImageFood\" + item["HÌNH ẢNH"].ToString()),
                    Location = new System.Drawing.Point(0, 0),
                    Margin = new Padding(2),
                    Name = "pictureBox1",
                    Size = new System.Drawing.Size(225, 125),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    TabIndex = 0,
                    TabStop = false
                };

                Label label1 = new Label()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(21, 146),
                    Margin = new Padding(2, 0, 2, 0),
                    Name = "label1",
                    Size = new System.Drawing.Size(93, 17),
                    TabIndex = 1,
                    Text = item["TÊN MÓN ĂN"].ToString()
                };
                Label label2 = new Label()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(132, 146),
                    Margin = new Padding(2, 0, 2, 0),
                    Name = "label2",
                    Size = new System.Drawing.Size(58, 17),
                    TabIndex = 2,
                    Text = item["GIÁ TIỀN"].ToString()
                };
                Label label3 = new Label()
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor= Color.Red,
                    Location = new System.Drawing.Point(0, 178),
                    Margin = new Padding(2, 0, 2, 0),
                    Name = "label3",
                    Size = new System.Drawing.Size(58, 17),
                    TabIndex = 3,
                    Text = "Hết hàng",
                    Visible = false
                };
                Button button1 = new Button()
                {
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    Location = new System.Drawing.Point(105, 178),
                    Margin = new Padding(2),
                    Name = "button1",
                    Size = new System.Drawing.Size(101, 35),
                    TabIndex = 4,
                    Text = "Đặt hàng",
                    UseVisualStyleBackColor = true
                };
                button1.Click += new EventHandler((sender, EventArgs) => 
                {
                    if(CheckAmountFood(storeNum,item["TÊN MÓN ĂN"].ToString()))
                    {
                        AddCart(sender, EventArgs, item);
                    }
                    else
                    {
                        MessageBox.Show("Món ăn này tạm thời hết hàng,xin quý khách chọn món khác!");
                    }                  
                });
                Panel panel1 = new Panel();

                panel1.SuspendLayout();
                flowLayoutPanel1.Controls.Add(panel1);

                // 
                // panel1
                // 
                panel1.Controls.Add(button1);
                panel1.Controls.Add(label3);
                panel1.Controls.Add(label2);
                panel1.Controls.Add(label1);
                panel1.Controls.Add(pictureBox1);               
                panel1.Location = new System.Drawing.Point(2, 2);
                panel1.Margin = new Padding(2);
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(227, 215);
                panel1.TabIndex = 1;


                Controls.Add(flowLayoutPanel1);
                flowLayoutPanel1.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
                panel1.ResumeLayout(false);
                panel1.PerformLayout();


            }
        }
        private void AddCart(object sender, EventArgs e, DataRow item)
        {
            FormKhachHang.GioHang.Add(item);
        }
        //kiếm tra số lượng món ăn tại cửa hàng > 0 ?
        private bool CheckAmountFood(string storeNumber, string foodName)
        {
            DataRow rowAmount = FoodDAO.Instance.GetAmountFoodStore(storeNumber, foodName).Rows[0];
            int amount = Convert.ToInt32(rowAmount["SỐ LƯỢNG"]);
            return amount > 0;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}
