using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    class HistoryOrder
    {
        private string addStore;
        public string ĐỊA_CHỈ_ĐẶT_HÀNG
        {
            get { return addStore; }
            set { this.addStore = value; }
        }

        private string totalBill;
        public string TỔNG_TIỀN
        {
            get { return totalBill; }
            set { totalBill = value; }
        }

        private DateTime date;
        public DateTime NGÀY_ĐẶT_HÀNG
        {
            get { return date; }
            set { date = value; }
        }

        private string numBill;
        public string MÃ_ĐƠN_HÀNG
        {
            get { return numBill; }
            set { numBill = value; }
        }

        private int status;
        private string strStatus=null;
        public string TRẠNG_THÁI_ĐƠN_HÀNG
        {
            get
            {
                if (status == 0) strStatus = "Chuẩn bị";
                else if (status == 1) strStatus = "Đang giao";
                else if (status == 2) strStatus = "Tại cửa hàng";
                else if (status == 3) strStatus = "Hoàn thành";
                return strStatus;
            }
            set { status = Convert.ToInt32(value); }
        }

        public HistoryOrder(string addStore, string totalBill, DateTime date, string numBill, int status)
        {
            this.addStore = addStore;
            this.totalBill=totalBill;
            this.date = date;
            this.numBill = numBill;
            this.status = status;
        }

        public HistoryOrder(DataRow row)
        {
            this.addStore = row["ĐỊA CHỈ ĐẶT HÀNG"].ToString();
            this.totalBill = row["TỔNG TIỀN"].ToString();
            this.date= (DateTime)row["NGÀY"];
            this.numBill = row["MÃ ĐƠN HÀNG"].ToString();
            this.status = Convert.ToInt32(row["TRẠNG THÁI ĐƠN HÀNG"]);
        }
    }
}
