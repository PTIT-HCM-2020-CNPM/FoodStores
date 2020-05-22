namespace FastFood
{
    partial class NVQLDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVQLDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_doanh_thu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_xuất_excel = new System.Windows.Forms.Button();
            this.button_thống_kê = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_kết_thúc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_bắt_đầu = new System.Windows.Forms.DateTimePicker();
            this.comboBox_doanh_thu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanh_thu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView_doanh_thu);
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 365);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_doanh_thu
            // 
            this.dataGridView_doanh_thu.AllowUserToAddRows = false;
            this.dataGridView_doanh_thu.AllowUserToDeleteRows = false;
            this.dataGridView_doanh_thu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_doanh_thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doanh_thu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_doanh_thu.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_doanh_thu.Name = "dataGridView_doanh_thu";
            this.dataGridView_doanh_thu.ReadOnly = true;
            this.dataGridView_doanh_thu.RowTemplate.Height = 24;
            this.dataGridView_doanh_thu.Size = new System.Drawing.Size(944, 365);
            this.dataGridView_doanh_thu.TabIndex = 0;
            this.dataGridView_doanh_thu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_doanh_thu);
            this.panel2.Controls.Add(this.button_xuất_excel);
            this.panel2.Controls.Add(this.button_thống_kê);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker_kết_thúc);
            this.panel2.Controls.Add(this.dateTimePicker_bắt_đầu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 115);
            this.panel2.TabIndex = 1;
            // 
            // button_xuất_excel
            // 
            this.button_xuất_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_xuất_excel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuất_excel.ForeColor = System.Drawing.Color.White;
            this.button_xuất_excel.Image = ((System.Drawing.Image)(resources.GetObject("button_xuất_excel.Image")));
            this.button_xuất_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xuất_excel.Location = new System.Drawing.Point(702, 68);
            this.button_xuất_excel.Name = "button_xuất_excel";
            this.button_xuất_excel.Size = new System.Drawing.Size(190, 42);
            this.button_xuất_excel.TabIndex = 5;
            this.button_xuất_excel.Text = "Xuất excel";
            this.button_xuất_excel.UseVisualStyleBackColor = true;
            // 
            // button_thống_kê
            // 
            this.button_thống_kê.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_thống_kê.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thống_kê.ForeColor = System.Drawing.Color.White;
            this.button_thống_kê.Image = ((System.Drawing.Image)(resources.GetObject("button_thống_kê.Image")));
            this.button_thống_kê.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thống_kê.Location = new System.Drawing.Point(13, 68);
            this.button_thống_kê.Name = "button_thống_kê";
            this.button_thống_kê.Size = new System.Drawing.Size(190, 42);
            this.button_thống_kê.TabIndex = 4;
            this.button_thống_kê.Text = "Thống kê";
            this.button_thống_kê.UseVisualStyleBackColor = true;
            this.button_thống_kê.Click += new System.EventHandler(this.button_thống_kê_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // dateTimePicker_kết_thúc
            // 
            this.dateTimePicker_kết_thúc.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_kết_thúc.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_kết_thúc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_kết_thúc.Location = new System.Drawing.Point(271, 17);
            this.dateTimePicker_kết_thúc.Name = "dateTimePicker_kết_thúc";
            this.dateTimePicker_kết_thúc.Size = new System.Drawing.Size(142, 27);
            this.dateTimePicker_kết_thúc.TabIndex = 2;
            // 
            // dateTimePicker_bắt_đầu
            // 
            this.dateTimePicker_bắt_đầu.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_bắt_đầu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_bắt_đầu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_bắt_đầu.Location = new System.Drawing.Point(50, 19);
            this.dateTimePicker_bắt_đầu.Name = "dateTimePicker_bắt_đầu";
            this.dateTimePicker_bắt_đầu.Size = new System.Drawing.Size(142, 27);
            this.dateTimePicker_bắt_đầu.TabIndex = 1;
            // 
            // comboBox_doanh_thu
            // 
            this.comboBox_doanh_thu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_doanh_thu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_doanh_thu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_doanh_thu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_doanh_thu.FormattingEnabled = true;
            this.comboBox_doanh_thu.Items.AddRange(new object[] {
            "Doanh thu mỗi cửa hàng",
            "Số lượng mỗi món ăn bán ra",
            "Tổng số tiền đơn hàng của chuỗi cửa hàng"});
            this.comboBox_doanh_thu.Location = new System.Drawing.Point(209, 79);
            this.comboBox_doanh_thu.Name = "comboBox_doanh_thu";
            this.comboBox_doanh_thu.Size = new System.Drawing.Size(427, 28);
            this.comboBox_doanh_thu.Sorted = true;
            this.comboBox_doanh_thu.TabIndex = 3;
            this.comboBox_doanh_thu.SelectedValueChanged += new System.EventHandler(this.comboBox_doanh_thu_SelectedValueChanged);
            // 
            // NVQLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NVQLDoanhThu";
            this.Size = new System.Drawing.Size(944, 486);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doanh_thu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_doanh_thu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kết_thúc;
        private System.Windows.Forms.DateTimePicker dateTimePicker_bắt_đầu;
        private System.Windows.Forms.Button button_thống_kê;
        private System.Windows.Forms.Button button_xuất_excel;
        private System.Windows.Forms.ComboBox comboBox_doanh_thu;
    }
}
