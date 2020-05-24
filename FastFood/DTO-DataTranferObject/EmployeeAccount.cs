using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    public class EmployeeAccount
    {
        private string employeeNumber;
        public string TÊN_TÀI_KHOẢN_MÃ_NHÂN_VIÊN
        {
            get { return employeeNumber; }
            set { this.employeeNumber = value; }
        }

        private string password;
        public string MẬT_KHẨU
        {
            get { return password; }
            set { password = value; }
        }

        private string storeNumber;
        public string CỬA_HÀNG
        {
            get { return storeNumber; }
            set { this.storeNumber = value; }
        }

        private string name;
        public string HỌ_TÊN_NHÂN_VIÊN
        {
            get { return name; }
            set { this.name = value; }
        }

        private int birthYear;
        public int NĂM_SINH
        {
            get { return birthYear; }
            set { this.birthYear = value; }
        }

        private string gender;
        public string GIỚI_TÍNH
        {
            get { return gender; }
            set { this.gender = value; }
        }

        private string address;
        public string ĐỊA_CHỈ
        {
            get { return address; }
            set { this.address = value; }
        }

        private string numberPhone;
        public string SỐ_ĐIỆN_THOẠI
        {
            get { return numberPhone; }
            set { this.numberPhone = value; }
        }

        public EmployeeAccount(string employeeNumber, string password, string storeNumber,
                               string name, int birthYear, string gender, string address, string numberPhone)
        {
            this.employeeNumber = employeeNumber;
            this.password = password;
            this.storeNumber = storeNumber;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.address = address;
            this.numberPhone = numberPhone;
        }
        public EmployeeAccount(DataRow row)
        {
            this.employeeNumber = row["TÊN TÀI KHOẢN(MÃ NHÂN VIÊN)"].ToString();
            this.password = row["MẬT KHẨU"].ToString();
            this.storeNumber = row["MÃ CỬA HÀNG"].ToString();
            this.name = row["HỌ TÊN NHÂN VIÊN"].ToString();
            this.birthYear = (int)row["NĂM SINH"];
            this.gender = row["GIỚI TÍNH"].ToString();
            this.address = row["ĐỊA CHỈ"].ToString();
            this.numberPhone = row["SỐ ĐIỆN THOẠI"].ToString();
        }
    }
}
