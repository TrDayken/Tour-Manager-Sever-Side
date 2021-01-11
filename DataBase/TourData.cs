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
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tour where id_tour = @id;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                Tours.Add(Tour);
            }
            return Tours[0];
        }
        public void updateTour(int id, string name, double price, string info)
        {
            DataProvider.Instance.ExecuteVoidQuery("UPDATE tour SET ten_tour = @ten , gia_tour = @price , noi_dung = @info WHERE id_tour = @id ;",
              new object[] { name,price, info, id });
        }
        public void deteleTour(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM tour WHERE id_tour = @id ;", new object[] { id });
        }
        public void insertTour(string name,double price , string info)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_tour( @ten , @price , @info );", new object[] { name, price , info });
        }
    }
}
