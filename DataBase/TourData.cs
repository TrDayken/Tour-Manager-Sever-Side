using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class TourData
    {

        private static TourData instance;
        public static TourData Instance
        {
            get { if (instance == null) instance = new TourData(); return TourData.instance; }
            private set { TourData.instance = value; }
        }
        private TourData() { }
    }
}
