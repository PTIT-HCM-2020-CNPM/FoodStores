namespace FastFood
{
    partial class NVCHTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVCHTaiKhoan));
            this.button_Luu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label_MatKhauMoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_NhapLaiMatKhaiMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Luu
            // 
            this.button_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Luu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_Luu.ForeColor = System.Drawing.Color.White;
            this.button_Luu.Image = ((System.Drawing.Image)(resources.GetObject("button_Luu.Image")));
            this.button_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Luu.Location = new System.Drawing.Point(485, 272);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(112, 42);
            this.button_Luu.TabIndex = 13;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.Button_Luu_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_MatKhauMoi);
            this.panel5.Controls.Add(this.label_MatKhauMoi);
            this.panel5.Location = new System.Drawing.Point(19, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(578, 51);
            this.panel5.TabIndex = 14;
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(250, 8);
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(318, 22);
            this.textBox_MatKhauMoi.TabIndex = 2;
            this.textBox_MatKhauMoi.UseSystemPasswordChar = true;
            this.textBox_MatKhauMoi.TextChanged += new System.EventHandler(this.TextBox_MatKhauMoi_TextChanged);
            // 
            // label_MatKhauMoi
            // 
            this.label_MatKhauMoi.AutoSize = true;
            this.label_MatKhauMoi.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_MatKhauMoi.ForeColor = System.Drawing.Color.White;
            this.label_MatKhauMoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_MatKhauMoi.Location = new System.Drawing.Point(12, 14);
            this.label_MatKhauMoi.Name = "label_MatKhauMoi";
            this.label_MatKhauMoi.Size = new System.Drawing.Size(119, 20);
            this.label_MatKhauMoi.TabIndex = 0;
            this.label_MatKhauMoi.Text = "Mật Khẩu mới";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_NhapLaiMatKhaiMoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 51);
            this.panel1.TabIndex = 9;
            // 
            // textBox_NhapLaiMatKhaiMoi
            // 
            this.textBox_NhapLaiMatKhaiMoi.Location = new System.Drawing.Point(250, 8);
            this.textBox_NhapLaiMatKhaiMoi.Name = "textBox_NhapLaiMatKhaiMoi";
            this.textBox_NhapLaiMatKhaiMoi.Size = new System.Drawing.Size(318, 22);
            this.textBox_NhapLaiMatKhaiMoi.TabIndex = 2;
            this.textBox_NhapLaiMatKhaiMoi.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Lại Mật Khẩu mới";
            // 
            // NVCHTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button_Luu);
            this.Name = "NVCHTaiKhoan";
            this.Size = new System.Drawing.Size(615, 336);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.Label label_MatKhauMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_NhapLaiMatKhaiMoi;
        private System.Windows.Forms.Label label1;
    }
}
