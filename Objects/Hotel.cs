using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Hotel
    {
        #region Hotel's private property 
        private int _id { get; set; }

        private string _hotelname { get; set; }

        private float _price { get; set; }

        #endregion

        #region constructor and deconstructor
        Hotel() { }

        public Hotel(int Id , string HotelName, float Price)
        {
            this._id = Id;
            this._hotelname = HotelName;
            this._price = Price;
        }

        #endregion
    }
}
