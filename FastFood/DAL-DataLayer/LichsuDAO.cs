using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL_DataLayer
{
    public class LichsuDAO
    {
        private static LichsuDAO instance;

        public static LichsuDAO Instance
        {
            get { if (instance == null) instance = new LichsuDAO(); return LichsuDAO.instance; }
            private set { LichsuDAO.instance = value; }
        }

    }
}
