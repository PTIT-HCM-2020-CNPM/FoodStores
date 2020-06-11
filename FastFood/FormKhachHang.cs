using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormKhachHang : System.Windows.Forms.Form
    {
        private string numCus;
        public int stoSelectedIndex;
        private string storeID;
        public static List<DataRow> GioHang = new List<DataRow>();
        public FormKhachHang(string numberPCustomer)
        {
            InitializeComponent();
            hinhtrangchu1.BringToFront();
            //Chuyển sđt kh từ formkh -> giohang
            giohang1.numberPhone = numberPCustomer;
            //chuyển index selected store ->giỏ hàng
            giohang1.storeIndex = stoSelectedIndex;
            //Chuyển sđt kh từ formkh -> lich su dat hang
            lichsudathang1.customerNumber =numberPCustomer;
            //Chuyển sđt kh từ formkh -> đổi mật khẩu
            khMatKhau1.userName = numberPCustomer;
            // Chuyển sđt kh từ formkh -> đánh giá
            khBaiDanhGia1.customerNumber = numberPCustomer;
            numCus = numberPCustomer;          
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            pnlDropFood.Height = 55;
            pnlDropDrink.Height = 55;
            panelDrpReview.Height = 55;
            FormChoncuahang formChoncuahang = new FormChoncuahang();
            formChoncuahang.ShowDialog();
            textBox_địa_chỉ_cửa_hàng.Text = formChoncuahang.storeAddress;
            stoSelectedIndex=formChoncuahang.storeIndex;
            storeID = formChoncuahang.storeID;
            
            giohang1.storeID = formChoncuahang.storeID;
        }
        //Hiển thị nút con đồ ăn
        private void button_đồ_uống_Click(object sender, EventArgs e)
        {
            if (pnlDropDrink.Height == 190)
            {
                pnlDropDrink.Height = 60;
            }
            else { pnlDropDrink.Height = 190; }
        }       
        //CÀ PHÊ
        private void button_cà_phê_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("CF");
            panel3.Controls.Add(monan);
            monan.storeNum = storeID;
            monan.BringToFront();
        }
        //NƯỚC NGỌT
        private void button_đồ_uống_có_ga_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("DU");
            panel3.Controls.Add(monan);
            monan.storeNum = storeID;
            monan.BringToFront();
        }
        //Hiển thị nút con đồ ăn
        private void button_đồ_ăn_Click(object sender, EventArgs e)
        {
            if (pnlDropFood.Height == 180)
            {
                pnlDropFood.Height = 60;
            }
            else { pnlDropFood.Height = 180; }
        }
        //MÓN CHÍNH
        private void button_món_chính_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("MC");
            panel3.Controls.Add(monan);
            monan.storeNum = storeID;
            monan.BringToFront();
        }
        //ĐỒ ĂN NHANH
        private void button_đồ_ăn_nhanh_Click(object sender, EventArgs e)
        {
            MonAn monan = new MonAn("AV");
            panel3.Controls.Add(monan);
            monan.storeNum = storeID;
            monan.BringToFront();
        }
        //TRANG CHỦ
        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            hinhtrangchu1.BringToFront();
        }
        //GIỎ HÀNG
        private void button_giỏ_hàng_Click(object sender, EventArgs e)
        {           
            giohang1.BringToFront();
            giohang1.Giohang_Load(null, EventArgs.Empty);
            giohang1.storeIndex = stoSelectedIndex;
        }
        //THOÁT VÀ HIỆN LẠI TRANG CHỦ
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Trangchu trangchu = new Trangchu();
            //trangchu.ShowDialog();
        }
        //LIỆT KÊ HÓA ĐƠN ĐÃ ĐẶT ONLINE
        private void button_lịch_sử_hóa_đơn_Click(object sender, EventArgs e)
        {  
            lichsudathang1.BringToFront();
            
        }   
        //ĐỔI MẬT KHẨU KHÁCH HÀNG
        private void button_đổi_mật_khẩu_Click(object sender, EventArgs e)
        {

            khMatKhau1.BringToFront();
        }
        //Bài đánh giá
        private void button_bài_đánh_giá_Click(object sender, EventArgs e)
        {
            if (panelDrpReview.Height == 190)
            {
                panelDrpReview.Height = 60;
            }
            else { panelDrpReview.Height = 190; }
        }
        private void button_Vđánh_giá_Click(object sender, EventArgs e)
        {
            FormDanhGia formDanhGia = new FormDanhGia();
            formDanhGia.numCus = numCus;
            formDanhGia.ShowDialog();
        }

        private void button_ds_đánh_giá_Click(object sender, EventArgs e)
        {
            khBaiDanhGia1.BringToFront();
        }

        private void button_kt_trạng_thái_Click(object sender, EventArgs e)
        {
            FormKHKiemtradonhang formKHKiemtradonhang = new FormKHKiemtradonhang();
            formKHKiemtradonhang.numCus = numCus;
            formKHKiemtradonhang.ShowDialog();
        }
        //Thay đổi giá trị địa chỉ cửa hàng
        private void button_thay_đổi_Click(object sender, EventArgs e)
        {
            FormChoncuahang formChoncuahang = new FormChoncuahang();
            formChoncuahang.ShowDialog();
            textBox_địa_chỉ_cửa_hàng.Text = formChoncuahang.storeAddress;
            giohang1.storeIndex = formChoncuahang.storeIndex;
            storeID= formChoncuahang.storeID;
            
            giohang1.storeID = formChoncuahang.storeID;
        }
    }
}
