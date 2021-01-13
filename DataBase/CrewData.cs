using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class CrewData
    {
        private static CrewData instance;
        public static CrewData Instance
        {
            get { if (instance == null) instance = new CrewData(); return CrewData.instance; }
            private set { CrewData.instance = value; }
        }
        private CrewData() { }



        public List<Crew> GetAllCrew()
        {
            List<Crew> crews = new List<Crew>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan;");
            foreach (DataRow item in data.Rows)
            {
                Crew crew = new Crew(item);
                crews.Add(crew);
            }
            return crews;
        }

        public Crew GetCrew(int id)
        {

            List<Crew> Crews = new List<Crew>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan where id_doan = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Crew Crew = new Crew(item);
                Crews.Add(Crew);
            }
            return Crews[0];
        }
        public void updateCrew(Crew crew)
        {
            string update = "UPDATE doan SET ";
            string info = "info = @info ,";
            string date_start = " ngay_bat_dau = @ngay_bat_dau ,";
            string date_end = " ngay_ket_thuc = @ngay_ket_thuc ,";
            string id_tour = " id_tour = @id_tour ";
            string where = "where id_doan = @id ; ";
            string query = update + info +date_start+ date_end + id_tour + where;
            DataProvider.Instance.ExecuteVoidQuery(query,
                new object[] { crew.Info , crew.StartDate.ToString("MM/dd/yyyy") , crew.EndDate.ToString("MM/dd/yyyy"), crew.TourId , crew.CrewId });
        }
        public void deteleCrew(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM doan WHERE id_ = @id ;", new object[] { id });
        }
        public void insertCrew(Crew crew)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_crew( @info , @ngay_bat_dau , @ngay_ket_thuc , @id_tour );",
                new object[] { crew.Info, crew.StartDate.ToString("MM/dd/yyyy"), crew.EndDate.ToString("MM/dd/yyyy"), crew.TourId });
        }

        public List<Hotel> GetHotelbyCrewID(int id)
        {
            List<Hotel> hotels = new List<Hotel>();
            string select = "select khach_san.*  ";
            string from = "from khach_san, chi_tiet_khach_san ";
            string where = "where chi_tiet_khach_san.id_doan = @id and chi_tiet_khach_san.id_khach_san = khach_san.id_khach_san; ";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Hotel hotel = new Hotel(item);
                hotels.Add(hotel);
            }
            return hotels;
        }

        public int add_HoteltoCrew(int idHotel, int idCrew)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select add_hotel_to_crew( @id_hotel , @id_crew );",
                new object[] { idHotel, idCrew });
        }
        public void delete_HoteltoCrew(int idHotel, int idCrew )
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM chi_tiet_khach_san where id_doan = @id_crew and id_khach_san =  @id_hotel ;",
               new object[] { idCrew, idHotel });
        }

        public List<Vehicle> GetVehiclebyCrewID(int id)
        {
            List<Vehicle> Vehicles = new List<Vehicle>();
            string select = "select phuong_tien.*  ";
            string from = "from phuong_tien, chi_tiet_phuong_tien ";
            string where = "where chi_tiet_phuong_tien.id_doan = @id and chi_tiet_phuong_tien.id_phuong_tien = phuong_tien.id_phuong_tien; ";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Vehicle Vehicle = new Vehicle(item);
                Vehicles.Add(Vehicle);
            }
            return Vehicles;
        }

        public int add_VehicletoCrew(int idCrew ,int idVehicle )
        {
            return (int)DataProvider.Instance.ExecuteScalar("select add_vehicle_to_crew( @id_vehicle , @id_crew );",
                new object[] { idVehicle, idCrew });
        }
        public void delete_VehicletoCrew(int idCrew, int idVehicle)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM chi_tiet_phuong_tien where id_doan = @id_crew and id_phuong_tien =  @id_vehicle ;",
               new object[] { idCrew, idVehicle });
        }
    }
}
