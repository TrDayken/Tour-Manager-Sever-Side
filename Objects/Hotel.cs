using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Hotel
    {
        #region Hotel's private property 
        private int hotelid;

        private string hotelname;

        private decimal price;

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

        public decimal HotelPrice
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

/*        public string HotelAdress
        {
            get
            {
                return this.hoteladdress;
            }

            set
            {
                this.hoteladdress = value; 
            }
        }*/

        public 
        #endregion

        #region constructor and deconstructor
        Hotel() { }

        public Hotel(int Id , string HotelName, decimal Price)
        {
            this.hotelid = Id;
            this.hotelname = HotelName;
            this.price = Price;
/*            this.hoteladdress = hoteladdress;*/
        }

        public Hotel(DataRow row)
        {
            this.hotelid = row["id_khach_san"].GetHashCode();
            this.hotelname = row["ten_khach_san"].ToString();
            this.price = row["gia_phong"].GetHashCode();
        }

        #endregion
    }
}
