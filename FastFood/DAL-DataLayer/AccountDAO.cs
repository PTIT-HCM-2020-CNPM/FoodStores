using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FastFood.DTO_DataTranferObject;

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
        //Ràng buộc không đăng nhập bằng tài khoản nhân viên nếu cửa hàng ngừng hoạt động
        public bool CheckLoginStopStore(string employee)
        {
            string query= "USP_CheckLoginStopStore @manhanvien";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { employee });
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
        //SỬA TÀI KHOẢN NHÂN VIÊN
        public bool UpdateAccountEmployee(string accountNumber, string password)
        {
            string query = String.Format("Update dbo.TAI_KHOAN set [MẬT KHẨU] = '{0}' where [TÊN TÀI KHOẢN] = '{1}'", password, accountNumber);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //SỬA THÔNG TIN NHÂN VIÊN
        public bool UpdateEmployee(string accountNumber, string numberStore, string name, int birthYear, string gender, string address, string numberPhone)
        {
            string query = String.Format("Update dbo.NHAN_VIEN set [MÃ CỬA HÀNG] = '{0}' , [HỌ TÊN NHÂN VIÊN] = N'{1}'," +
               " [NĂM SINH] = {2}, [GIỚI TÍNH] = N'{3}', [ĐỊA CHỈ] = N'{4}', [SỐ ĐIỆN THOẠI] = '{5}' " +
               "where [MÃ NHÂN VIÊN] = '{6}'", numberStore, name, birthYear, gender, address, numberPhone, accountNumber);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //XÓA TÀI KHOẢN NHÂN VIÊN: XÓA NHÂN VIÊN-> XÓA TÀI KHOẢN NHÂN VIÊN
        public bool DeleteEmployee(string employeeNumber)
        {
            string query= String.Format("Delete dbo.NHAN_VIEN where [MÃ TÀI KHOẢN]='{0}'", employeeNumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccountEmployee(string employeeNumber)
        {
            DeleteEmployee(employeeNumber);
            string query = String.Format("Delete dbo.TAI_KHOAN where [TÊN TÀI KHOẢN]='{0}'", employeeNumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //TÌM KIẾM TÀI KHOẢN
        public List<EmployeeAccount> SearchAccountByName(string strSearch)
        {
            List<EmployeeAccount> list = new List<EmployeeAccount>();
            string query = String.Format("select t.[TÊN TÀI KHOẢN] as [TÊN TÀI KHOẢN(MÃ NHÂN VIÊN)],t.[MẬT KHẨU] as [MẬT KHẨU],n.[MÃ CỬA HÀNG] as [MÃ CỬA HÀNG],n.[HỌ TÊN NHÂN VIÊN] as [HỌ TÊN NHÂN VIÊN]," +
                "n.[NĂM SINH] as [NĂM SINH],n.[GIỚI TÍNH] as [GIỚI TÍNH],n.[ĐỊA CHỈ] as [ĐỊA CHỈ],n.[SỐ ĐIỆN THOẠI] as [SỐ ĐIỆN THOẠI]" +
                "from TAI_KHOAN as t , NHAN_VIEN as n " +
                "where t.[TÊN TÀI KHOẢN] = n.[MÃ NHÂN VIÊN]" +
                "and (t.[TÊN TÀI KHOẢN] like '{0}%' or n.[HỌ TÊN NHÂN VIÊN] like N'{1}%' or n.[MÃ CỬA HÀNG] like '{2}%' )", strSearch, strSearch,strSearch);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                EmployeeAccount employeeAccount = new EmployeeAccount(item);
                list.Add(employeeAccount);
            }
            return list;
        }
        //DOI MAT KHAU TAI KHOAN NHAN VIEN CUA HANG DO NHAN VIEN CUA HANG DOI DOI
        public bool doiMatKhauNhanVienCuaHang(string taiKhoan,string matKhauMoi)
        {
            string query = String.Format("update TAI_KHOAN set [MẬT KHẨU] = '"+matKhauMoi+"' where TAI_KHOAN.[TÊN TÀI KHOẢN] = '"+taiKhoan+"'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //LẤY MẬT KHẨU TK KH 
        public DataTable getPasswordCustommer(string customerNum)
        {
            string query = String.Format("select [MẬT KHẨU] from TAI_KHOAN where [TÊN TÀI KHOẢN]='{0}'",customerNum);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        //UPDATE MẬT KHẨU KHÁCH HÀNG
        public bool updatePassCustomer(string userName, string password, string newPass)
        {
            string query = "exec USP_UpdatePass @userName , @password ,  @newPass ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, password, newPass });
            return result>0;
        }
    }
}
