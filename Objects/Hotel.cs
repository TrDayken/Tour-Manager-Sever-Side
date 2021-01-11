using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Hotel
    {
        #region Hotel's private property 
        private int hotelid;

        private string hotelname;

        private float hotelprice;

        private string hoteladdress;

        #endregion

        #region get, set

        public int HotelID
        {
            get
            {
                return this.hotelid;
            }

            set
            {
                this.hotelid = value; 
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

        public float HotelPrice
        {
            get
            {
                return hotelprice; 
            }

            set
            {
                this.hotelprice = value; 
            }
        }

        public string HotelAdress
        {
            get
            {
                return this.hoteladdress;
            }

            set
            {
                this.hoteladdress = value; 
            }
        }

        public 
        #endregion

        #region constructor and deconstructor
        Hotel() { }

        public Hotel(int Id , string HotelName, float Price, string hoteladdress)
        {
            this.hotelid = Id;
            this.hotelname = HotelName;
            this.hotelprice = Price;
            this.hoteladdress = hoteladdress;
        }

        #endregion
    }
}
