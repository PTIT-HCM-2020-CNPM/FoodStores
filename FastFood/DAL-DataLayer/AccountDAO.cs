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
        public bool SignUpAccoutCustomer(string accountName, string password, int kindAccess /*,string userName*/)
        {
            string query = String.Format("insert dbo.TAI_KHOAN ([TÊN TÀI KHOẢN],[MẬT KHẨU],[LOẠI TRUY CẬP]) values ('{0}','{1}', {2})", accountName,password,kindAccess);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //THÊM KHÁCH HÀNG
        public bool SignUpCustomer( string accountName, string userName)
        {
            string query = String.Format("insert dbo.KHACH_HANG ([TÊN TÀI KHOẢN(SĐT)],[HỌ TÊN],[MÃ TÀI KHOẢN]) values ('{0}','{1}', '{2}')", accountName, userName, accountName);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //THÊM TÀI KHOẢN NHÂN VIÊN
        public bool InsertAccoutEmployee(string accountName, string password, int kindAccess)
        {
            string query = String.Format("insert dbo.TAI_KHOAN ([TÊN TÀI KHOẢN],[MẬT KHẨU],[LOẠI TRUY CẬP]) values ('{0}','{1}', {2})", accountName, password, kindAccess);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result>0;
        }
        //THÊM NHÂN VIÊN
        public bool InsertEmployee(string accountNumber, string numberStore, string name, int birthYear, string gender, string address, string numberPhone)
        {
            string query = String.Format("insert dbo.NHAN_VIEN ([MÃ NHÂN VIÊN],[MÃ CỬA HÀNG],[HỌ TÊN NHÂN VIÊN],[NĂM SINH],[GIỚI TÍNH],[ĐỊA CHỈ],[SỐ ĐIỆN THOẠI],[MÃ TÀI KHOẢN]) values ('{0}', '{1}', N'{2}' , {3} , N'{4}' , N'{5}' , '{6}' , '{7}' )", accountNumber , numberStore , name , birthYear , gender , address , numberPhone , accountNumber);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //KIỂM TRA MÃ TÀI KHOẢN CÓ TRÙNG KHI THÊM
        public bool CheckDuplicateAccount(string accountNumber)
        {
            string query = "USP_CheckDuplicateAcount @accountNumber";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { accountNumber });

            return result > 0;
        }

    }
}
