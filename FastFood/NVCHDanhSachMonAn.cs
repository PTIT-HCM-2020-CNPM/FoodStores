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
            int soLuong = 0;
            if (int.TryParse(textBox_SoLuong.Text, out soLuong))
            {
                soLuong = Convert.ToInt32(textBox_SoLuong.Text);
                if (soLuong >= 0)
                {
                    string maMonAn = textBox_MaMonAn.Text;
                    // cap nhat so luong
                    String query1 = "update MON_AN_CUA_HANG set [SỐ LƯỢNG] = '" + soLuong + "' where MON_AN_CUA_HANG.[MÃ MÓN ĂN] ='" + maMonAn + "' ";
                    dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query1);
                    // hien thi lai danh sach
                    hienDanhSachMonAn(layCuaHangHienTai);
                    MessageBox.Show("Cập Nhật Thành Công", "Cập Nhật Đồ Ăn", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("số lượng phải lớn hơn bằng 0", "Cập Nhật Đồ Ăn", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("số lượng phải là số", "Cập Nhật Đồ Ăn", MessageBoxButtons.OK);
        }

        private void Button_TimMonAn_Click(object sender, EventArgs e)
        {
            // tim kiem theo ten mon an
            string timMon = textBox_TimMonAn.Text;

            if (timMon != "")
            {
                string maCuaHang = layCuaHangHienTai;//dataGridView_DanhSachMonAn.Rows[0].Cells[0].Value.ToString();
                String query = "select CUA_HANG.[MÃ CỬA HÀNG] , MON_AN.[MÃ MÓN ĂN] , MON_AN.[TÊN MÓN ĂN] , MON_AN.[GIÁ TIỀN] , MON_AN_CUA_HANG.[SỐ LƯỢNG] from MON_AN, MON_AN_CUA_HANG, CUA_HANG where  MON_AN_CUA_HANG.[MÃ MÓN ĂN] = MON_AN.[MÃ MÓN ĂN] and MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = CUA_HANG.[MÃ CỬA HÀNG] and MON_AN.[TÊN MÓN ĂN] like N'%"+timMon+"%' and CUA_HANG.[MÃ CỬA HÀNG] ='"+maCuaHang+"' ";
                dataGridView_DanhSachMonAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                hienDanhSachMonAn(layCuaHangHienTai);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox_TimMonAn.Text  != null)
            {
                textBox_TimMonAn.Clear();
            }
            hienDanhSachMonAn(layCuaHangHienTai);
        }
    }
}
