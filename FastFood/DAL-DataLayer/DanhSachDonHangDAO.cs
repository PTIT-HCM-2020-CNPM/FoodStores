using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    class DanhSachDonHangDAO
    {
        private static DanhSachDonHangDAO instance;
        private DanhSachDonHangDAO() { }

        public static DanhSachDonHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhSachDonHangDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public bool capNhatTrangThaiDonHang(int trangThai, string maDonHang)
        {
            string query = String.Format("update DON_DAT_HANG set [TRẠNG THÁI ĐƠN HÀNG] = '" + trangThai + "'	where DON_DAT_HANG.[MÃ ĐƠN HÀNG] = '" + maDonHang + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}