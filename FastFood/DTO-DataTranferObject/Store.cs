using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    class Store
    {
        private string storeNumber;
        public string MÃ_CỬA_HÀNG
        {
            get { return storeNumber; }
            set { this.storeNumber = value; }
        }

        private string address;
        public string ĐỊA_CHỈ
        {
            get { return address; }
            set { address = value; }
        }

        private int status;
        public int TRẠNG_THÁI_HOẠT_ĐỘNG
        {
            get { return status; }
            set { this.status = value; }
        }

        public Store(string storeNumber, string address, int status)
        {
            this.storeNumber = storeNumber;
            this.address = address;
            this.status = status;
            
        }
        public Store(DataRow row)
        {
            this.storeNumber = row["MÃ CỬA HÀNG"].ToString();
            this.address = row["ĐỊA CHỈ"].ToString();
            this.status = (int)row["TRẠNG THÁI HOẠT ĐỘNG"];
            
        }
    }
}
