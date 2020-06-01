using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    class NVCHDatTrucTiepDAO
    {
        private static NVCHDatTrucTiepDAO instance;
        private NVCHDatTrucTiepDAO() { }

        public static NVCHDatTrucTiepDAO Instance
        {
            get
            {
                if (instance == null) instance = new NVCHDatTrucTiepDAO();
                return instance;
            }
            private set { instance = value; }
        }
        

        public bool huyDonHang(string maDonHang)
        {
            string query = String.Format("delete from DON_DAT_HANG where DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '" + maDonHang + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int demSoHangCuaChiTietDonHang(string maDonHang)
        {
            string query = String.Format("select * from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '"+maDonHang+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }

        public bool themMonAn(string maDonHang , string maMonAn , int soLuong)
        {
            string query = String.Format("insert into CHI_TIET_DON_DAT_HANG ([MÃ ĐƠN HÀNG],[MÃ MÓN ĂN],[SỐ LƯỢNG]) values('" + maDonHang + "', '" + maMonAn + "', '" + soLuong + "')");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int demSoMonAnTrongDon(string maDonHang)
        {
            string query = String.Format("select * from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '"+maDonHang+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }
        public bool huyChiTietDonHang(string maDonHang)
        {
            string query = String.Format("delete from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '"+maDonHang+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool xoaMonAnSoLuong0()
        {
            string query = String.Format("delete from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[SỐ LƯỢNG] = '0'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int kiemTraMonAnCoChua(string maDonHang,string maMonAn)
        {
            string query = String.Format("select * from CHI_TIET_DON_DAT_HANG where CHI_TIET_DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '"+maDonHang+"' and CHI_TIET_DON_DAT_HANG.[MÃ MÓN ĂN] = '"+maMonAn+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count;
        }

        public int kiemTraSoLuongMonAn(string maCuaHang, string maMonAn)
        {
            string query = String.Format("select MON_AN_CUA_HANG.[SỐ LƯỢNG]  from MON_AN_CUA_HANG where MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = '"+maCuaHang+"' and MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '"+maMonAn+"'");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return Convert.ToInt32(data.Rows[0]["SỐ LƯỢNG"].ToString());
        }
        public bool truSoLuongTrongKho(int soLuongTrongKho,int soLuongVuaDat, string maCuaHang, string maMonAn)
        {
            string query = String.Format("update MON_AN_CUA_HANG set [SỐ LƯỢNG] = '"+(soLuongTrongKho-soLuongVuaDat)+"' where MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = '"+maCuaHang+"' and MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '"+maMonAn+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool traLaiSoLuongVaoKho(int soLuongTrongKho, int soLuongVuaDat, string maCuaHang, string maMonAn)
        {
            string query = String.Format("update MON_AN_CUA_HANG set [SỐ LƯỢNG] = '" + (soLuongTrongKho + soLuongVuaDat) + "' where MON_AN_CUA_HANG.[MÃ CỬA HÀNG] = '" + maCuaHang + "' and MON_AN_CUA_HANG.[MÃ MÓN ĂN] = '" + maMonAn + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
