namespace FastFood
{
    partial class KHBaiDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHBaiDanhGia));
            this.dataGridView_bài_đánh_giá = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_tìm_kiếm = new System.Windows.Forms.TextBox();
            this.button_tìm_kiếm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bài_đánh_giá)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_bài_đánh_giá
            // 
            this.dataGridView_bài_đánh_giá.AllowUserToAddRows = false;
            this.dataGridView_bài_đánh_giá.AllowUserToDeleteRows = false;
            this.dataGridView_bài_đánh_giá.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_bài_đánh_giá.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bài_đánh_giá.BackgroundColor = System.Drawing.Color.Coral;
            this.dataGridView_bài_đánh_giá.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_bài_đánh_giá.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bài_đánh_giá.Location = new System.Drawing.Point(221, 79);
            this.dataGridView_bài_đánh_giá.Name = "dataGridView_bài_đánh_giá";
            this.dataGridView_bài_đánh_giá.ReadOnly = true;
            this.dataGridView_bài_đánh_giá.RowTemplate.Height = 24;
            this.dataGridView_bài_đánh_giá.Size = new System.Drawing.Size(221, 252);
            this.dataGridView_bài_đánh_giá.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_tìm_kiếm);
            this.panel1.Controls.Add(this.button_tìm_kiếm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 31);
            this.panel1.TabIndex = 1;
            // 
            // textBox_tìm_kiếm
            // 
            this.textBox_tìm_kiếm.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_tìm_kiếm.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tìm_kiếm.Location = new System.Drawing.Point(36, 0);
            this.textBox_tìm_kiếm.Name = "textBox_tìm_kiếm";
            this.textBox_tìm_kiếm.Size = new System.Drawing.Size(182, 29);
            this.textBox_tìm_kiếm.TabIndex = 1;
            // 
            // button_tìm_kiếm
            // 
            this.button_tìm_kiếm.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_tìm_kiếm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_tìm_kiếm.Image = ((System.Drawing.Image)(resources.GetObject("button_tìm_kiếm.Image")));
            this.button_tìm_kiếm.Location = new System.Drawing.Point(0, 0);
            this.button_tìm_kiếm.Name = "button_tìm_kiếm";
            this.button_tìm_kiếm.Size = new System.Drawing.Size(36, 31);
            this.button_tìm_kiếm.TabIndex = 0;
            this.button_tìm_kiếm.UseVisualStyleBackColor = true;
            this.button_tìm_kiếm.Click += new System.EventHandler(this.button_tìm_kiếm_Click);
            // 
            // KHBaiDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_bài_đánh_giá);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KHBaiDanhGia";
            this.Size = new System.Drawing.Size(944, 521);
            this.Load += new System.EventHandler(this.KHBaiDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bài_đánh_giá)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bài_đánh_giá;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_tìm_kiếm;
        private System.Windows.Forms.Button button_tìm_kiếm;
    }
}
