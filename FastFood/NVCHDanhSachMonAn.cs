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

namespace FastFood
{
    public partial class NVCHDanhSachMonAn : UserControl
    {

        public NVCHDanhSachMonAn()
        {
            InitializeComponent();
            hienDanhSachMonAn(layCuaHangHienTai);
        }

        public string layCuaHangHienTai
        {
            get { return label_hienCuaHangUC.Text; }
            set { label_hienCuaHangUC.Text = value; }
        }
        
        //LOAD ĐƠN HÀNG
        public void hienDanhSachMonAn(string cuaHang)
        {

            string cuaHangHienTai = cuaHang;           
            //câu truy vấn chọn toàn bộ tài khoản nvch
            String query = "select CUA_HANG.[MÃ CỬA HÀNG] , MON_AN.[MÃ MÓN ĂN] , MON_AN.[TÊN MÓN ĂN] , MON_AN.[GIÁ TIỀN] , MON_AN_CUA_HANG.[SỐ LƯỢNG] from MON_AN, MON_AN_CUA_HANG, CUA_HANG where MON_AN.[MÃ MÓN ĂN] = MON_AN_CUA_HANG.[MÃ MÓN ĂN] and MON_AN_CUA_HANG.[MÃ CỬA HÀNG]=CUA_HANG.[MÃ CỬA HÀNG] and CUA_HANG.[MÃ CỬA HÀNG]='"+cuaHangHienTai+"'";
            // đưa data vào bảng dataGridView qua biến chọn nguồn data
            dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_MonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;

            textBox_MaMonAn.Text = dataGridView_DanhSachMonAn.Rows[numrow].Cells[1].Value.ToString();
            textBox_TenMonAn.Text = dataGridView_DanhSachMonAn.Rows[numrow].Cells[2].Value.ToString();
            textBox_GiaTien.Text = dataGridView_DanhSachMonAn.Rows[numrow].Cells[3].Value.ToString();
            textBox_SoLuong.Text = dataGridView_DanhSachMonAn.Rows[numrow].Cells[4].Value.ToString();
        }

        // cap nhat mon an 
        private void Button_LuuMonAn_Click(object sender, EventArgs e)
        {
            // lay gia tien nhap tu textbox xuong
            float giaTien =(float)(Convert.ToDouble(textBox_GiaTien.Text));
            string maMonAn = textBox_MaMonAn.Text;
            string tenMonAn = textBox_TenMonAn.Text;
            String query = "update MON_AN set [GIÁ TIỀN] = '"+giaTien+ "',[TÊN MÓN ĂN] = '"+tenMonAn+"' where MON_AN.[MÃ MÓN ĂN]='" + maMonAn +"' ";
            dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);

            int soLuong =Convert.ToInt32(textBox_SoLuong.Text);
            // cap nhat so luong
            String query1 = "update MON_AN_CUA_HANG set [SỐ LƯỢNG] = '" +soLuong+ "' where MON_AN_CUA_HANG.[MÃ MÓN ĂN] ='" +maMonAn+"' ";
            dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query1);
            // hien thi lai danh sach
            hienDanhSachMonAn(layCuaHangHienTai);
            MessageBox.Show("Cập Nhật Thành Công", "Cập Nhật Đồ Ăn", MessageBoxButtons.OK);
        }

        private void Button_TimMonAn_Click(object sender, EventArgs e)
        {
            // tim kiem theo ten mon an
            string timMon = textBox_TimMonAn.Text;

            if (timMon != "")
            {
                string maCuaHang = dataGridView_DanhSachMonAn.Rows[0].Cells[0].Value.ToString();
                String query = "select CUA_HANG.[MÃ CỬA HÀNG] , MON_AN.[MÃ MÓN ĂN] , MON_AN.[TÊN MÓN ĂN] , MON_AN.[GIÁ TIỀN] , MON_AN_CUA_HANG.[SỐ LƯỢNG] from MON_AN, MON_AN_CUA_HANG, CUA_HANG where  MON_AN_CUA_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] and MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = CUA_HANG.[MÃ CỬA HÀNG] and MON_AN.[TÊN MÓN ĂN] like '%"+timMon+"%' and CUA_HANG.[MÃ CỬA HÀNG] ='"+maCuaHang+"' ";
                dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                hienDanhSachMonAn(layCuaHangHienTai);
            }
        }

        private void Button_ThemMonAn_Click(object sender, EventArgs e)
        {
            string maCuaHang = layCuaHangHienTai;
            string maMonAn = textBox_MaMonAn.Text;
            string tenMonAn = textBox_TenMonAn.Text;
            // cai mac dinh cho gia tien va so luong bang 0 neu chua nhap gi tren textboxt
            int giaTien = 0;
            int soLuong = 0;
            // lay chuoi tren textbox de thu 
            if (int.TryParse(textBox_GiaTien.Text,out giaTien))
            {
                giaTien = Convert.ToInt32(textBox_GiaTien.Text);
            }
            else
                MessageBox.Show("Gía tiền phải là số Và Không được để trống. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
            if (int.TryParse(textBox_SoLuong.Text, out soLuong))
            {
                soLuong = Convert.ToInt32(textBox_SoLuong.Text);
            }
            else
                MessageBox.Show("Số lượng phải là số và không được để trống. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);

            if (maMonAn == "")
            {
                MessageBox.Show("Mã món không được để trống. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (tenMonAn == "")
            {
                MessageBox.Show("Tên món ăn không được để trống. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (giaTien == 0)
            {
                return;         
            }
            else if (soLuong == 0)
            {
                return;
            }
            else if (DanhSachMonAnDAO.Instance.themMonAn(maCuaHang, maMonAn, tenMonAn, giaTien, soLuong))
            {
                MessageBox.Show("Thêm món ăn thành công", "Thông Báo", MessageBoxButtons.OK);
                hienDanhSachMonAn(layCuaHangHienTai);
            }           
            else
            {
                MessageBox.Show("Mã món ăn bị trùng. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_TimMonAn.Text  != null)
            {
                textBox_TimMonAn.Clear();
            }
        }

        private void Button_XoaMonAn_Click(object sender, EventArgs e)
        {
            string maCuaHang = layCuaHangHienTai;
            string maMonAn = textBox_MaMonAn.Text;

            if (maMonAn == "")
            {
                MessageBox.Show("Mã món không được để trống. vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn Chắc chắn muốn xóa !", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (DanhSachMonAnDAO.Instance.xoaMonAn(maCuaHang, maMonAn))
                    {
                        MessageBox.Show("Xóa món ăn thành công", "Thông Báo", MessageBoxButtons.OK);
                        hienDanhSachMonAn(maCuaHang);
                    }
                    else
                        MessageBox.Show("Mã Món Ăn không có trong danh sách !", "Thông Báo", MessageBoxButtons.OK);
                }
            }

        }
    }
}
