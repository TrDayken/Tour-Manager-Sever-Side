using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class LocationData
    {
        private static LocationData instance;
        public static LocationData Instance
        {
            get { if (instance == null) instance = new LocationData(); return LocationData.instance; }
            private set { LocationData.instance = value; }
        }
        private LocationData() { }
        public List<Location> GetAllLocation()
        {
            List<Location> locations = new List<Location>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Dia_Diem;");
            foreach (DataRow item in data.Rows)
            {
                Location location = new Location(item);
                locations.Add(location);
            }
            return locations;
        }
        public Location GetLocation(int id)
        {
          
            List<Location> locations = new List<Location>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Dia_Diem where id_dia_diem = @id;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Location location = new Location(item);
                locations.Add(location);
            }
            return locations[0];
        }
        public void updateLocation(int id, string name, string info)
        {
            DataProvider.Instance.ExecuteVoidQuery("UPDATE dia_diem SET ten_dia_diem = @ten , dac_diem = @dacdiem WHERE id_dia_diem = @id ;",
              new object[] { name, info, id });
        }
        public void deteleLocation(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM dia_diem WHERE id_dia_diem = @id ;", new object[] { id });
        }
        public void insertLocation( string name, string info)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_location( @ten , @info );", new object[] { name, info });
        }
    }
}
