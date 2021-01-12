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

        private decimal hotelprice;

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

        public decimal HotelPrice
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

        public string HotelAddress
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

        public Hotel(int Id , string HotelName , string HotelAddress, decimal Price)
        {
            this.hotelid = Id;
            this.hotelname = HotelName;
            this.hotelprice = Price;
            this.hoteladdress = HotelAddress;
        }

        public Hotel(DataRow row)
        {
            this.hotelid = row["id_khach_san"].GetHashCode();
            this.hotelname = row["ten_khach_san"].ToString();
            this.hotelprice = row["gia_phong"].GetHashCode();
            this.hoteladdress = row["dia_chi"].ToString();
        }

        #endregion
    }
}
