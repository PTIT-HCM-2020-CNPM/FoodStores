using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.DAL_DataLayer;

namespace FastFood
{
    public partial class FormNVCH : System.Windows.Forms.Form
    {
        public FormNVCH()
        {
            InitializeComponent();
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.BringToFront();

        }
        // ham lay du lieu taikhoan ,mat khau dang nhap tu ben formdangnhap de xac dinh Cua hang dang dang nhap vao
        string taiKhoan;
        string matKhauCu;
        public string nhan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public string layMatKhauCuFormNVCH
        {
            get { return matKhauCu; }
            set { matKhauCu = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_trang_chủ_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_trang_chủ.Height;
            panel_chọn.Top = button_trang_chủ.Top;
            hinhtrangchu1.Show();
            hinhtrangchu1.BringToFront();

            // xoa don hang chua thanh toan khi bam sang muc khac 
            xoaDonChuaThanhToan();

        }

        private void button_tạo_tài_khoản_Click(object sender, EventArgs e)
        {

        }

        private void button_món_ăn_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_món_ăn.Height;
            panel_chọn.Top = button_món_ăn.Top;
            nvchDanhSachMonAn1.Show();
            // lay cua hang hien tai dang dang nhap qua usercontrol danhsachmonan
            nvchDanhSachMonAn1.layCuaHangHienTai = taiKhoan.Substring(0, 3);
            nvchDanhSachMonAn1.hienDanhSachMonAn(taiKhoan.Substring(0, 3));
            nvchDanhSachMonAn1.BringToFront();

            // xoa don hang chua thanh toan khi bam sang muc khac 
            xoaDonChuaThanhToan();
        }

        private void button_đơn_hàng_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_đơn_hàng.Height;
            panel_chọn.Top = button_đơn_hàng.Top;
            nvchDonHang1.layCuaHangHienTai = taiKhoan.Substring(0, 3);
            nvchDonHang1.Show();
            nvchDonHang1.BringToFront();

            // xoa don hang chua thanh toan khi bam sang muc khac 
            xoaDonChuaThanhToan();

            nvchDonHang1.hienDanhSachDonHang(taiKhoan.Substring(0, 3));
        }

        private void button_tài_khoản_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_tài_khoản.Height;
            panel_chọn.Top = button_tài_khoản.Top;
            nvchTaiKhoan1.layTaiKhoanHienTai = taiKhoan;
            nvchTaiKhoan1.LayMatKhauCuNVCHTaiKhoan = matKhauCu;
            nvchDonHang1.Hide();
            nvchDanhSachMonAn1.Hide();
            hinhtrangchu1.Hide();
            nvchTaiKhoan1.BringToFront();
            // xoa don hang chua thanh toan khi bam sang muc khac 
            xoaDonChuaThanhToan();
            //
            traLaiSoLuong();
        }

        private void Hinhtrangchu1_Load(object sender, EventArgs e)
        {

        }

        private void NvchDanhSachMonAn1_Load(object sender, EventArgs e)
        {

        }

        private void NvchDonHang1_Load(object sender, EventArgs e)
        {

        }

        private void Button_đặt_trực_tiếp_Click(object sender, EventArgs e)
        {
            panel_chọn.Height = button_đặt_trực_tiếp.Height;
            panel_chọn.Top = button_đặt_trực_tiếp.Top;
            nvchDatTrucTiep1.layCuaHangHienTai = taiKhoan.Substring(0, 3);
            nvchDatTrucTiep1.layMaNhanVienHienTai = taiKhoan;
            nvchDatTrucTiep1.hienDanhSachMonAn(taiKhoan.Substring(0, 3));
            nvchDatTrucTiep1.BringToFront();
        }

        private void FormNVCH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát","Thông Báo",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                xoaDonChuaThanhToan();
                e.Cancel = true;
            }
        }
        public void traLaiSoLuong()
        {
            for (int i = nvchDatTrucTiep1.count;i >=0;i--)
            {
                //tra lai so luong
                int soluongTrongKho = NVCHDatTrucTiepDAO.Instance.kiemTraSoLuongMonAn(taiKhoan.Substring(0, 3), nvchDatTrucTiep1.maTM[i]);
                NVCHDatTrucTiepDAO.Instance.traLaiSoLuongVaoKho(soluongTrongKho, nvchDatTrucTiep1.soLuongTM[i], taiKhoan.Substring(0, 3), nvchDatTrucTiep1.maTM[i]);
            }
        }
        // xoa don hang chua thanh toan khi bam sang muc khac 
        public void xoaDonChuaThanhToan()
        {
            string maDonHangHienTai = nvchDatTrucTiep1.layMaDonHangHienTai;
            if (maDonHangHienTai != "")
            {
                if (NVCHDatTrucTiepDAO.Instance.demSoHangCuaChiTietDonHang(maDonHangHienTai) > 0)
                {
                    NVCHDatTrucTiepDAO.Instance.huyChiTietDonHang(maDonHangHienTai);
                }
                if (NVCHDatTrucTiepDAO.Instance.huyDonHang(maDonHangHienTai))
                {
                    nvchDatTrucTiep1.layCuaHangHienTai = "";
                    nvchDatTrucTiep1.xoaTextbox();
                }
            }
        }
    }
}