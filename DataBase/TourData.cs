using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tour_Manager_Sever_Side.Objects;

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

        public List<Tour> GetAllTour()
        {
            List<Tour> Tours = new List<Tour>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tour;");
            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                Tours.Add(Tour);
            }
            return Tours;
        }
        public Tour GetTour(int id)
        {

            List<Tour> Tours = new List<Tour>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tour where id_tour = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                Tours.Add(Tour);
            }
            return Tours[0];
        }
        public void updateTour(Tour tour)
        {
            DataProvider.Instance.ExecuteVoidQuery("UPDATE tour SET ten_tour = @ten , gia_tour = @price , noi_dung = @info WHERE id_tour = @id ;",
              new object[] { tour.TourName, tour.TourPrice, tour.TourInfo, tour.IdTour });
        }
        public void deteleTour(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM tour WHERE id_tour = @id ;", new object[] { id });
        }
        public void insertTour(Tour tour)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_tour( @ten , @price , @info );", new object[] { tour.TourName, tour.TourPrice, tour.TourInfo });
        }
        public List<Location> GetLocationbyTourID(int id)
        {
            List<Location> Locations = new List<Location>();
            string select = "select dia_diem.*  ";
            string from = "from dia_diem, chi_tiet_tour ";
            string where = "where chi_tiet_tour.id_tour = @id and chi_tiet_tour.id_dia_diem = dia_diem.id_dia_diem; ";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Location Location = new Location(item);
                Locations.Add(Location);
            }
            return Locations;
        }

        public int add_LocationtoTour(int idTour, int idLocation)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select add_dia_diem_to_tour( @id_tour , @id_location );",
                new object[] { idTour, idLocation });
        }
        public void delete_LocationtoTour(int idTour, int idLocation)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM chi_tiet_tour where id_tour = @id_Tour and id_dia_diem =  @id_Location ;",
               new object[] { idTour, idLocation });
        }
    }
}
