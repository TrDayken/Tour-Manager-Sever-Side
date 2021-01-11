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
                new object[] { crew.Info , crew.StartDate , crew.EndDate , crew.TourId , crew.CrewId });
        }
        public void deteleCrew(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM nguoi WHERE id_ = @id ;", new object[] { id });
        }
        public void insertCrew(Crew crew)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_crew( @info , @ngay_bat_dau , @ngay_ket_thuc , @id_tour );",
                new object[] { crew.Info, crew.StartDate, crew.EndDate, crew.TourId });
        }
    }
}
