using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Tour
    {

        #region private field
        private int idtour;

        private string tourname;

        private float tourprice;

        private string tourinfo;

        #endregion

        #region get,set
        public int IdTour
        {
            get
            {
                return idtour;
            }

            set
            {
                this.idtour = value;
            }
        }

        public string TourName
        {
            get { return tourname; }

            set { this.tourname = value; }
        }

        public float TourPrice
        {
            get { return tourprice; }

            set { this.tourprice = value;  }
        }

        public string TourInfo
        {
            get { return this.tourinfo; }

            set { this.tourinfo = value; }
        }

        #endregion

        #region constructor

        public Tour (int id, string name , float price, string info)
        {
            IdTour = id;

            TourName = name;

            TourPrice = price;

            TourInfo = info;
        }
        #endregion 
    }
}
