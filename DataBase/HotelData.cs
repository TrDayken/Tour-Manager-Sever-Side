using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class HotelData
    {
        private static HotelData instance;
        public static HotelData Instance
        {
            get { if (instance == null) instance = new HotelData(); return HotelData.instance; }
            private set { HotelData.instance = value; }
        }
        private HotelData() { }



        public List<Hotel> GetAllHotel()
        {
            List<Hotel> hotels = new List<Hotel>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from khach_san;");
            foreach (DataRow item in data.Rows)
            {
                Hotel hotel = new Hotel(item);
                hotels.Add(hotel);
            }
            return hotels;
        }

        public Hotel GetHotel(int id)
        {

            List<Hotel> hotels = new List<Hotel>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan where id_khach_san = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Hotel hotel = new Hotel(item);
                hotels.Add(hotel);
            }
            return hotels[0];
        }
        public void updateHotel(Hotel Hotel)
        {
            string update = "UPDATE khach_san SET ";
            string hotelname = "ten_khach_san = @ten_khach_san ,";
            string price = " gia_phong = @gia_phong ";
            string where = "where id_khach_san = @id ; ";
            string query = update + hotelname + price + where;
            DataProvider.Instance.ExecuteVoidQuery(query,
                new object[] { Hotel.HotelName, Hotel.HotelPrice, Hotel.HotelID });
        }
        public void deteleHotel(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM khach_san WHERE id_khach_san = @id ;", new object[] { id });
        }
        public void insertHotel(Hotel Hotel)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_hotel( @ten_khach_san , @gia_phong );",
                new object[] { Hotel.HotelName, Hotel.HotelPrice });
        }
        public List<Crew> GetCrewbyHotelID(int id)
        {
            List<Crew> crews = new List<Crew>();
            string select = "select doan.* ";
            string from = "from doan, chi_tiet_khach_san ";
            string where = "where chi_tiet_khach_san.id_khach_san = @id and chi_tiet_khach_san.id_doan = doan.id_doan; ";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Crew crew = new Crew(item);
                crews.Add(crew);
            }
            return crews;
        }
    }
}
