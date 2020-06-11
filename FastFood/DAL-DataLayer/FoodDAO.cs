using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    class FoodDAO
    {
        private static FoodDAO instance;
        private FoodDAO() { }

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
            private set { instance = value; }
        }
        //Lấy toàn bộ giá trị bảng món ăn
        public DataTable GetFood()
        {
            string query = String.Format("Select * from MON_AN");

            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Thêm món ăn vào bảng món ăn
        public bool InsertFood(string foodNum, string foodName, int price, string imgName)
        {
            string query = String.Format("insert dbo.MON_AN ([MÃ MÓN ĂN],[TÊN MÓN ĂN],[GIÁ TIỀN], [HÌNH ẢNH]) values ('{0}', N'{1}', {2},'{3}')",foodNum,foodName,price,imgName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }
        //thêm món ăn vào bảng món ăn cửa hàng
        public bool InsertFoodStore(string storeNum, string foodNum, int amount)
        {
            string query =String.Format("insert dbo.MON_AN_CUA_HANG ([MÃ CỬA HÀNG],[MÃ MÓN ĂN],[SỐ LƯỢNG])" +
                "values('{0}','{1}', {2})", storeNum, foodNum, amount);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Kiểm tra giá trị id food trùng
        public bool CheckDuplicate(string foodNum)
        {
            string query = String.Format("select [MÃ MÓN ĂN] from MON_AN " +
                "where [MÃ MÓN ĂN] = '{0}' ", foodNum);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        //Sửa món ăn
        public bool UpdateFood(string foodNumNew, string foodName, int price, string imgName, string foodNumOld)
        {
            string query = String.Format("Update dbo.MON_AN set [MÃ MÓN ĂN] = '{0}', [TÊN MÓN ĂN] = N'{1}', [GIÁ TIỀN] = {2}, [HÌNH ẢNH]= '{3}'" +
                          "where [MÃ MÓN ĂN] = '{4}' ", foodNumNew, foodName, price, imgName, foodNumOld);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //sửa món ăn cửa hàng
        public bool UpdateFoodStore(string storeNum, string foodNum)
        {
            string query = String.Format("update dbo.MON_AN_CUA_HANG set [MÃ MÓN ĂN]='{0}'" +
                " where [MÃ MÓN ĂN] = '{1}' and [MÃ CỬA HÀNG]='{2}'",foodNum, foodNum, storeNum);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //xóa món ăn cửa hàng
        public bool DeleteFoodStore(string storeNum, string foodNum)
        {
            string query = String.Format("delete MON_AN_CUA_HANG where [MÃ MÓN ĂN] = '{0}' and [MÃ CỬA HÀNG]='{1}'",foodNum, storeNum);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }
        //Cập nhật số lượng món ăn trong món ăn cửa hàng
        public bool UpdateAmountFood(string storeNum, string foodNum, int newAmount)
        {
            string query= String.Format("update dbo.MON_AN_CUA_HANG set [SỐ LƯỢNG]= {0} " +
                "where [MÃ MÓN ĂN] = '{1}' and [MÃ CỬA HÀNG] = '{2}'", newAmount, foodNum, storeNum);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //Lấy số lượng của món ăn cửa hàng theo tên món ăn
        public DataTable GetAmountFoodStore(string storeNum, string foodName)
        {
            string query = String.Format("select  mc.[SỐ LƯỢNG], m.[MÃ MÓN ĂN],mc.[MÃ CỬA HÀNG], mc.[MÃ MÓN ĂN],m.[TÊN MÓN ĂN] from MON_AN_CUA_HANG as mc, MON_AN as m " +
                "where mc.[MÃ MÓN ĂN] = m.[MÃ MÓN ĂN] and mc.[MÃ CỬA HÀNG] = '{0}' and m.[TÊN MÓN ĂN] = N'{1}'",storeNum,foodName);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy số lượng của từng món ăn trong bill khách hàng
        public DataTable GetAmountFoodBill(string storeNum, string foodName, string billNum)
        {
            string query = String.Format("select c.[SỐ LƯỢNG], d.[MÃ CỬA HÀNG], m.[TÊN MÓN ĂN] from CHI_TIET_DON_DAT_HANG as c, MON_AN as m, DON_DAT_HANG as d " +
                "where m.[TÊN MÓN ĂN] = c.[TÊN MÓN ĂN] and d.[MÃ ĐƠN HÀNG] = c.[MÃ ĐƠN HÀNG] " +
                "and [MÃ CỬA HÀNG] = '{0}' and m.[TÊN MÓN ĂN] = N'{1}' and c.[MÃ ĐƠN HÀNG] = '{2}'",storeNum, foodName, billNum);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Tìm kiếm món ăn
        public DataTable GetFoodBySearch(string strSearch)
        {
            string query = String.Format("select * from MON_AN where [MÃ MÓN ĂN] like '{0}%' or [TÊN MÓN ĂN] like '{1}%' ", strSearch, strSearch);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //Lấy bảng mã món ăn
        public DataTable GetFoodID(string foodName)
        {
            string query = String.Format("select [MÃ MÓN ĂN] from MON_AN " +
                "where [TÊN MÓN ĂN] = N'{0}'",foodName);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
