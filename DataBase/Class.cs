using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;
namespace Tour_Manager_Sever_Side.DataBase
{
    public class Class
    {
        public List<Crew> GetCrewbyPersonID(int id)
        {
            List<Crew> Crews = new List<Crew>();
            string select = "select doan.*  ";
            string from = "from doan, chi_tiet_doan ";
            string where = "where chi_tiet_doan.id_nguoi = @id and chi_tiet_doan.id_doan = doan.id_doan; ";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Crew Crew = new Crew(item);
                Crews.Add(Crew);
            }
            return Crews;
        }

      
    }
}
