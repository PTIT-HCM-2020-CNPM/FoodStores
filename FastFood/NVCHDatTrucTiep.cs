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
using FastFood.DTO_DataTranferObject;

namespace FastFood
{
    public partial class NVCHDatTrucTiep : UserControl
    {
        public NVCHDatTrucTiep()
        {
            InitializeComponent();
        }
        //
        string maDonHangHienTai;
        string cuaHangHienTai;
        string maNhanVienHienTai;

        public string layMaDonHangHienTai
        {
            get { return maDonHangHienTai; }
            set { maDonHangHienTai = value; }
        }
        public string layCuaHangHienTai
        {
            get { return cuaHangHienTai; }
            set { cuaHangHienTai = value; }
        }
        public string layMaNhanVienHienTai
        {
            get { return maNhanVienHienTai; }
            set { maNhanVienHienTai = value; }
        }
        public void xoaTextbox()
        {
            textBox_TenMonAn.Text = "";
            textBox_SoLuong.Text = "";
            textBox_MaDonHang.Text = "";
            textBox_TongTien.Text = "";
            dataGridView_ChiTietDonHang.DataSource = "";
            tongTien = 0;
        }
        //
        public void hienDanhSachMonAn(string cuaHang)
        {

            string cuaHangHienTai = cuaHang;
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select CUA_HANG.[MÃ CỬA HÀNG] , MON_AN.[MÃ MÓN ĂN] , MON_AN.[TÊN MÓN ĂN] , MON_AN.[GIÁ TIỀN] , MON_AN_CUA_HANG.[SỐ LƯỢNG] from MON_AN, MON_AN_CUA_HANG, CUA_HANG where MON_AN.[MÃ MÓN ĂN] = MON_AN_CUA_HANG.[MÃ MÓN ĂN] and MON_AN_CUA_HANG.[MÃ CỬA HÀNG]=CUA_HANG.[MÃ CỬA HÀNG] and CUA_HANG.[MÃ CỬA HÀNG]='" + cuaHangHienTai + "'";
            // đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void DateTimePicker_bắt_đầu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button_TimMonAn_Click(object sender, EventArgs e)
        {
            // tim kiem theo ten mon an
            string timMon = textBox_TimMonAn.Text;

            if (timMon != "")
            {
                string maCuaHang = dataGridView_DanhSachMonAn.Rows[0].Cells[0].Value.ToString();
                String query = "select CUA_HANG.[MÃ CỬA HÀNG] , MON_AN.[MÃ MÓN ĂN] , MON_AN.[TÊN MÓN ĂN] , MON_AN.[GIÁ TIỀN] , MON_AN_CUA_HANG.[SỐ LƯỢNG] from MON_AN, MON_AN_CUA_HANG, CUA_HANG where  MON_AN_CUA_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] and MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = CUA_HANG.[MÃ CỬA HÀNG] and MON_AN.[TÊN MÓN ĂN] like '%" + timMon + "%' and CUA_HANG.[MÃ CỬA HÀNG] ='" + maCuaHang + "' ";
                dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                hienDanhSachMonAn(layCuaHangHienTai);
            }
        }

        private void Button_XoaOTimKiem_Click(object sender, EventArgs e)
        {
            if (textBox_TimMonAn.Text != null)
            {
                textBox_TimMonAn.Clear();
            }
            hienDanhSachMonAn(layCuaHangHienTai);
        }
        string maMonAn = "";
        float tienMotMon = 0;
        float tongTien = 0;
        private void DataGridView_DanhSachMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            
            textBox_SoLuong.Text = "1";
            maMonAn = dataGridView_DanhSachMonAn.Rows[numrow].Cells[1].Value.ToString();
            textBox_TenMonAn.Text = dataGridView_DanhSachMonAn.Rows[numrow].Cells[2].Value.ToString();
            tienMotMon = (float)(Convert.ToInt32(dataGridView_DanhSachMonAn.Rows[numrow].Cells[3].Value.ToString()));
            soLuongTruocCapNhat = 0;
        }

        private void Button_TaoDonHang_Click(object sender, EventArgs e)
        {
            string maCuaHang=layCuaHangHienTai;           
            string maNhanVien = layMaNhanVienHienTai;
            int soDHHienTai = BillDAO.Instance.GetNumberOfRowSQLData(maCuaHang);
            string MaDonHang = maCuaHang+"DH"+(soDHHienTai+1);
            DateTime dateNow = DateTime.Now;
            string date = dateNow.ToString("yyyy/MM/dd");

            if (textBox_MaDonHang.Text == "")
            {
                textBox_MaDonHang.Text = MaDonHang;
                layMaDonHangHienTai = textBox_MaDonHang.Text;
                String query = String.Format("insert into DON_DAT_HANG ([MÃ ĐƠN HÀNG],[MÃ CỬA HÀNG],[MÃ NHÂN VIÊN],[MÃ KHÁCH HÀNG(SĐT)],[TỔNG TIỀN],NGÀY,[ĐỊA CHỈ],[TRẠNG THÁI ĐƠN HÀNG]) values('{0}', '{1}', '{2}', '0000000000', 0, '{3}','', 2)",MaDonHang,maCuaHang,maNhanVien,date);
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Tạo mới thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng xử lý đơn hàng hiện tại", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Button_HuyDonHang_Click(object sender, EventArgs e)
        {
            string maDonHang = textBox_MaDonHang.Text;
            if (maDonHang != "")
            {
                if (MessageBox.Show("Bạn muốn hủy đơn này", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (NVCHDatTrucTiepDAO.Instance.demSoHangCuaChiTietDonHang(maDonHang) == 0)
                    {
                        NVCHDatTrucTiepDAO.Instance.huyDonHang(maDonHang);
                        MessageBox.Show("Đơn hàng đã được hủy", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        String query = "delete from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '" + maDonHang + "'";
                        DataProvider.Instance.ExecuteQuery(query);
                        NVCHDatTrucTiepDAO.Instance.huyDonHang(maDonHang);
                        MessageBox.Show("Đơn hàng đã được hủy", "Thông Báo", MessageBoxButtons.OK);
                    }
                    for (int i  = count;i>=0;i--)
                    {
                        //tra lai so luong
                        int soluongTrongKho = NVCHDatTrucTiepDAO.Instance.kiemTraSoLuongMonAn(layCuaHangHienTai, maTM[i]);
                        NVCHDatTrucTiepDAO.Instance.traLaiSoLuongVaoKho(soluongTrongKho, soLuongTM[i], layCuaHangHienTai, maTM[i]);
                    }
                    hienDanhSachMonAn(layCuaHangHienTai);
                    // tra cac gia tri ve ban dau
                    textBox_TenMonAn.Text = "";
                    textBox_SoLuong.Text = "";
                    textBox_MaDonHang.Text = "";
                    textBox_TongTien.Text = "";
                    dataGridView_ChiTietDonHang.DataSource = "";
                    tongTien = 0;
                    count = -1;
                    
                }
            }
        }
        // 2 mang luu tru mon an tam thoi de tra lai so luong khi cap nhat hoặc huy
        public int[] soLuongTM = new int[100];
        public string[] maTM = new string[100];
        public int count =-1;
        private void Button_ThemMonAn_Click(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text != "")
            {
                int soLuong = Convert.ToInt32(textBox_SoLuong.Text);
                string maDonHang = textBox_MaDonHang.Text;
                string tenMonAn = textBox_TenMonAn.Text;
                if (maDonHang != "")
                {
                    if (MessageBox.Show("thêm món này", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int soluongTrongKho = NVCHDatTrucTiepDAO.Instance.kiemTraSoLuongMonAn(layCuaHangHienTai, maMonAn);
                        if (soluongTrongKho >= soLuong)
                        {
                            if (NVCHDatTrucTiepDAO.Instance.themMonAn(maDonHang, maMonAn,tenMonAn, soLuong))
                            {
                                tongTien = tongTien + (tienMotMon * soLuong);
                                textBox_TongTien.Text = tongTien.ToString();
                                //gan vao mang
                                count++;
                                soLuongTM[count] = soLuong;
                                maTM[count] = maMonAn;                            
                                //xoa so luong trong kho
                                NVCHDatTrucTiepDAO.Instance.truSoLuongTrongKho(soluongTrongKho, soLuong, layCuaHangHienTai, maMonAn);
                            }
                            else
                            {
                                MessageBox.Show("Món Ăn này đã có", "Thông Báo", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số Lượng trong kho không đủ", "Thông Báo", MessageBoxButtons.OK);
                        }
                        hienDanhSachMonAn(layCuaHangHienTai);
                        // hien thi ngay len datagiwview chi tiet don hang 
                        String query1 = "select CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN],MON_AN.[TÊN MÓN ĂN],CHI_TIET_DON_DAT_HANG.[SỐ LƯỢNG],MON_AN.[GIÁ TIỀN] from CHI_TIET_DON_DAT_HANG , MON_AN where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] ='" + maDonHang + "' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] ";
                        dataGridView_ChiTietDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                        textBox_TenMonAn.Text = "";
                        textBox_SoLuong.Text = "";
                    }
                }
                else
                    MessageBox.Show("vui lòng tạo hóa đơn trước", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Button_CapNhat_Click(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text != "")
            {
                string maDonHang = textBox_MaDonHang.Text;
                if (maDonHang != "")
                {
                    string maCuaHang = layCuaHangHienTai;                    
                    int soLuong = Convert.ToInt32(textBox_SoLuong.Text);
                    
                    if (MessageBox.Show("Cập Nhật Số Lượng", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (soLuongTruocCapNhat != 0)
                        {
                            int soluongTrongKho = NVCHDatTrucTiepDAO.Instance.kiemTraSoLuongMonAn(layCuaHangHienTai, maMonAn);
                            int soLuongTrongKhoTruocCN = soluongTrongKho + soLuongTruocCapNhat; // so luong trong kho cộng với số lượng món đó trong đơn hàng trước cập nhật
                                                                                                // kiem tra so luong trong kho con du khong va kiem tra mon do co trong don chua
                            if (NVCHDatTrucTiepDAO.Instance.kiemTraMonAnCoChua(maDonHang, maMonAn) > 0)
                            {
                                if (soLuongTrongKhoTruocCN >= soLuong)
                                {
                                    // cap nhat 
                                    String query = "update CHI_TIET_DON_DAT_HANG set [SỐ LƯỢNG] = '" + soLuong + "' where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '" + maDonHang + "' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = '" + maMonAn + "'";
                                    DataProvider.Instance.ExecuteQuery(query);
                                    // xoa nhung mon co so luong bang 0 sao khi cap nhat
                                    NVCHDatTrucTiepDAO.Instance.xoaMonAnSoLuong0();
                                    // tong tien
                                    tongTien = tongTien - (tienMotMon * soLuongTruocCapNhat) + (tienMotMon * soLuong);
                                    textBox_TongTien.Text = tongTien.ToString();
                                    // gan lai so luong moi 
                                    for (int i = count; i >= 0; i--)
                                    {
                                        if (maTM[i] == maMonAn)
                                        {
                                            soLuongTM[i] = soLuong;
                                        }
                                    }
                                    NVCHDatTrucTiepDAO.Instance.truSoLuongTrongKho(soLuongTrongKhoTruocCN, soLuong, layCuaHangHienTai, maMonAn);
                                    hienDanhSachMonAn(layCuaHangHienTai);
                                }
                                else
                                {
                                    MessageBox.Show("Số Lượng trong kho không đủ", "Thông Báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                                MessageBox.Show("Món Ăn chưa có sẵn,vui lòng thêm mới", "Thông Báo", MessageBoxButtons.OK);
                            // hien thi ngay len datagiwview chi tiet don hang
                            String query1 = "select CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN],MON_AN.[TÊN MÓN ĂN],CHI_TIET_DON_DAT_HANG.[SỐ LƯỢNG],MON_AN.[GIÁ TIỀN] from CHI_TIET_DON_DAT_HANG , MON_AN where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] ='" + maDonHang + "' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] ";
                            dataGridView_ChiTietDonHang.DataSource = DataProvider.Instance.ExecuteQuery(query1);

                            textBox_SoLuong.Text = "";
                            textBox_TenMonAn.Text = "";
                            soLuongTruocCapNhat = 0;
                        }
                        else
                            MessageBox.Show("Bấm vào 1 món bên chi tiết đơn hàng để cập nhật", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("vui lòng tạo hóa đơn trước", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Button_ThanhToan_Click(object sender, EventArgs e)
        {
            string maDonHang = textBox_MaDonHang.Text;

            if (maDonHang != "")
            {
                if (MessageBox.Show("Thanh Toán", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    String query = "update DON_DAT_HANG set [TỔNG TIỀN] = '" + tongTien + "' where DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '" + maDonHang + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thanh Toán Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    // xoa het may o textbox
                    textBox_TenMonAn.Text = "";
                    textBox_SoLuong.Text = "";
                    textBox_MaDonHang.Text = "";
                    textBox_TongTien.Text = "";
                    dataGridView_ChiTietDonHang.DataSource = "";
                    count = -1;
                    // sau khi thanh toan xong thi tong tien ve 0;
                    tongTien = 0;
                    maDonHangHienTai = "";
                }
            }
            else
                MessageBox.Show("vui lòng tạo hóa đơn trước", "Thông Báo", MessageBoxButtons.OK);
            
        }
        // so luong mon an truoc khi cap nhat
        int soLuongTruocCapNhat = 0;
        private void DataGridView_ChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            maMonAn = dataGridView_ChiTietDonHang.Rows[numrow].Cells[0].Value.ToString();
            tienMotMon = (float)(Convert.ToInt32(dataGridView_ChiTietDonHang.Rows[numrow].Cells[3].Value.ToString()));
            textBox_SoLuong.Text = dataGridView_ChiTietDonHang.Rows[numrow].Cells[2].Value.ToString();
            soLuongTruocCapNhat = Convert.ToInt32(dataGridView_ChiTietDonHang.Rows[numrow].Cells[2].Value.ToString());
            textBox_TenMonAn.Text = dataGridView_ChiTietDonHang.Rows[numrow].Cells[1].Value.ToString();      
            
            
        }
    }
}