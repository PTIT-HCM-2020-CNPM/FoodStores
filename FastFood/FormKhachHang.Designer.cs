namespace FastFood
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Dangxuat = new System.Windows.Forms.Button();
            this.button_giỏ_hàng = new System.Windows.Forms.Button();
            this.button_lịch_sử_hóa_đơn = new System.Windows.Forms.Button();
            this.pnlDropFood = new System.Windows.Forms.Panel();
            this.button_đồ_ăn_nhanh = new System.Windows.Forms.Button();
            this.button_món_chính = new System.Windows.Forms.Button();
            this.button_đồ_ăn = new System.Windows.Forms.Button();
            this.pnlDropDrink = new System.Windows.Forms.Panel();
            this.button_đồ_uống = new System.Windows.Forms.Button();
            this.button_đồ_uống_có_ga = new System.Windows.Forms.Button();
            this.button_cà_phê = new System.Windows.Forms.Button();
            this.button_trang_chủ = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lichsudathang1 = new FastFood.Lichsudathang();
            this.giohang1 = new FastFood.Giohang();
            this.hinhtrangchu1 = new FastFood.Hinhtrangchu();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDropFood.SuspendLayout();
            this.pnlDropDrink.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_Dangxuat);
            this.panel1.Controls.Add(this.button_giỏ_hàng);
            this.panel1.Controls.Add(this.button_lịch_sử_hóa_đơn);
            this.panel1.Controls.Add(this.pnlDropFood);
            this.panel1.Controls.Add(this.pnlDropDrink);
            this.panel1.Controls.Add(this.button_trang_chủ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 590);
            this.panel1.TabIndex = 1;
            // 
            // btn_Dangxuat
            // 
            this.btn_Dangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dangxuat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dangxuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dangxuat.Image")));
            this.btn_Dangxuat.Location = new System.Drawing.Point(0, 444);
            this.btn_Dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dangxuat.Name = "btn_Dangxuat";
            this.btn_Dangxuat.Size = new System.Drawing.Size(154, 49);
            this.btn_Dangxuat.TabIndex = 8;
            this.btn_Dangxuat.Text = " Đăng xuất";
            this.btn_Dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dangxuat.UseVisualStyleBackColor = true;
            this.btn_Dangxuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_giỏ_hàng
            // 
            this.button_giỏ_hàng.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_giỏ_hàng.FlatAppearance.BorderSize = 0;
            this.button_giỏ_hàng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_giỏ_hàng.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_giỏ_hàng.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_giỏ_hàng.Image = ((System.Drawing.Image)(resources.GetObject("button_giỏ_hàng.Image")));
            this.button_giỏ_hàng.Location = new System.Drawing.Point(0, 395);
            this.button_giỏ_hàng.Margin = new System.Windows.Forms.Padding(2);
            this.button_giỏ_hàng.Name = "button_giỏ_hàng";
            this.button_giỏ_hàng.Size = new System.Drawing.Size(154, 49);
            this.button_giỏ_hàng.TabIndex = 7;
            this.button_giỏ_hàng.Text = " Giỏ Hàng";
            this.button_giỏ_hàng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_giỏ_hàng.UseVisualStyleBackColor = true;
            this.button_giỏ_hàng.Click += new System.EventHandler(this.button_giỏ_hàng_Click);
            // 
            // button_lịch_sử_hóa_đơn
            // 
            this.button_lịch_sử_hóa_đơn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_lịch_sử_hóa_đơn.FlatAppearance.BorderSize = 0;
            this.button_lịch_sử_hóa_đơn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lịch_sử_hóa_đơn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lịch_sử_hóa_đơn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_lịch_sử_hóa_đơn.Image = ((System.Drawing.Image)(resources.GetObject("button_lịch_sử_hóa_đơn.Image")));
            this.button_lịch_sử_hóa_đơn.Location = new System.Drawing.Point(0, 346);
            this.button_lịch_sử_hóa_đơn.Margin = new System.Windows.Forms.Padding(2);
            this.button_lịch_sử_hóa_đơn.Name = "button_lịch_sử_hóa_đơn";
            this.button_lịch_sử_hóa_đơn.Size = new System.Drawing.Size(154, 49);
            this.button_lịch_sử_hóa_đơn.TabIndex = 5;
            this.button_lịch_sử_hóa_đơn.Text = "  Lịch sử";
            this.button_lịch_sử_hóa_đơn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lịch_sử_hóa_đơn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_lịch_sử_hóa_đơn.UseVisualStyleBackColor = true;
            this.button_lịch_sử_hóa_đơn.Click += new System.EventHandler(this.button_lịch_sử_hóa_đơn_Click);
            // 
            // pnlDropFood
            // 
            this.pnlDropFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDropFood.Controls.Add(this.button_đồ_ăn_nhanh);
            this.pnlDropFood.Controls.Add(this.button_món_chính);
            this.pnlDropFood.Controls.Add(this.button_đồ_ăn);
            this.pnlDropFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDropFood.Location = new System.Drawing.Point(0, 208);
            this.pnlDropFood.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDropFood.MaximumSize = new System.Drawing.Size(131, 138);
            this.pnlDropFood.MinimumSize = new System.Drawing.Size(131, 49);
            this.pnlDropFood.Name = "pnlDropFood";
            this.pnlDropFood.Size = new System.Drawing.Size(131, 138);
            this.pnlDropFood.TabIndex = 7;
            // 
            // button_đồ_ăn_nhanh
            // 
            this.button_đồ_ăn_nhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_đồ_ăn_nhanh.FlatAppearance.BorderSize = 0;
            this.button_đồ_ăn_nhanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_đồ_ăn_nhanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_đồ_ăn_nhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_đồ_ăn_nhanh.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đồ_ăn_nhanh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_đồ_ăn_nhanh.Location = new System.Drawing.Point(0, 95);
            this.button_đồ_ăn_nhanh.Margin = new System.Windows.Forms.Padding(2);
            this.button_đồ_ăn_nhanh.Name = "button_đồ_ăn_nhanh";
            this.button_đồ_ăn_nhanh.Size = new System.Drawing.Size(131, 46);
            this.button_đồ_ăn_nhanh.TabIndex = 8;
            this.button_đồ_ăn_nhanh.Text = "Thức ăn nhanh";
            this.button_đồ_ăn_nhanh.UseVisualStyleBackColor = true;
            this.button_đồ_ăn_nhanh.Click += new System.EventHandler(this.button_đồ_ăn_nhanh_Click);
            // 
            // button_món_chính
            // 
            this.button_món_chính.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_món_chính.FlatAppearance.BorderSize = 0;
            this.button_món_chính.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_món_chính.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_món_chính.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_món_chính.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_món_chính.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_món_chính.Location = new System.Drawing.Point(0, 49);
            this.button_món_chính.Margin = new System.Windows.Forms.Padding(2);
            this.button_món_chính.Name = "button_món_chính";
            this.button_món_chính.Size = new System.Drawing.Size(131, 46);
            this.button_món_chính.TabIndex = 7;
            this.button_món_chính.Text = "Món chính";
            this.button_món_chính.UseVisualStyleBackColor = true;
            this.button_món_chính.Click += new System.EventHandler(this.button_món_chính_Click);
            // 
            // button_đồ_ăn
            // 
            this.button_đồ_ăn.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_đồ_ăn.FlatAppearance.BorderSize = 0;
            this.button_đồ_ăn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_đồ_ăn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_đồ_ăn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_đồ_ăn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đồ_ăn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_đồ_ăn.Image = ((System.Drawing.Image)(resources.GetObject("button_đồ_ăn.Image")));
            this.button_đồ_ăn.Location = new System.Drawing.Point(0, 0);
            this.button_đồ_ăn.Margin = new System.Windows.Forms.Padding(2);
            this.button_đồ_ăn.MaximumSize = new System.Drawing.Size(131, 138);
            this.button_đồ_ăn.MinimumSize = new System.Drawing.Size(131, 49);
            this.button_đồ_ăn.Name = "button_đồ_ăn";
            this.button_đồ_ăn.Size = new System.Drawing.Size(131, 49);
            this.button_đồ_ăn.TabIndex = 3;
            this.button_đồ_ăn.Text = "  Đồ ăn";
            this.button_đồ_ăn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_đồ_ăn.UseVisualStyleBackColor = true;
            // 
            // pnlDropDrink
            // 
            this.pnlDropDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDropDrink.Controls.Add(this.button_đồ_uống);
            this.pnlDropDrink.Controls.Add(this.button_đồ_uống_có_ga);
            this.pnlDropDrink.Controls.Add(this.button_cà_phê);
            this.pnlDropDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDropDrink.Location = new System.Drawing.Point(0, 57);
            this.pnlDropDrink.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDropDrink.Name = "pnlDropDrink";
            this.pnlDropDrink.Size = new System.Drawing.Size(154, 151);
            this.pnlDropDrink.TabIndex = 5;
            // 
            // button_đồ_uống
            // 
            this.button_đồ_uống.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_đồ_uống.FlatAppearance.BorderSize = 0;
            this.button_đồ_uống.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_đồ_uống.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_đồ_uống.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_đồ_uống.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đồ_uống.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_đồ_uống.Image = ((System.Drawing.Image)(resources.GetObject("button_đồ_uống.Image")));
            this.button_đồ_uống.Location = new System.Drawing.Point(0, 0);
            this.button_đồ_uống.Margin = new System.Windows.Forms.Padding(2);
            this.button_đồ_uống.Name = "button_đồ_uống";
            this.button_đồ_uống.Size = new System.Drawing.Size(154, 50);
            this.button_đồ_uống.TabIndex = 2;
            this.button_đồ_uống.Text = "   Đồ uống";
            this.button_đồ_uống.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_đồ_uống.UseVisualStyleBackColor = true;
            // 
            // button_đồ_uống_có_ga
            // 
            this.button_đồ_uống_có_ga.FlatAppearance.BorderSize = 0;
            this.button_đồ_uống_có_ga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_đồ_uống_có_ga.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_đồ_uống_có_ga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_đồ_uống_có_ga.Location = new System.Drawing.Point(0, 102);
            this.button_đồ_uống_có_ga.Margin = new System.Windows.Forms.Padding(2);
            this.button_đồ_uống_có_ga.Name = "button_đồ_uống_có_ga";
            this.button_đồ_uống_có_ga.Size = new System.Drawing.Size(154, 48);
            this.button_đồ_uống_có_ga.TabIndex = 6;
            this.button_đồ_uống_có_ga.Text = "Đồ uống có ga";
            this.button_đồ_uống_có_ga.UseVisualStyleBackColor = true;
            this.button_đồ_uống_có_ga.Click += new System.EventHandler(this.button_đồ_uống_có_ga_Click);
            // 
            // button_cà_phê
            // 
            this.button_cà_phê.FlatAppearance.BorderSize = 0;
            this.button_cà_phê.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cà_phê.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cà_phê.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cà_phê.Location = new System.Drawing.Point(0, 54);
            this.button_cà_phê.Margin = new System.Windows.Forms.Padding(2);
            this.button_cà_phê.Name = "button_cà_phê";
            this.button_cà_phê.Size = new System.Drawing.Size(154, 49);
            this.button_cà_phê.TabIndex = 5;
            this.button_cà_phê.Text = "Cà phê";
            this.button_cà_phê.UseVisualStyleBackColor = true;
            this.button_cà_phê.Click += new System.EventHandler(this.button_cà_phê_Click);
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
            this.button_trang_chủ.Location = new System.Drawing.Point(0, 0);
            this.button_trang_chủ.Name = "button_trang_chủ";
            this.button_trang_chủ.Size = new System.Drawing.Size(154, 57);
            this.button_trang_chủ.TabIndex = 1;
            this.button_trang_chủ.Text = "  Trang chủ";
            this.button_trang_chủ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trang_chủ.UseVisualStyleBackColor = true;
            this.button_trang_chủ.Click += new System.EventHandler(this.button_trang_chủ_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 51);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(597, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hotline:0123456789";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lichsudathang1);
            this.panel3.Controls.Add(this.giohang1);
            this.panel3.Controls.Add(this.hinhtrangchu1);
            this.panel3.Location = new System.Drawing.Point(154, 153);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 437);
            this.panel3.TabIndex = 3;
            // 
            // lichsudathang1
            // 
            this.lichsudathang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lichsudathang1.Location = new System.Drawing.Point(0, 0);
            this.lichsudathang1.Name = "lichsudathang1";
            this.lichsudathang1.Size = new System.Drawing.Size(753, 437);
            this.lichsudathang1.TabIndex = 7;
            // 
            // giohang1
            // 
            this.giohang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giohang1.Location = new System.Drawing.Point(0, 0);
            this.giohang1.Name = "giohang1";
            this.giohang1.Size = new System.Drawing.Size(753, 437);
            this.giohang1.TabIndex = 6;
            // 
            // hinhtrangchu1
            // 
            this.hinhtrangchu1.AllowDrop = true;
            this.hinhtrangchu1.AutoSize = true;
            this.hinhtrangchu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hinhtrangchu1.BackColor = System.Drawing.Color.Red;
            this.hinhtrangchu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhtrangchu1.Location = new System.Drawing.Point(0, 0);
            this.hinhtrangchu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hinhtrangchu1.Name = "hinhtrangchu1";
            this.hinhtrangchu1.Size = new System.Drawing.Size(753, 437);
            this.hinhtrangchu1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(188, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 134);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Restaurant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodHouse";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDropFood.ResumeLayout(false);
            this.pnlDropDrink.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDropFood;
        private System.Windows.Forms.Button button_đồ_ăn_nhanh;
        private System.Windows.Forms.Button button_món_chính;
        private System.Windows.Forms.Button button_đồ_ăn;
        private System.Windows.Forms.Panel pnlDropDrink;
        private System.Windows.Forms.Button button_đồ_uống;
        private System.Windows.Forms.Button button_đồ_uống_có_ga;
        private System.Windows.Forms.Button button_cà_phê;
        private System.Windows.Forms.Button button_trang_chủ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private Hinhtrangchu hinhtrangchu1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lịch_sử_hóa_đơn;
        private System.Windows.Forms.Button button_giỏ_hàng;
        private System.Windows.Forms.Button btn_Dangxuat;
        private Giohang giohang1;
        private Lichsudathang lichsudathang1;
    }
}