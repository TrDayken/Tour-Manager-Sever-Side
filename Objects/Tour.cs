using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Tour
    {

        #region private field
        private int idtour;

        private string tourname;

        private double tourprice;

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

        public double TourPrice
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

        public Tour(DataRow item)
        {
            IdTour = item["id_tour"].GetHashCode();

            TourName = item["ten_tour"].ToString();

            TourPrice = item["gia_tour"].GetHashCode();

            TourInfo = item["noi_dung"].ToString();
        }
        #endregion 
    }
}
