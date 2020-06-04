namespace FastFood
{
    partial class FormKHDiaChiGiaoHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_lấy_trực_tiếp = new System.Windows.Forms.RadioButton();
            this.radioButton_giao_hàng = new System.Windows.Forms.RadioButton();
            this.label_hình_thức_đặt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_địa_chỉ = new System.Windows.Forms.Label();
            this.textBox_địa_chỉ_giao_hàng = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_chọn_cửa_hàng = new System.Windows.Forms.ComboBox();
            this.label_cửa_hàng = new System.Windows.Forms.Label();
            this.button_xác_nhận = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_đơn_hàng = new System.Windows.Forms.DataGridView();
            this.TENMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_chi_tiết_đơn_hàng = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_số_điện_thoại = new System.Windows.Forms.Label();
            this.label_tổng_tiền = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_đồng = new System.Windows.Forms.Label();
            this.textBox_tổng_tiền = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phí = new System.Windows.Forms.TextBox();
            this.label_phí = new System.Windows.Forms.Label();
            this.timer_reload = new System.Windows.Forms.Timer(this.components);
            this.textBox_số_điện_thoại = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_đơn_hàng)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton_lấy_trực_tiếp);
            this.panel3.Controls.Add(this.radioButton_giao_hàng);
            this.panel3.Controls.Add(this.label_hình_thức_đặt);
            this.panel3.Location = new System.Drawing.Point(97, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 48);
            this.panel3.TabIndex = 20;
            // 
            // radioButton_lấy_trực_tiếp
            // 
            this.radioButton_lấy_trực_tiếp.AutoSize = true;
            this.radioButton_lấy_trực_tiếp.BackColor = System.Drawing.Color.Firebrick;
            this.radioButton_lấy_trực_tiếp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_lấy_trực_tiếp.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_lấy_trực_tiếp.ForeColor = System.Drawing.Color.White;
            this.radioButton_lấy_trực_tiếp.Location = new System.Drawing.Point(382, 7);
            this.radioButton_lấy_trực_tiếp.Name = "radioButton_lấy_trực_tiếp";
            this.radioButton_lấy_trực_tiếp.Size = new System.Drawing.Size(152, 30);
            this.radioButton_lấy_trực_tiếp.TabIndex = 3;
            this.radioButton_lấy_trực_tiếp.TabStop = true;
            this.radioButton_lấy_trực_tiếp.Text = "Lấy trực tiếp";
            this.radioButton_lấy_trực_tiếp.UseVisualStyleBackColor = false;
            // 
            // radioButton_giao_hàng
            // 
            this.radioButton_giao_hàng.AutoSize = true;
            this.radioButton_giao_hàng.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.radioButton_giao_hàng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_giao_hàng.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_giao_hàng.ForeColor = System.Drawing.Color.White;
            this.radioButton_giao_hàng.Location = new System.Drawing.Point(235, 7);
            this.radioButton_giao_hàng.Name = "radioButton_giao_hàng";
            this.radioButton_giao_hàng.Size = new System.Drawing.Size(125, 30);
            this.radioButton_giao_hàng.TabIndex = 2;
            this.radioButton_giao_hàng.TabStop = true;
            this.radioButton_giao_hàng.Text = "Giao hàng";
            this.radioButton_giao_hàng.UseVisualStyleBackColor = false;
            this.radioButton_giao_hàng.CheckedChanged += new System.EventHandler(this.radioButton_giao_hàng_CheckedChanged);
            // 
            // label_hình_thức_đặt
            // 
            this.label_hình_thức_đặt.AutoSize = true;
            this.label_hình_thức_đặt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hình_thức_đặt.ForeColor = System.Drawing.Color.Maroon;
            this.label_hình_thức_đặt.Location = new System.Drawing.Point(20, 9);
            this.label_hình_thức_đặt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hình_thức_đặt.Name = "label_hình_thức_đặt";
            this.label_hình_thức_đặt.Size = new System.Drawing.Size(206, 28);
            this.label_hình_thức_đặt.TabIndex = 1;
            this.label_hình_thức_đặt.Text = "Hình thức đặt hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_địa_chỉ);
            this.panel2.Controls.Add(this.textBox_địa_chỉ_giao_hàng);
            this.panel2.Location = new System.Drawing.Point(97, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 44);
            this.panel2.TabIndex = 19;
            // 
            // label_địa_chỉ
            // 
            this.label_địa_chỉ.AutoSize = true;
            this.label_địa_chỉ.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_địa_chỉ.ForeColor = System.Drawing.Color.Maroon;
            this.label_địa_chỉ.Location = new System.Drawing.Point(20, 7);
            this.label_địa_chỉ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_địa_chỉ.Name = "label_địa_chỉ";
            this.label_địa_chỉ.Size = new System.Drawing.Size(83, 28);
            this.label_địa_chỉ.TabIndex = 1;
            this.label_địa_chỉ.Text = "Địa chỉ";
            // 
            // textBox_địa_chỉ_giao_hàng
            // 
            this.textBox_địa_chỉ_giao_hàng.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_địa_chỉ_giao_hàng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_địa_chỉ_giao_hàng.Location = new System.Drawing.Point(200, 4);
            this.textBox_địa_chỉ_giao_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_địa_chỉ_giao_hàng.Name = "textBox_địa_chỉ_giao_hàng";
            this.textBox_địa_chỉ_giao_hàng.Size = new System.Drawing.Size(334, 31);
            this.textBox_địa_chỉ_giao_hàng.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_chọn_cửa_hàng);
            this.panel1.Controls.Add(this.label_cửa_hàng);
            this.panel1.Location = new System.Drawing.Point(97, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 46);
            this.panel1.TabIndex = 18;
            // 
            // comboBox_chọn_cửa_hàng
            // 
            this.comboBox_chọn_cửa_hàng.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_chọn_cửa_hàng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chọn_cửa_hàng.FormattingEnabled = true;
            this.comboBox_chọn_cửa_hàng.Location = new System.Drawing.Point(200, 4);
            this.comboBox_chọn_cửa_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_chọn_cửa_hàng.Name = "comboBox_chọn_cửa_hàng";
            this.comboBox_chọn_cửa_hàng.Size = new System.Drawing.Size(334, 31);
            this.comboBox_chọn_cửa_hàng.TabIndex = 0;
            // 
            // label_cửa_hàng
            // 
            this.label_cửa_hàng.AutoSize = true;
            this.label_cửa_hàng.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cửa_hàng.ForeColor = System.Drawing.Color.Maroon;
            this.label_cửa_hàng.Location = new System.Drawing.Point(20, 7);
            this.label_cửa_hàng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cửa_hàng.Name = "label_cửa_hàng";
            this.label_cửa_hàng.Size = new System.Drawing.Size(108, 28);
            this.label_cửa_hàng.TabIndex = 1;
            this.label_cửa_hàng.Text = "Cửa hàng";
            // 
            // button_xác_nhận
            // 
            this.button_xác_nhận.BackColor = System.Drawing.Color.DarkRed;
            this.button_xác_nhận.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_xác_nhận.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xác_nhận.ForeColor = System.Drawing.Color.White;
            this.button_xác_nhận.Location = new System.Drawing.Point(274, 708);
            this.button_xác_nhận.Name = "button_xác_nhận";
            this.button_xác_nhận.Size = new System.Drawing.Size(183, 59);
            this.button_xác_nhận.TabIndex = 17;
            this.button_xác_nhận.Text = "Xác nhận";
            this.button_xác_nhận.UseVisualStyleBackColor = false;
            this.button_xác_nhận.Click += new System.EventHandler(this.button_xác_nhận_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_đơn_hàng);
            this.panel4.Location = new System.Drawing.Point(97, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 253);
            this.panel4.TabIndex = 21;
            // 
            // dataGridView_đơn_hàng
            // 
            this.dataGridView_đơn_hàng.AllowUserToAddRows = false;
            this.dataGridView_đơn_hàng.AllowUserToDeleteRows = false;
            this.dataGridView_đơn_hàng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_đơn_hàng.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView_đơn_hàng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_đơn_hàng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENMONAN,
            this.SOLUONG,
            this.GIATIEN});
            this.dataGridView_đơn_hàng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_đơn_hàng.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_đơn_hàng.Name = "dataGridView_đơn_hàng";
            this.dataGridView_đơn_hàng.ReadOnly = true;
            this.dataGridView_đơn_hàng.Size = new System.Drawing.Size(564, 253);
            this.dataGridView_đơn_hàng.TabIndex = 1;
            // 
            // TENMONAN
            // 
            this.TENMONAN.HeaderText = "TÊN MÓN ĂN";
            this.TENMONAN.Name = "TENMONAN";
            this.TENMONAN.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // GIATIEN
            // 
            this.GIATIEN.HeaderText = "GIÁ TIỀN";
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_chi_tiết_đơn_hàng);
            this.panel5.Location = new System.Drawing.Point(97, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 46);
            this.panel5.TabIndex = 21;
            // 
            // label_chi_tiết_đơn_hàng
            // 
            this.label_chi_tiết_đơn_hàng.AutoSize = true;
            this.label_chi_tiết_đơn_hàng.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chi_tiết_đơn_hàng.ForeColor = System.Drawing.Color.Maroon;
            this.label_chi_tiết_đơn_hàng.Location = new System.Drawing.Point(20, 9);
            this.label_chi_tiết_đơn_hàng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chi_tiết_đơn_hàng.Name = "label_chi_tiết_đơn_hàng";
            this.label_chi_tiết_đơn_hàng.Size = new System.Drawing.Size(192, 28);
            this.label_chi_tiết_đơn_hàng.TabIndex = 1;
            this.label_chi_tiết_đơn_hàng.Text = "Chi tiết đơn hàng:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label_số_điện_thoại);
            this.panel6.Controls.Add(this.textBox_số_điện_thoại);
            this.panel6.Location = new System.Drawing.Point(97, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(561, 48);
            this.panel6.TabIndex = 20;
            // 
            // label_số_điện_thoại
            // 
            this.label_số_điện_thoại.AutoSize = true;
            this.label_số_điện_thoại.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_số_điện_thoại.ForeColor = System.Drawing.Color.Maroon;
            this.label_số_điện_thoại.Location = new System.Drawing.Point(20, 7);
            this.label_số_điện_thoại.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_số_điện_thoại.Name = "label_số_điện_thoại";
            this.label_số_điện_thoại.Size = new System.Drawing.Size(145, 28);
            this.label_số_điện_thoại.TabIndex = 1;
            this.label_số_điện_thoại.Text = "Số điện thoại";
            // 
            // label_tổng_tiền
            // 
            this.label_tổng_tiền.AutoSize = true;
            this.label_tổng_tiền.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tổng_tiền.ForeColor = System.Drawing.Color.Maroon;
            this.label_tổng_tiền.Location = new System.Drawing.Point(3, 10);
            this.label_tổng_tiền.Name = "label_tổng_tiền";
            this.label_tổng_tiền.Size = new System.Drawing.Size(122, 28);
            this.label_tổng_tiền.TabIndex = 22;
            this.label_tổng_tiền.Text = "Tổng cộng:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_đồng);
            this.panel7.Controls.Add(this.textBox_tổng_tiền);
            this.panel7.Controls.Add(this.label_tổng_tiền);
            this.panel7.Location = new System.Drawing.Point(369, 641);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 45);
            this.panel7.TabIndex = 22;
            // 
            // label_đồng
            // 
            this.label_đồng.AutoSize = true;
            this.label_đồng.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_đồng.Location = new System.Drawing.Point(262, 9);
            this.label_đồng.Name = "label_đồng";
            this.label_đồng.Size = new System.Drawing.Size(25, 28);
            this.label_đồng.TabIndex = 24;
            this.label_đồng.Text = "đ";
            // 
            // textBox_tổng_tiền
            // 
            this.textBox_tổng_tiền.BackColor = System.Drawing.Color.Coral;
            this.textBox_tổng_tiền.Enabled = false;
            this.textBox_tổng_tiền.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tổng_tiền.ForeColor = System.Drawing.Color.Black;
            this.textBox_tổng_tiền.Location = new System.Drawing.Point(122, 7);
            this.textBox_tổng_tiền.Name = "textBox_tổng_tiền";
            this.textBox_tổng_tiền.ReadOnly = true;
            this.textBox_tổng_tiền.Size = new System.Drawing.Size(140, 34);
            this.textBox_tổng_tiền.TabIndex = 23;
            this.textBox_tổng_tiền.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.textBox_phí);
            this.panel8.Controls.Add(this.label_phí);
            this.panel8.Location = new System.Drawing.Point(324, 579);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 45);
            this.panel8.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "đ";
            // 
            // textBox_phí
            // 
            this.textBox_phí.BackColor = System.Drawing.Color.Coral;
            this.textBox_phí.Enabled = false;
            this.textBox_phí.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phí.ForeColor = System.Drawing.Color.Black;
            this.textBox_phí.Location = new System.Drawing.Point(167, 7);
            this.textBox_phí.Name = "textBox_phí";
            this.textBox_phí.ReadOnly = true;
            this.textBox_phí.Size = new System.Drawing.Size(140, 34);
            this.textBox_phí.TabIndex = 23;
            this.textBox_phí.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_phí
            // 
            this.label_phí.AutoSize = true;
            this.label_phí.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phí.ForeColor = System.Drawing.Color.Maroon;
            this.label_phí.Location = new System.Drawing.Point(3, 10);
            this.label_phí.Name = "label_phí";
            this.label_phí.Size = new System.Drawing.Size(156, 28);
            this.label_phí.TabIndex = 22;
            this.label_phí.Text = "Phí giao hàng:";
            // 
            // textBox_số_điện_thoại
            // 
            this.textBox_số_điện_thoại.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_số_điện_thoại.Enabled = false;
            this.textBox_số_điện_thoại.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_số_điện_thoại.Location = new System.Drawing.Point(200, 4);
            this.textBox_số_điện_thoại.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_số_điện_thoại.Name = "textBox_số_điện_thoại";
            this.textBox_số_điện_thoại.Size = new System.Drawing.Size(334, 31);
            this.textBox_số_điện_thoại.TabIndex = 3;
            // 
            // KHDiaChiGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(755, 788);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_xác_nhận);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKHDiaChiGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForKHDiaChiGiaoHang";
            this.Load += new System.EventHandler(this.FormKHDiaChiGiaoHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_đơn_hàng)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton_lấy_trực_tiếp;
        private System.Windows.Forms.RadioButton radioButton_giao_hàng;
        private System.Windows.Forms.Label label_hình_thức_đặt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_địa_chỉ;
        private System.Windows.Forms.TextBox textBox_địa_chỉ_giao_hàng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_chọn_cửa_hàng;
        private System.Windows.Forms.Label label_cửa_hàng;
        private System.Windows.Forms.Button button_xác_nhận;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_chi_tiết_đơn_hàng;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_số_điện_thoại;
        private System.Windows.Forms.Label label_tổng_tiền;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox_tổng_tiền;
        private System.Windows.Forms.Label label_đồng;
        public System.Windows.Forms.DataGridView dataGridView_đơn_hàng;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMONAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_phí;
        private System.Windows.Forms.Label label_phí;
        private System.Windows.Forms.Timer timer_reload;
        private System.Windows.Forms.TextBox textBox_số_điện_thoại;
    }
}