namespace FastFood
{
    partial class Giohang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1_giỏ_hàng = new System.Windows.Forms.DataGridView();
            this.TENMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_xóa = new System.Windows.Forms.Button();
            this.button_thanh_toán = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_đồng = new System.Windows.Forms.Label();
            this.textBox_tổng_tiền = new System.Windows.Forms.TextBox();
            this.label_tổng_tiền = new System.Windows.Forms.Label();
            this.numericUpDown_số_lượng = new System.Windows.Forms.NumericUpDown();
            this.button_điều_chỉnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_giỏ_hàng)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_số_lượng)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(486, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ hàng của bạn";
            // 
            // dataGridView1_giỏ_hàng
            // 
            this.dataGridView1_giỏ_hàng.AllowUserToAddRows = false;
            this.dataGridView1_giỏ_hàng.AllowUserToDeleteRows = false;
            this.dataGridView1_giỏ_hàng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_giỏ_hàng.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView1_giỏ_hàng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_giỏ_hàng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENMONAN,
            this.GIATIEN,
            this.SOLUONG});
            this.dataGridView1_giỏ_hàng.Location = new System.Drawing.Point(291, 106);
            this.dataGridView1_giỏ_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1_giỏ_hàng.Name = "dataGridView1_giỏ_hàng";
            this.dataGridView1_giỏ_hàng.ReadOnly = true;
            this.dataGridView1_giỏ_hàng.Size = new System.Drawing.Size(609, 326);
            this.dataGridView1_giỏ_hàng.TabIndex = 0;
            this.dataGridView1_giỏ_hàng.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_giỏ_hàng_CellClick);
            // 
            // TENMONAN
            // 
            this.TENMONAN.HeaderText = "TÊN MÓN ĂN";
            this.TENMONAN.Name = "TENMONAN";
            this.TENMONAN.ReadOnly = true;
            // 
            // GIATIEN
            // 
            this.GIATIEN.HeaderText = "GIÁ TIỀN";
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // button_xóa
            // 
            this.button_xóa.BackColor = System.Drawing.Color.DarkRed;
            this.button_xóa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_xóa.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xóa.ForeColor = System.Drawing.Color.White;
            this.button_xóa.Location = new System.Drawing.Point(926, 257);
            this.button_xóa.Name = "button_xóa";
            this.button_xóa.Size = new System.Drawing.Size(160, 44);
            this.button_xóa.TabIndex = 3;
            this.button_xóa.Text = "Xóa món";
            this.button_xóa.UseVisualStyleBackColor = false;
            this.button_xóa.Click += new System.EventHandler(this.button_xóa_Click);
            // 
            // button_thanh_toán
            // 
            this.button_thanh_toán.BackColor = System.Drawing.Color.DarkRed;
            this.button_thanh_toán.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_thanh_toán.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thanh_toán.ForeColor = System.Drawing.Color.White;
            this.button_thanh_toán.Location = new System.Drawing.Point(505, 507);
            this.button_thanh_toán.Name = "button_thanh_toán";
            this.button_thanh_toán.Size = new System.Drawing.Size(183, 59);
            this.button_thanh_toán.TabIndex = 1;
            this.button_thanh_toán.Text = "Thanh toán";
            this.button_thanh_toán.UseVisualStyleBackColor = false;
            this.button_thanh_toán.Click += new System.EventHandler(this.button_thanh_toán_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_đồng);
            this.panel7.Controls.Add(this.textBox_tổng_tiền);
            this.panel7.Controls.Add(this.label_tổng_tiền);
            this.panel7.Location = new System.Drawing.Point(605, 451);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 45);
            this.panel7.TabIndex = 23;
            // 
            // label_đồng
            // 
            this.label_đồng.AutoSize = true;
            this.label_đồng.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_đồng.ForeColor = System.Drawing.Color.Black;
            this.label_đồng.Location = new System.Drawing.Point(264, 6);
            this.label_đồng.Name = "label_đồng";
            this.label_đồng.Size = new System.Drawing.Size(25, 28);
            this.label_đồng.TabIndex = 25;
            this.label_đồng.Text = "đ";
            this.label_đồng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_tổng_tiền
            // 
            this.textBox_tổng_tiền.BackColor = System.Drawing.Color.Coral;
            this.textBox_tổng_tiền.Enabled = false;
            this.textBox_tổng_tiền.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tổng_tiền.ForeColor = System.Drawing.Color.White;
            this.textBox_tổng_tiền.Location = new System.Drawing.Point(122, 3);
            this.textBox_tổng_tiền.Name = "textBox_tổng_tiền";
            this.textBox_tổng_tiền.ReadOnly = true;
            this.textBox_tổng_tiền.Size = new System.Drawing.Size(139, 34);
            this.textBox_tổng_tiền.TabIndex = 23;
            this.textBox_tổng_tiền.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_tổng_tiền
            // 
            this.label_tổng_tiền.AutoSize = true;
            this.label_tổng_tiền.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tổng_tiền.ForeColor = System.Drawing.Color.Maroon;
            this.label_tổng_tiền.Location = new System.Drawing.Point(3, 5);
            this.label_tổng_tiền.Name = "label_tổng_tiền";
            this.label_tổng_tiền.Size = new System.Drawing.Size(122, 28);
            this.label_tổng_tiền.TabIndex = 22;
            this.label_tổng_tiền.Text = "Tổng cộng:";
            // 
            // numericUpDown_số_lượng
            // 
            this.numericUpDown_số_lượng.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_số_lượng.Location = new System.Drawing.Point(1092, 184);
            this.numericUpDown_số_lượng.Name = "numericUpDown_số_lượng";
            this.numericUpDown_số_lượng.Size = new System.Drawing.Size(96, 39);
            this.numericUpDown_số_lượng.TabIndex = 4;
            this.numericUpDown_số_lượng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_số_lượng.ThousandsSeparator = true;
            this.numericUpDown_số_lượng.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // button_điều_chỉnh
            // 
            this.button_điều_chỉnh.BackColor = System.Drawing.Color.DarkRed;
            this.button_điều_chỉnh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_điều_chỉnh.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_điều_chỉnh.ForeColor = System.Drawing.Color.White;
            this.button_điều_chỉnh.Location = new System.Drawing.Point(926, 181);
            this.button_điều_chỉnh.Name = "button_điều_chỉnh";
            this.button_điều_chỉnh.Size = new System.Drawing.Size(160, 44);
            this.button_điều_chỉnh.TabIndex = 2;
            this.button_điều_chỉnh.Text = "Điều chỉnh";
            this.button_điều_chỉnh.UseVisualStyleBackColor = false;
            this.button_điều_chỉnh.Click += new System.EventHandler(this.button_điều_chỉnh_Click);
            // 
            // Giohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.dataGridView1_giỏ_hàng);
            this.Controls.Add(this.button_điều_chỉnh);
            this.Controls.Add(this.numericUpDown_số_lượng);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button_thanh_toán);
            this.Controls.Add(this.button_xóa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giohang";
            this.Size = new System.Drawing.Size(1191, 598);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_giỏ_hàng)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_số_lượng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_xóa;
        private System.Windows.Forms.Button button_thanh_toán;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox_tổng_tiền;
        private System.Windows.Forms.Label label_tổng_tiền;
        private System.Windows.Forms.Label label_đồng;
        private System.Windows.Forms.DataGridView dataGridView1_giỏ_hàng;
        private System.Windows.Forms.NumericUpDown numericUpDown_số_lượng;
        private System.Windows.Forms.Button button_điều_chỉnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMONAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
    }
}
