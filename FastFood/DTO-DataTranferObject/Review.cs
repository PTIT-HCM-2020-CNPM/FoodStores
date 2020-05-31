using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO_DataTranferObject
{
    class Review
    {
        private string addStore;
        public string ĐỊA_CHỈ_CỬA_HÀNG
        {
            get { return addStore; }
            set { this.addStore = value; }
        }

        private string reviewIf;
        public string CHI_TIẾT_ĐÁNH_GIÁ
        {
            get { return reviewIf; }
            set { reviewIf = value; }
        }

        public Review(string addStore, string reviewIf, int foodNumber)
        {
            this.addStore = addStore;
            this.reviewIf = reviewIf;
        }

        public Review(DataRow row)
        {
            this.addStore = row["ĐỊA CHỈ CỬA HÀNG"].ToString();
            this.reviewIf = row["CHI TIẾT ĐÁNH GIÁ"].ToString();
        }
    }
}
