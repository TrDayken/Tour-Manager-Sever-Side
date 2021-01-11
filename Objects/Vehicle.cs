using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Vehicle
    {
        #region privatefield 
        private int vehicleId;

        private string vehicleName;

        private string vehicleSign;

        private string vehicleType;

#endregion

        #region    get, set
        public int VehicleId
        {
            get { return this.vehicleId; }

            set { this.vehicleId = value; }
        }
        public string VehicleName
        {
            get { return this.vehicleName; }

            set { this.vehicleName = value; }
        }

        public string VehicleSign
        {
            get { return this.vehicleSign; }

            set { this.vehicleSign = value; }
        }

        public string VehicleType
        {
            get { return this.vehicleType; }

            set { this.vehicleType = value; }
        }

        #endregion 

        #region constructor
        public Vehicle()
        {
        }

        public Vehicle(int id, string name, string sign, string type)
        {
            VehicleId = id;

            VehicleName = name;

            VehicleSign = sign;

            VehicleType = type; 
        }
        public Vehicle(DataRow row)
        {
            VehicleId = row["id_phuong_tien"].GetHashCode();

            VehicleName = row["ten_phuong_tien"].ToString();

            VehicleSign = row["ban_so"].ToString();

            VehicleType = row["loai_xe"].ToString();
        }

        #endregion
    }
}
