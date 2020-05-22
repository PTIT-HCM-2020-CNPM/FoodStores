using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    class BillInfo
    {
        private string billNumber;
        public string MÃ_ĐƠN_HÀNG
        {
            get { return billNumber; }
            set { this.billNumber = value; }
        }

        private string foodNo;
        public string MÃ_ĐỒ_ĂN
        {
            get { return foodNo; }
            set { foodNo = value; }
        }

        private int foodNumber;
        public int SỐ_LƯỢNG_MÓN_ĂN
        {
            get { return foodNumber; }
            set { this.foodNumber = value; }
        }

        public BillInfo(string billNumber, string foodNo, int foodNumber)
        {
            this.billNumber = billNumber;
            this.foodNo = foodNo;
            this.foodNumber = foodNumber;

        }
        public BillInfo(DataRow row)
        {
            this.billNumber = row["MÃ ĐƠN HÀNG"].ToString();
            this.foodNo = row["MÃ MÓN ĂN"].ToString();
            this.foodNumber = (int)row["SỐ LƯỢNG"];

        }
    }
}
