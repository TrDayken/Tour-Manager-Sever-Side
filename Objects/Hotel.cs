using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Hotel
    {
        #region Hotel's private property 
        private int id;

        private string hotelname;

        private float price;

        #endregion

        #region get, set

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                this.id = value; 
            }
        }

        public string HotelName
        {
            get
            {
                return hotelname;
            }

            set
            {
                this.hotelname = value; 
            }
        }

        public float Price
        {
            get
            {
                return price; 
            }

            set
            {
                this.price = value; 
            }
        }
        #endregion

        #region constructor and deconstructor
        Hotel() { }

        public Hotel(int Id , string HotelName, float Price)
        {
            this.id = Id;
            this.hotelname = HotelName;
            this.price = Price;
        }

        #endregion
    }
}
