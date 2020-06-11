using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    class Bill
    {
        private string billNumber;
        public string MÃ_ĐƠN_HÀNG
        {
            get { return billNumber; }
            set { this.billNumber = value; }
        }

        private string storeNumber;
        public string MÃ_CỬA_HÀNG
        {
            get { return storeNumber; }
            set { this.storeNumber = value; }
        }

        private string employeeNumber;
        public string MÃ_NHÂN_VIÊN
        {
            get { return employeeNumber; }
            set { this.employeeNumber = value; }
        }

        private string customerNumber;
        public string MÃ_KHÁCH_HÀNG
        {
            get { return customerNumber; }
            set { this.customerNumber = value; }
        }

        private string totalMoney;
        public string TỔNG_TIỀN
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }

        private string date;
        public string NGÀY
        {
            get { return date; }
            set { this.date = value; }
        }

        private string address;
        public string ĐỊA_CHỈ
        {
            get { return address; }
            set { this.address = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { this.status = value; }
        }

        public Bill(string billNumber, string storeNumber, string employeeNumber, string customerNumber, string totalMoney, string date, string address, int status)
        {
            this.billNumber = billNumber;
            this.storeNumber = storeNumber;
            this.employeeNumber = employeeNumber;
            this.customerNumber = customerNumber;
            this.totalMoney = totalMoney;
            this.date = date;
            this.address = address;
            this.status = status;

        }
        public Bill(DataRow row)
        {
            this.billNumber = row["MÃ ĐƠN HÀNG"].ToString();
            this.storeNumber = row["MÃ CỬA HÀNG"].ToString();
            this.employeeNumber = row["MÃ NHÂN VIÊN"].ToString();
            this.customerNumber = row["MÃ KHÁCH HÀNG(SĐT)"].ToString();
            this.totalMoney = row["TỔNG TIỀN"].ToString();
            this.date = row["NGÀY"].ToString();
            this.address = row["ĐỊA CHỈ"].ToString();
            this.status = (int)row["TRẠNG THÁI ĐƠN HÀNG"];
        }
    }
}
