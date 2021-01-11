using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Expenses
    {
        #region private field 
        private int expensesId;

        private decimal hotelExpenses;

        private decimal vehicleExpenses;

        private decimal otherExpenses;

        private int crewId;
#endregion

        #region get, set 

        public int ExpensesId
        {
            get { return this.expensesId; }

            set { this.expensesId = value; }

        }

        public decimal HotelExpenses
        {
            get { return this.hotelExpenses; }

            set { this.hotelExpenses = value; }
        }

        public decimal VehicleExpenses
        {
            get { return this.vehicleExpenses; }

            set { this.vehicleExpenses = value; }
        }

        public decimal OtherExpenses
        {
            get { return this.otherExpenses; }

            set { this.otherExpenses = value; }
        }

        public int CrewId
        {
            get { return this.crewId; }

            set { this.crewId = value; }
        }
        #endregion

        #region constructor

        public Expenses() { }

        public Expenses(int id , decimal hotel, decimal vehicle, decimal other, int crewid)
        {
            ExpensesId = id;

            VehicleExpenses = vehicle;

            HotelExpenses = hotel;

            OtherExpenses = other;

            CrewId = crewid; 
        }

        public Expenses(DataRow row)
        {
            ExpensesId = row["id_chi_phi"].GetHashCode();

            VehicleExpenses = row["chi_phi_phuong_tien"].GetHashCode();

            HotelExpenses = row["chi_phi_khach_san"].GetHashCode();

            OtherExpenses = row["chi_phi_khac"].GetHashCode();

            CrewId = row["id_doan"].GetHashCode();
        }

        #endregion 
    }
}
