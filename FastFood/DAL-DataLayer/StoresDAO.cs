using FastFood.DTO_DataTranferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    class StoresDAO
    {
        //Singleton parttent
        private static StoresDAO instance;
        private StoresDAO() { }

        public static StoresDAO Instance
        {
            get
            {
                if (instance == null) instance = new StoresDAO();
                return instance;
            }
            private set { instance = value; }
        }

        internal static StoresDAO Instance1 { get => instance; set => instance = value; }

        //THÊM CỬA HÀNG
        public bool InsertStore(string storeNumber, string address, int status)
        {
            string query = String.Format("insert dbo.CUA_HANG ([MÃ CỬA HÀNG],[ĐỊA CHỈ],[TRẠNG THÁI HOẠT ĐỘNG]) values ('{0}','{1}', {2})", storeNumber, address, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //SỬA CỬA HÀNG
        public bool UpdateStore(string storeNumber, string address, int status)
        {
           string query= String.Format("Update dbo.CUA_HANG set  [ĐỊA CHỈ] = N'{0}', [TRẠNG THÁI HOẠT ĐỘNG] = {1}" +
                         "where [MÃ CỬA HÀNG] = '{2}' ", address, status, storeNumber);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //TÌM KIẾM CỬA HÀNG
        public List<Store> SearchStore(string storeNumber, string address)
        {
            List<Store> list = new List<Store>();
            string query = String.Format("select * from dbo.CUA_HANG where [MÃ CỬA HÀNG] like '{0}%' or [ĐỊA CHỈ] like N'{1}%'", storeNumber, address);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Store store = new Store(item);
                list.Add(store);
            }
            return list;
        }
    }
}
