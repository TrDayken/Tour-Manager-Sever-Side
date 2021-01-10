using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Location
    {
        #region private field 
        private int locationId;

        private string locationName;

        private string locationInfo;

        #endregion

        #region    get,set

        public int LocationId
        {
            get { return this.locationId; }

            set { this.locationId = value; }
        }

        public string LocationName
        {
            get { return this.locationName; }

            set { this.locationName = value; }
        }

        public string LocationInfo
        {
            get { return this.locationInfo; }

            set { this.locationInfo = value; }
        }
        #endregion

        #region constructor

        public Location() { }

        public Location(int id, string name, string info)
        {
            LocationId = id;

            LocationName = name;

            LocationInfo = info;
        }

        public Location(DataRow row)
        {
            LocationId = row["ID_Dia_Diem"].GetHashCode();

            LocationName = row["Ten_Dia_Diem"].ToString();

            LocationInfo = row["Dac_Diem"].ToString();
        }
        #endregion
    }
}
