using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace FastFood.DAL_DataLayer
{
    public class AccountDAO
    {

        private static AccountDAO instance;
        private AccountDAO() { }
       
        public static AccountDAO Instance {
            get {
                if (instance == null) instance = new AccountDAO();
                return instance;
                }
            private set { instance = value; }
        }
        //ĐĂNG NHẬP CỦA QUẢN LÝ
        public bool LoginManager(string userName, string password, int kindAccess)
        {
            string query = "USP_LoginManager @tentaikhoan , @matkhau , @loaitruycap";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password, kindAccess});

            return result.Rows.Count >0;
        }
        //ĐĂNG NHẬP CỦA NHÂN VIÊN
        public bool LoginEmployee(string userName, string password, int kindAccess)
        {
            string query = "USP_LoginEmployee @tentaikhoan , @matkhau , @loaitruycap";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password, kindAccess});

            return result.Rows.Count > 0;
        }
        //ĐĂNG NHẬP CỦA KHÁCH HÀNG
        public bool LoginCustomer(string userName, string password, int kindAccess)
        {
            string query = "USP_LoginCustomer @tentaikhoan , @matkhau , @loaitruycap";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, password, kindAccess });

            return result.Rows.Count > 0;
        }
        //ĐĂNG KÝ TÀI KHOẢN CỦA KHÁCH HÀNG
        public bool SignUpAccoutCustomer(string accountName, string password, int kindAccess)
        {
            string query= "USP_LoginAccountCustomer @tentaikhoan , @matkhau , @loaitruycap";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { accountName, password, kindAccess });
        
            return result.Rows.Count > 0;
        }

        public bool SignUpCustomer( string accountName, string userName)
        {
            string query = "USP_SignUptoCustomer@tentaikhoan , @hoten , @mataikhoan";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { accountName, userName, accountName });

            return result.Rows.Count > 0;
        }
    }
}
