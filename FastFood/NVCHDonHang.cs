using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.DAL_DataLayer;
using System.IO;

namespace FastFood
{
    public partial class NVCHDonHang : UserControl
    {
        public NVCHDonHang()
        {
            InitializeComponent();
            hienDanhSachDonHang(layCuaHangHienTai);
            timer1.Start();
        }
        public string layCuaHangHienTai
        {
            get { return label_hienCuaHangUC.Text; }
            set { label_hienCuaHangUC.Text = value; }
        }
        string maNhanVien;
        public string layMaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public void hienDanhSachDonHang(string cuaHang)
        {

            string cuaHangHienTai = cuaHang;
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select * from DON_DAT_HANG where DON_DAT_HANG.[MÃ CỬA HÀNG]='" + cuaHangHienTai + "' ";
            // đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_DanhSachDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        // lay trang thai ban dau cua don hang
        int trangThaiDau;
        string timMaDonChoXuatHoaDon;
        private void DataGridView_DanhSachDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_MaDonHang.Text = dataGridView_DanhSachDonHang.Rows[numrow].Cells[0].Value.ToString();
            if (dataGridView_DanhSachDonHang.Rows[numrow].Cells[7].Value.ToString() == "1")
            {
                trangThaiDau = 1;
                radioButton_DangGiaoHang.Checked = true;
            }
            else if (dataGridView_DanhSachDonHang.Rows[numrow].Cells[7].Value.ToString() == "2")
            {
                trangThaiDau = 2;
                radioButton_LayTaiCuaHang.Checked = true;
            }
            else if (dataGridView_DanhSachDonHang.Rows[numrow].Cells[7].Value.ToString() == "3")
            {
                trangThaiDau = 3;
                radioButton_HoanThanh.Checked = true;
            }
            else if (dataGridView_DanhSachDonHang.Rows[numrow].Cells[7].Value.ToString() == "0")
            {
                trangThaiDau = 0;
                radioButton_ChuanBi.Checked = true;
            }

            // chi tiet don hang 
            timMaDonChoXuatHoaDon = dataGridView_DanhSachDonHang.Rows[numrow].Cells[0].Value.ToString();
            string timDonHang = dataGridView_DanhSachDonHang.Rows[numrow].Cells[0].Value.ToString();
            String query = "select CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN],MON_AN.[TÊN MÓN ĂN],CHI_TIET_DON_DAT_HANG.[SỐ LƯỢNG],MON_AN.[GIÁ TIỀN] from CHI_TIET_DON_DAT_HANG , MON_AN where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] ='" + timDonHang + "' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] ";
            dataGridView_ChiTietDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }
        // tim don hang 
        private void Button_TimMonAn_Click(object sender, EventArgs e)
        {
            // tim kiem theo ma don hang
            string timDonHang = textBox_TimDonHang.Text;

            if (timDonHang != "")
            {
                string maCuaHang = dataGridView_DanhSachDonHang.Rows[0].Cells[0].Value.ToString();
                String query = "select * from DON_DAT_HANG where DON_DAT_HANG.[MÃ ĐƠN HÀNG]='" + timDonHang + "' ";
                dataGridView_DanhSachDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                hienDanhSachDonHang(layCuaHangHienTai);
            }
        }

        private void Button_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            // chi tiet hoa don theo ma don hang
            string timDonHang = textBox_TimDonHang.Text;

            if (timDonHang != "")
            {
                string maCuaHang = dataGridView_DanhSachDonHang.Rows[0].Cells[0].Value.ToString();
                String query = "select CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG],CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN],MON_AN.[TÊN MÓN ĂN],CHI_TIET_DON_DAT_HANG.[SỐ LƯỢNG],MON_AN.[GIÁ TIỀN] from CHI_TIET_DON_DAT_HANG , MON_AN where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] ='" + timDonHang + "' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] ";
                dataGridView_DanhSachDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                hienDanhSachDonHang(layCuaHangHienTai);
            }
        }

        private void Button_XoaOTimKiem_Click(object sender, EventArgs e)
        {
            if (textBox_TimDonHang.Text != null)
            {
                textBox_TimDonHang.Clear();
            }
            hienDanhSachDonHang(layCuaHangHienTai);
        }

        private void Button_sửa_Click(object sender, EventArgs e)
        {
            string maDonHang = textBox_MaDonHang.Text;
            int trangthai;

            if (radioButton_HoanThanh.Checked == true && trangThaiDau != 0)
            {
                trangthai = 3;
                if (DanhSachDonHangDAO.Instance.capNhatTrangThaiDonHang(trangthai, maDonHang))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK);
                    trangThaiDau = 2;
                    hienDanhSachDonHang(layCuaHangHienTai);
                }
                else
                    MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (radioButton_DangGiaoHang.Checked == true && trangThaiDau != 2 && trangThaiDau != 3)
            {
                trangthai = 1;
                if (DanhSachDonHangDAO.Instance.capNhatTrangThaiDonHang(trangthai, maDonHang))
                {
                    DanhSachDonHangDAO.Instance.capNhatNhanVienNhanDon(layMaNhanVien, maDonHang);
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK);
                    hienDanhSachDonHang(layCuaHangHienTai);
                }
                else
                    MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (radioButton_LayTaiCuaHang.Checked == true && trangThaiDau != 1 && trangThaiDau != 3 && trangThaiDau != 2)
            {
                trangthai = 2;
                if (DanhSachDonHangDAO.Instance.capNhatTrangThaiDonHang(trangthai, maDonHang))
                {
                    DanhSachDonHangDAO.Instance.capNhatNhanVienNhanDon(layMaNhanVien, maDonHang);
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK);
                    hienDanhSachDonHang(layCuaHangHienTai);
                }
                else
                    MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Đơn hàng đang giao không thể đổi trạng thái !", "Thông Báo", MessageBoxButtons.OK);



        }
        //Cập nhật bill theo thời gian
        public bool ResultOfChange()
        {
            int countRowDataCurrent = dataGridView_DanhSachDonHang.RowCount;
            int countRowSqlData = BillDAO.Instance.GetNumberOfRowSQLData(layCuaHangHienTai);
            bool result = false;
            if (countRowSqlData > countRowDataCurrent) result = true;
            return result;
        }

        public void dungTimer1()
        {
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            while (ResultOfChange())
            {
                MessageBox.Show("Có đơn hàng mới", "Thông báo", MessageBoxButtons.OK);
                hienDanhSachDonHang(layCuaHangHienTai);
            }

        }

        private void RadioButton_DangGiaoHang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button_XuatHoaDon_Click(object sender, EventArgs e)
        {                  
            TextWriter writer = new StreamWriter(@"C:\Users\Admin\Desktop\Hoadon\Hoadon.txt");
            if (dataGridView_ChiTietDonHang.Rows.Count > 0)
            {
                String query = "select * from DON_DAT_HANG where DON_DAT_HANG.[MÃ ĐƠN HÀNG]='" + timMaDonChoXuatHoaDon + "'";
                dataGridView_DanhSachDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query);

                for (int i = 0; i < dataGridView_DanhSachDonHang.Columns.Count; i++)
                {
                    writer.Write("\t" + dataGridView_DanhSachDonHang.Rows[0].Cells[i].Value.ToString() + "\t" + "|");
                    writer.WriteLine("");
                    writer.WriteLine("----------------------------------------------------------------");
                }
                for (int i = 0; i < dataGridView_ChiTietDonHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView_ChiTietDonHang.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView_ChiTietDonHang.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("----------------------------------------------------------------");
                }
                MessageBox.Show("Đã xuất hóa đơn");
            }
            else
                MessageBox.Show("Vui Lòng chọn hóa đơn xuất");
            writer.Close();
        }
    }
}