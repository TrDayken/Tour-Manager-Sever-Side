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
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Dia_Diem;");
            foreach (DataRow item in data.Rows)
            {
                Tour Tour = new Tour(item);
                Tours.Add(Tour);
            }
            return Tours;
        }
    }
}
