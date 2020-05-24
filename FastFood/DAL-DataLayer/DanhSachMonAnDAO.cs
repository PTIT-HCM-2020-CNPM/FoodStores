using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool themMonAn(string maCuaHang, string maMonAn, string tenMonAn, int giaTien, int soLuong)
        {
            string query = String.Format("insert into MON_AN([MÃ MÓN ĂN],[TÊN MÓN ĂN],[GIÁ TIỀN],[HÌNH ẢNH]) values('" + maMonAn + "', '" + tenMonAn + "', '" + giaTien + "', 'Chưa Có')");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            //
            String query1 = "insert into MON_AN_CUA_HANG([MÃ CỬA HÀNG],[MÃ MÓN ĂN],[SỐ LƯỢNG]) values('" + maCuaHang + "', '" + maMonAn + "', '" + soLuong + "')";
            DataProvider.Instance.ExecuteQuery(query1);

            return result > 0;
        }
        // xoa mon an
        public bool xoaMonAn(string maCuaHang, string maMonAn)
        {
            string query = String.Format("delete from MON_AN_CUA_HANG where MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '" + maMonAn + "' and MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = '" + maCuaHang + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            String query1 = "delete from MON_AN where MON_AN.[MÃ MÓN ĂN]='" + maMonAn + "'";
            DataProvider.Instance.ExecuteQuery(query1);
            return result > 0;
        }
    }
}