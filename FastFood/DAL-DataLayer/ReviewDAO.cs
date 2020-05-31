using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.DTO_DataTranferObject;

namespace FastFood.DAL_DataLayer
{
    class ReviewDAO
    {
        //SINGLETON
        private static ReviewDAO instance;
        private ReviewDAO() { }

        public static ReviewDAO Instance
        {
            get
            {
                if (instance == null) instance = new ReviewDAO();
                return instance;
            }
            private set { instance = value; }
        }
        //Lấy số lượng đáng giá cửa hàng
        public int GetNumberOfRowSQLData(string storeNumber)
        {
            string query = String.Format("select * from dbo.BAI_DANH_GIA where [MÃ CỬA HÀNG]='{0}'",storeNumber);
                
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            return data.Rows.Count;
        } 
        //Load bai danh gia
        public DataTable GetReview(string numberCustomer)    
        {
            string query = String.Format("select c.[ĐỊA CHỈ] as [ĐỊA CHỈ CỬA HÀNG],b.[CHI TIẾT ĐÁNH GIÁ]  from dbo.BAI_DANH_GIA as b, CUA_HANG as c where b.[MÃ CỬA HÀNG] = c.[MÃ CỬA HÀNG] and[MÃ KHÁCH HÀNG] = '{0}'",numberCustomer);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        //Thêm bài đánh giá
        public bool InsertReview(string numReview, string numStore, string numCus, string infReview)
        {
            string query = String.Format("insert dbo.BAI_DANH_GIA ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) values('{0}', '{1}', '{2}', N'{3}')", numReview, numStore, numCus, infReview);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;

        }
        //Tìm kiếm bài dánh giá theo cửa hàng
        public List<Review> SearchReview(string numCus,string strSearch)
        {
            List<Review> lReviews = new List<Review>();
            string query = String.Format("select c.[ĐỊA CHỈ] as [ĐỊA CHỈ CỬA HÀNG],b.[CHI TIẾT ĐÁNH GIÁ]" +
                " from dbo.BAI_DANH_GIA as b, CUA_HANG as c" +
                " where b.[MÃ CỬA HÀNG] = c.[MÃ CỬA HÀNG] and[MÃ KHÁCH HÀNG] = '{0}' " +
                "and c.[ĐỊA CHỈ] like N'{1}%'",numCus,strSearch);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Review review = new Review(item);
                lReviews.Add(review);
            }
            return lReviews;
        }
    }
}
