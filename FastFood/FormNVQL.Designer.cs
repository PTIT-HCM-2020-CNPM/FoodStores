namespace FastFood
{
    partial class FormNVQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary> g
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNVQL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_đăng_xuất = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_chọn = new System.Windows.Forms.Panel();
            this.button_cửa_hàng = new System.Windows.Forms.Button();
            this.button_món_ăn = new System.Windows.Forms.Button();
            this.button_mật_khẩu = new System.Windows.Forms.Button();
            this.button_doanh_thu = new System.Windows.Forms.Button();
            this.button_đơn_hàng = new System.Windows.Forms.Button();
            this.button_tạo_tài_khoản = new System.Windows.Forms.Button();
            this.button_trang_chủ = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nvqlMonAn1 = new FastFood.NVQLMonAn();
            this.nvqlMatKhau1 = new FastFood.NVQLMatKhau();
            this.nvqlDonHang1 = new FastFood.NVQLDonHang();
            this.nvqlQuanLyTaiKhoan1 = new FastFood.NVQLQuanLyTaiKhoan();
            this.nvqlCuaHang1 = new FastFood.NVQLCuaHang();
            this.nvqlDoanhThu1 = new FastFood.NVQLDoanhThu();
            this.hinhtrangchu1 = new FastFood.Hinhtrangchu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button_đăng_xuất);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(212, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 63);
            this.panel1.TabIndex = 1;
            // 
            // button_đăng_xuất
            // 
            this.button_đăng_xuất.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_đăng_xuất.FlatAppearance.BorderSize = 0;
            this.button_đăng_xuất.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_đăng_xuất.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đăng_xuất.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_đăng_xuất.Image = ((System.Drawing.Image)(resources.GetObject("button_đăng_xuất.Image")));
            this.button_đăng_xuất.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_đăng_xuất.Location = new System.Drawing.Point(789, 0);
            this.button_đăng_xuất.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_đăng_xuất.Name = "button_đăng_xuất";
            this.button_đăng_xuất.Size = new System.Drawing.Size(172, 63);
            this.button_đăng_xuất.TabIndex = 10;
            this.button_đăng_xuất.Text = " Đăng xuất";
            this.button_đăng_xuất.UseVisualStyleBackColor = true;
            this.button_đăng_xuất.Click += new System.EventHandler(this.button_đăng_xuất_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel_chọn);
            this.panel2.Controls.Add(this.button_cửa_hàng);
            this.panel2.Controls.Add(this.button_món_ăn);
            this.panel2.Controls.Add(this.button_mật_khẩu);
            this.panel2.Controls.Add(this.button_doanh_thu);
            this.panel2.Controls.Add(this.button_đơn_hàng);
            this.panel2.Controls.Add(this.button_tạo_tài_khoản);
            this.panel2.Controls.Add(this.button_trang_chủ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 751);
            this.panel2.TabIndex = 2;
            // 
            // panel_chọn
            // 
            this.panel_chọn.BackColor = System.Drawing.Color.Red;
            this.panel_chọn.Location = new System.Drawing.Point(3, 0);
            this.panel_chọn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_chọn.Name = "panel_chọn";
            this.panel_chọn.Size = new System.Drawing.Size(16, 70);
            this.panel_chọn.TabIndex = 5;
            // 
            // button_cửa_hàng
            // 
            this.button_cửa_hàng.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cửa_hàng.FlatAppearance.BorderSize = 0;
            this.button_cửa_hàng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_cửa_hàng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_cửa_hàng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cửa_hàng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cửa_hàng.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cửa_hàng.Image = ((System.Drawing.Image)(resources.GetObject("button_cửa_hàng.Image")));
            this.button_cửa_hàng.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cửa_hàng.Location = new System.Drawing.Point(0, 420);
            this.button_cửa_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.button_cửa_hàng.Name = "button_cửa_hàng";
            this.button_cửa_hàng.Size = new System.Drawing.Size(212, 70);
            this.button_cửa_hàng.TabIndex = 7;
            this.button_cửa_hàng.Text = "Cửa hàng";
            this.button_cửa_hàng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cửa_hàng.UseVisualStyleBackColor = true;
            this.button_cửa_hàng.Click += new System.EventHandler(this.button_cửa_hàng_Click);
            // 
            // button_món_ăn
            // 
            this.button_món_ăn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_món_ăn.FlatAppearance.BorderSize = 0;
            this.button_món_ăn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_món_ăn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_món_ăn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_món_ăn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_món_ăn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_món_ăn.Image = ((System.Drawing.Image)(resources.GetObject("button_món_ăn.Image")));
            this.button_món_ăn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_món_ăn.Location = new System.Drawing.Point(0, 350);
            this.button_món_ăn.Margin = new System.Windows.Forms.Padding(4);
            this.button_món_ăn.Name = "button_món_ăn";
            this.button_món_ăn.Size = new System.Drawing.Size(212, 70);
            this.button_món_ăn.TabIndex = 6;
            this.button_món_ăn.Text = "Món ăn";
            this.button_món_ăn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_món_ăn.UseVisualStyleBackColor = true;
            this.button_món_ăn.Click += new System.EventHandler(this.button_món_ăn_Click);
            // 
            // button_mật_khẩu
            // 
            this.button_mật_khẩu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_mật_khẩu.FlatAppearance.BorderSize = 0;
            this.button_mật_khẩu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_mật_khẩu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_mật_khẩu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mật_khẩu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mật_khẩu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_mật_khẩu.Image = ((System.Drawing.Image)(resources.GetObject("button_mật_khẩu.Image")));
            this.button_mật_khẩu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_mật_khẩu.Location = new System.Drawing.Point(0, 280);
            this.button_mật_khẩu.Margin = new System.Windows.Forms.Padding(4);
            this.button_mật_khẩu.Name = "button_mật_khẩu";
            this.button_mật_khẩu.Size = new System.Drawing.Size(212, 70);
            this.button_mật_khẩu.TabIndex = 5;
            this.button_mật_khẩu.Text = "Mật khẩu";
            this.button_mật_khẩu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_mật_khẩu.UseVisualStyleBackColor = true;
            this.button_mật_khẩu.Click += new System.EventHandler(this.button_mật_khẩu_Click);
            // 
            // button_doanh_thu
            // 
            this.button_doanh_thu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_doanh_thu.FlatAppearance.BorderSize = 0;
            this.button_doanh_thu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_doanh_thu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_doanh_thu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doanh_thu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doanh_thu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_doanh_thu.Image = ((System.Drawing.Image)(resources.GetObject("button_doanh_thu.Image")));
            this.button_doanh_thu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_doanh_thu.Location = new System.Drawing.Point(0, 210);
            this.button_doanh_thu.Margin = new System.Windows.Forms.Padding(4);
            this.button_doanh_thu.Name = "button_doanh_thu";
            this.button_doanh_thu.Size = new System.Drawing.Size(212, 70);
            this.button_doanh_thu.TabIndex = 4;
            this.button_doanh_thu.Text = "Doanh thu";
            this.button_doanh_thu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_doanh_thu.UseVisualStyleBackColor = true;
            this.button_doanh_thu.Click += new System.EventHandler(this.button_doanh_thu_Click);
            // 
            // button_đơn_hàng
            // 
            this.button_đơn_hàng.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_đơn_hàng.FlatAppearance.BorderSize = 0;
            this.button_đơn_hàng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_đơn_hàng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_đơn_hàng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_đơn_hàng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đơn_hàng.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_đơn_hàng.Image = ((System.Drawing.Image)(resources.GetObject("button_đơn_hàng.Image")));
            this.button_đơn_hàng.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_đơn_hàng.Location = new System.Drawing.Point(0, 140);
            this.button_đơn_hàng.Margin = new System.Windows.Forms.Padding(4);
            this.button_đơn_hàng.Name = "button_đơn_hàng";
            this.button_đơn_hàng.Size = new System.Drawing.Size(212, 70);
            this.button_đơn_hàng.TabIndex = 3;
            this.button_đơn_hàng.Text = "Đơn hàng";
            this.button_đơn_hàng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_đơn_hàng.UseVisualStyleBackColor = true;
            this.button_đơn_hàng.Click += new System.EventHandler(this.button_đơn_hàng_Click);
            // 
            // button_tạo_tài_khoản
            // 
            this.button_tạo_tài_khoản.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_tạo_tài_khoản.FlatAppearance.BorderSize = 0;
            this.button_tạo_tài_khoản.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_tạo_tài_khoản.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_tạo_tài_khoản.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tạo_tài_khoản.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tạo_tài_khoản.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_tạo_tài_khoản.Image = ((System.Drawing.Image)(resources.GetObject("button_tạo_tài_khoản.Image")));
            this.button_tạo_tài_khoản.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_tạo_tài_khoản.Location = new System.Drawing.Point(0, 70);
            this.button_tạo_tài_khoản.Margin = new System.Windows.Forms.Padding(4);
            this.button_tạo_tài_khoản.Name = "button_tạo_tài_khoản";
            this.button_tạo_tài_khoản.Size = new System.Drawing.Size(212, 70);
            this.button_tạo_tài_khoản.TabIndex = 2;
            this.button_tạo_tài_khoản.Text = "Nhân viên";
            this.button_tạo_tài_khoản.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tạo_tài_khoản.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_tạo_tài_khoản.UseVisualStyleBackColor = true;
            this.button_tạo_tài_khoản.Click += new System.EventHandler(this.button_tạo_tài_khoản_Click);
            // 
            // button_trang_chủ
            // 
            this.button_trang_chủ.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_trang_chủ.FlatAppearance.BorderSize = 0;
            this.button_trang_chủ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_trang_chủ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_trang_chủ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trang_chủ.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trang_chủ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_trang_chủ.Image = ((System.Drawing.Image)(resources.GetObject("button_trang_chủ.Image")));
            this.button_trang_chủ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_trang_chủ.Location = new System.Drawing.Point(0, 0);
            this.button_trang_chủ.Margin = new System.Windows.Forms.Padding(4);
            this.button_trang_chủ.Name = "button_trang_chủ";
            this.button_trang_chủ.Size = new System.Drawing.Size(212, 70);
            this.button_trang_chủ.TabIndex = 1;
            this.button_trang_chủ.Text = "Trang chủ";
            this.button_trang_chủ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trang_chủ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trang_chủ.UseVisualStyleBackColor = true;
            this.button_trang_chủ.Click += new System.EventHandler(this.button_trang_chủ_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Red;
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Controls.Add(this.label2);
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Location = new System.Drawing.Point(219, 14);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(203, 165);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(51, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Restaurant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodHouse";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.nvqlMonAn1);
            this.panel3.Controls.Add(this.nvqlMatKhau1);
            this.panel3.Controls.Add(this.nvqlDonHang1);
            this.panel3.Controls.Add(this.nvqlQuanLyTaiKhoan1);
            this.panel3.Controls.Add(this.nvqlCuaHang1);
            this.panel3.Controls.Add(this.nvqlDoanhThu1);
            this.panel3.Controls.Add(this.hinhtrangchu1);
            this.panel3.Location = new System.Drawing.Point(212, 210);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 541);
            this.panel3.TabIndex = 4;
            // 
            // nvqlMonAn1
            // 
            this.nvqlMonAn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlMonAn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvqlMonAn1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvqlMonAn1.ForeColor = System.Drawing.Color.Black;
            this.nvqlMonAn1.Location = new System.Drawing.Point(0, 0);
            this.nvqlMonAn1.Margin = new System.Windows.Forms.Padding(4);
            this.nvqlMonAn1.Name = "nvqlMonAn1";
            this.nvqlMonAn1.Size = new System.Drawing.Size(961, 541);
            this.nvqlMonAn1.TabIndex = 13;
            // 
            // nvqlMatKhau1
            // 
            this.nvqlMatKhau1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlMatKhau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvqlMatKhau1.Location = new System.Drawing.Point(0, 0);
            this.nvqlMatKhau1.Name = "nvqlMatKhau1";
            this.nvqlMatKhau1.Size = new System.Drawing.Size(961, 541);
            this.nvqlMatKhau1.TabIndex = 11;
            // 
            // nvqlDonHang1
            // 
            this.nvqlDonHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlDonHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvqlDonHang1.Location = new System.Drawing.Point(0, 0);
            this.nvqlDonHang1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nvqlDonHang1.Name = "nvqlDonHang1";
            this.nvqlDonHang1.Size = new System.Drawing.Size(961, 541);
            this.nvqlDonHang1.TabIndex = 10;
            // 
            // nvqlQuanLyTaiKhoan1
            // 
            this.nvqlQuanLyTaiKhoan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlQuanLyTaiKhoan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvqlQuanLyTaiKhoan1.Location = new System.Drawing.Point(0, 0);
            this.nvqlQuanLyTaiKhoan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nvqlQuanLyTaiKhoan1.Name = "nvqlQuanLyTaiKhoan1";
            this.nvqlQuanLyTaiKhoan1.Size = new System.Drawing.Size(961, 541);
            this.nvqlQuanLyTaiKhoan1.TabIndex = 9;
            // 
            // nvqlCuaHang1
            // 
            this.nvqlCuaHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlCuaHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvqlCuaHang1.Location = new System.Drawing.Point(0, 0);
            this.nvqlCuaHang1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nvqlCuaHang1.Name = "nvqlCuaHang1";
            this.nvqlCuaHang1.Size = new System.Drawing.Size(961, 541);
            this.nvqlCuaHang1.TabIndex = 8;
            this.nvqlCuaHang1.Load += new System.EventHandler(this.nvqlCuaHang1_Load);
            // 
            // nvqlDoanhThu1
            // 
            this.nvqlDoanhThu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nvqlDoanhThu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nvqlDoanhThu1.Location = new System.Drawing.Point(0, 0);
            this.nvqlDoanhThu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nvqlDoanhThu1.Name = "nvqlDoanhThu1";
            this.nvqlDoanhThu1.Size = new System.Drawing.Size(961, 541);
            this.nvqlDoanhThu1.TabIndex = 7;
            // 
            // hinhtrangchu1
            // 
            this.hinhtrangchu1.AllowDrop = true;
            this.hinhtrangchu1.AutoSize = true;
            this.hinhtrangchu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hinhtrangchu1.BackColor = System.Drawing.Color.Red;
            this.hinhtrangchu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhtrangchu1.Location = new System.Drawing.Point(0, 0);
            this.hinhtrangchu1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.hinhtrangchu1.Name = "hinhtrangchu1";
            this.hinhtrangchu1.Size = new System.Drawing.Size(961, 541);
            this.hinhtrangchu1.TabIndex = 6;
            this.hinhtrangchu1.Load += new System.EventHandler(this.hinhtrangchu1_Load);
            // 
            // FormNVQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1173, 751);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1173, 751);
            this.Name = "FormNVQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NVQL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNVQL_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_tạo_tài_khoản;
        private System.Windows.Forms.Button button_trang_chủ;
        private System.Windows.Forms.Button button_doanh_thu;
        private System.Windows.Forms.Button button_cửa_hàng;
        private System.Windows.Forms.Button button_đơn_hàng;
        private System.Windows.Forms.Panel panel_chọn;
        private Hinhtrangchu hinhtrangchu1;
        private NVQLDoanhThu nvqlDoanhThu1;
        private NVQLCuaHang nvqlCuaHang1;
        private NVQLQuanLyTaiKhoan nvqlQuanLyTaiKhoan1;
        private NVQLDonHang nvqlDonHang1;
        private System.Windows.Forms.Button button_đăng_xuất;
        private System.Windows.Forms.Button button_mật_khẩu;
        private NVQLMatKhau nvqlMatKhau1;
        private System.Windows.Forms.Button button_món_ăn;
        private NVQLMonAn nvqlMonAn1;
    }
}