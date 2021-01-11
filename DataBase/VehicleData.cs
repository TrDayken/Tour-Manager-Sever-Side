using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class VehicleData
    {
        private static VehicleData instance;
        public static VehicleData Instance
        {
            get { if (instance == null) instance = new VehicleData(); return VehicleData.instance; }
            private set { VehicleData.instance = value; }
        }
        private VehicleData() { }



        public List<Vehicle> GetAllVehicle()
        {
            List<Vehicle> Vehicles = new List<Vehicle>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from phuong_tien;");
            foreach (DataRow item in data.Rows)
            {
                Vehicle Vehicle = new Vehicle(item);
                Vehicles.Add(Vehicle);
            }
            return Vehicles;
        }

        public Vehicle GetVehicle(int id)
        {

            List<Vehicle> Vehicles = new List<Vehicle>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan where id_phuong_tien = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Vehicle Vehicle = new Vehicle(item);
                Vehicles.Add(Vehicle);
            }
            return Vehicles[0];
        }
        public void updateVehicle(Vehicle Vehicle)
        {
            string update = "UPDATE phuong_tien SET ";
            string vehicleName = "ten_phuong_tien = @ten_phuong_tien ,";
            string vehicleSign = " ban_so = @ban_so ,";
            string vehicleType = " loai_xe = @loai_xe ";
            string where = "where id_phuong_tien = @id ; ";
            string query = update + vehicleName + vehicleSign + vehicleType + where;
            DataProvider.Instance.ExecuteVoidQuery(query,
                new object[] { Vehicle.VehicleName, Vehicle.VehicleSign, Vehicle.VehicleType, Vehicle.VehicleId });
        }
        public void deteleVehicle(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM phuong_tien WHERE id_phuong_tien = @id ;", new object[] { id });
        }
        public void insertVehicle(Vehicle Vehicle)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_vehicle( @ten_phuong_tien , @ban_so , @loai_xe );",
                new object[] { Vehicle.VehicleName, Vehicle.VehicleSign, Vehicle.VehicleType });
        }
    }
}
