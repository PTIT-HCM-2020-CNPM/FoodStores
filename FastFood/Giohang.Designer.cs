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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_giỏ_hàng = new System.Windows.Forms.DataGridView();
            this.TENMONAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_xóa = new System.Windows.Forms.Button();
            this.button_thanh_toán = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_đồng = new System.Windows.Forms.Label();
            this.textBox_tổng_tiền = new System.Windows.Forms.TextBox();
            this.label_tổng_tiền = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_giỏ_hàng)).BeginInit();
            this.panel7.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1_giỏ_hàng);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(283, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(617, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            this.SOLUONG,
            this.GIATIEN});
            this.dataGridView1_giỏ_hàng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1_giỏ_hàng.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1_giỏ_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1_giỏ_hàng.Name = "dataGridView1_giỏ_hàng";
            this.dataGridView1_giỏ_hàng.ReadOnly = true;
            this.dataGridView1_giỏ_hàng.Size = new System.Drawing.Size(609, 326);
            this.dataGridView1_giỏ_hàng.TabIndex = 0;
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
            // button_xóa
            // 
            this.button_xóa.BackColor = System.Drawing.Color.DarkRed;
            this.button_xóa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_xóa.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xóa.ForeColor = System.Drawing.Color.White;
            this.button_xóa.Location = new System.Drawing.Point(926, 109);
            this.button_xóa.Name = "button_xóa";
            this.button_xóa.Size = new System.Drawing.Size(112, 44);
            this.button_xóa.TabIndex = 3;
            this.button_xóa.Text = "Xóa";
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
            this.button_thanh_toán.TabIndex = 18;
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
            // Giohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button_thanh_toán);
            this.Controls.Add(this.button_xóa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giohang";
            this.Size = new System.Drawing.Size(1191, 598);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_giỏ_hàng)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMONAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.Button button_xóa;
        private System.Windows.Forms.Button button_thanh_toán;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox_tổng_tiền;
        private System.Windows.Forms.Label label_tổng_tiền;
        private System.Windows.Forms.Label label_đồng;
        private System.Windows.Forms.DataGridView dataGridView1_giỏ_hàng;
    }
}
