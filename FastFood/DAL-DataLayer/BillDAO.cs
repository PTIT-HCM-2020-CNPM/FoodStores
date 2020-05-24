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
    }
}
