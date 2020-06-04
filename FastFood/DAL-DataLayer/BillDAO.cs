using FastFood.DTO_DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    class BillDAO
    {
        ///SINGLETON
        private static BillDAO instance;
        private BillDAO() { }

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }
        ///

        //TÌM KIẾM BILL
        public List<Bill> SearchBill(string searchString)
        {
            List<Bill> list = new List<Bill>();

            string query = String.Format("select * from  DON_DAT_HANG as d " +
                "where d.[MÃ ĐƠN HÀNG] like '{0}%' or d.[MÃ CỬA HÀNG] like '{1}%' or d.[MÃ NHÂN VIÊN] like '{2}%' or d.[MÃ KHÁCH HÀNG(SĐT)] = '{3}%'", searchString,searchString,searchString, searchString);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Bill bill = new Bill(item);
                list.Add(bill);
            }
            return list;
        }
        ///CHI TIẾT ĐƠN ĐẶT HÀNG KHI CHỌN ĐƠN HÀNG
        public bool SelectBill(string billNumber)
        {
            string query = "USP_SelectBill @madonhang";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { billNumber });

            return result.Rows.Count > 0;
        }
        //TỔNG TIỀN ALL BILL
        public DataTable GetTotalMoneyBill(DateTime dateTo, DateTime dateFrom)
        {
            string query = "[dbo].[USP_GetTotalMoneyBill] @ngaybatdau , @ngayketthuc";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTo, dateFrom});
            return result;

        }
        //TỔNG TIỀN THEO CỬA HÀNG
        public DataTable GetTotalMoneyStoreBill(DateTime dateTo, DateTime dateFrom)
        {
            string query = "USP_GetTotalMoneyStoreBill @ngaybatdau , @ngayketthuc ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTo, dateFrom});
            return result;

        }
        //SỐ LƯỢNG TỪNG MÓN ĂN BÁN RA
        public DataTable GetTotalNumberFood(DateTime dateTo, DateTime dateFrom)
        {
            string query = "USP_GetTotalMoneyStoreBill @ngaybatdau , @ngayketthuc ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTo, dateFrom });
            return result;

        }
        //
        //TỔNG TIỀN BILL OFF THEO CỬA HÀNG
        public  DataTable GetTotalMoneyOfflineBill(DateTime dateTo, DateTime dateFrom)
        {
            string query = "USP_GetTotalMoneyOfflineBill @ngaybatdau , @ngayketthuc ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTo, dateFrom });
            return result;
        }
        //
        //TỔNG TIỀN BILL ONL THEO CỬA HÀNG
        public DataTable GetTotalMoneyOnlineBill(DateTime dateTo, DateTime dateFrom)
        {
            string query = "USP_GetTotalMoneyOnlineBill @ngaybatdau , @ngayketthuc ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTo, dateFrom });
            return result;
        }
        //
        //ĐẾM SỐ LƯỢNG DÒNG TRONG BẢNG ĐƠN ĐẶT HÀNG
        public int GetNumberOfRowSQLData(string storeNumber)
        {
            string query = String.Format("select * from dbo.DON_DAT_HANG where [MÃ CỬA HÀNG]='{0}'",storeNumber);
                
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return data.Rows.Count;
        } 
        //

        //THÊM ĐƠN HÀNG BỞI KHÁCH HÀNG
        public bool InsertBillByCustomer(string billNumber, string storeNumber, string customerNumber, int totalBill, string date,string address, int kindBill)
        {  
            string query = string.Format("insert dbo.DON_DAT_HANG([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG(SĐT)],[TỔNG TIỀN], NGÀY, [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG] ) " +
                "values('{0}', '{1}', '{2}', {3}, '{4}', N'{5}', {6})",
                billNumber, storeNumber, customerNumber, totalBill, date,address, kindBill);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }
        //
        //THÊM CHI TIẾT ĐƠN ĐẶT HÀNG BỞI KHÁCH HÀNG
        public bool InsertBillIfByCus(string billNum, string foodNam, int foodMount)
        {
            string query = String.Format("insert dbo.CHI_TIET_DON_DAT_HANG([MÃ ĐƠN HÀNG], [TÊN MÓN ĂN], [SỐ LƯỢNG]) values('{0}', '{1}', {2})", billNum, foodNam, foodMount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //LOAD DANH SÁCH ĐƠN HÀNG CỦA MỘT KHÁCH HÀNG
        public List<HistoryOrder> LoadBillCustomer(string customerNumber)
        {
            List<HistoryOrder> orders = new List<HistoryOrder>();

            string query= String.Format("select [ĐỊA CHỈ] as [ĐỊA CHỈ ĐẶT HÀNG],[TỔNG TIỀN],NGÀY,[MÃ ĐƠN HÀNG],[TRẠNG THÁI ĐƠN HÀNG] from DON_DAT_HANG where [MÃ KHÁCH HÀNG(SĐT)] = '{0}'", customerNumber);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                HistoryOrder order = new HistoryOrder(row);
                orders.Add(order);
            }

            return orders;
        }
        //LẤY MÃ ĐƠN HÀNG THEO KHÁCH HÀNG
        public DataTable GetNumBillCustomer(string customerNumber)
        {
            string query = String.Format("select [MÃ ĐƠN HÀNG] from DON_DAT_HANG where [MÃ KHÁCH HÀNG(SĐT)] = '{0}'", customerNumber);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
