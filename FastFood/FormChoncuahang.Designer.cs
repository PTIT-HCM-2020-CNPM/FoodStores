namespace FastFood
{
    partial class FormChoncuahang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_cửa_hàng = new System.Windows.Forms.ComboBox();
            this.button_bắt_đặt_hàng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẮT ĐẦU ĐẶT HÀNG";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vui lòng chọn cửa hàng mà quý khách muốn đặt hàng";
            // 
            // comboBox_cửa_hàng
            // 
            this.comboBox_cửa_hàng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_cửa_hàng.BackColor = System.Drawing.Color.Coral;
            this.comboBox_cửa_hàng.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cửa_hàng.ForeColor = System.Drawing.Color.White;
            this.comboBox_cửa_hàng.FormattingEnabled = true;
            this.comboBox_cửa_hàng.Items.AddRange(new object[] {
            "Chọn cửa hàng"});
            this.comboBox_cửa_hàng.Location = new System.Drawing.Point(170, 153);
            this.comboBox_cửa_hàng.Name = "comboBox_cửa_hàng";
            this.comboBox_cửa_hàng.Size = new System.Drawing.Size(265, 35);
            this.comboBox_cửa_hàng.TabIndex = 2;
            // 
            // button_bắt_đặt_hàng
            // 
            this.button_bắt_đặt_hàng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bắt_đặt_hàng.BackColor = System.Drawing.Color.DarkRed;
            this.button_bắt_đặt_hàng.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bắt_đặt_hàng.ForeColor = System.Drawing.Color.White;
            this.button_bắt_đặt_hàng.Location = new System.Drawing.Point(170, 226);
            this.button_bắt_đặt_hàng.Name = "button_bắt_đặt_hàng";
            this.button_bắt_đặt_hàng.Size = new System.Drawing.Size(265, 48);
            this.button_bắt_đặt_hàng.TabIndex = 3;
            this.button_bắt_đặt_hàng.Text = "Bắt đầu đặt hàng";
            this.button_bắt_đặt_hàng.UseVisualStyleBackColor = false;
            this.button_bắt_đặt_hàng.Click += new System.EventHandler(this.button_bắt_đặt_hàng_Click);
            // 
            // FormChoncuahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(606, 321);
            this.Controls.Add(this.button_bắt_đặt_hàng);
            this.Controls.Add(this.comboBox_cửa_hàng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChoncuahang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChoncuahang";
            this.Load += new System.EventHandler(this.FormChoncuahang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_cửa_hàng;
        private System.Windows.Forms.Button button_bắt_đặt_hàng;
    }
}