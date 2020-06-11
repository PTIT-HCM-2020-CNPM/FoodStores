using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.DAL_DataLayer
{
    class DanhSachMonAnDAO
    {
        private static DanhSachMonAnDAO instance;
        private DanhSachMonAnDAO() { }
        public static DanhSachMonAnDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhSachMonAnDAO();
                return instance;
            }
            private set { instance = value; }
        }

        internal static DanhSachMonAnDAO Instance1 { get => instance; set => instance = value; }
        // them mon an
        public bool themMonMoiVaoChuoi(string maMonAn, string tenMonAn, int giaTien)
        {
            string query = String.Format("insert into MON_AN([MÃ MÓN ĂN],[TÊN MÓN ĂN],[GIÁ TIỀN],[HÌNH ẢNH]) values('" + maMonAn + "',N'" + tenMonAn + "', '" + giaTien + "', 'Chưa Có')");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int kiemTraMonAnCoTrongChuoi(string maMonAn)
        {
            string query = String.Format("select * from MON_AN where MON_AN.[MÃ MÓN ĂN] = '" + maMonAn + "'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }
        public int kiemTraMonAnCoTrongCuaHang(string maCuaHang, string maMonAn)
        {
            string query = String.Format("select * from MON_AN_CUA_HANG where MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '" + maMonAn + "' and MON_AN_CUA_HANG.[MÃ CỬA HÀNG]='" + maCuaHang + "'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }
        public bool themMonAn(string maCuaHang, string maMonAn, int soLuong)
        {
            int result = 0;
            if (kiemTraMonAnCoTrongCuaHang(maCuaHang, maMonAn) == 0) // kiem tra coi mon an nay ton tai trong chua hang chua
            {
                // them vao trong cua hang hien tai mon an da co trong chuoi ra
                String query = "insert into MON_AN_CUA_HANG([MÃ CỬA HÀNG],[MÃ MÓN ĂN],[SỐ LƯỢNG]) values('" + maCuaHang + "', '" + maMonAn + "', '" + soLuong + "')";
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }

            return result > 0;
        }
        // xoa mon an
        public bool xoaMonAn(string maCuaHang, string maMonAn)
        {
            string query = String.Format("delete from MON_AN_CUA_HANG where MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '" + maMonAn + "' and MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = '" + maCuaHang + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}