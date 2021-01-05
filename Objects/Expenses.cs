using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Expenses
    {
        #region private field 
        private int expensesId;

        private float hotelExpenses;

        private float vehicleExpenses;

        private float otherExpenses;

        private int crewId;
#endregion

        #region get, set 

        public int ExpensesId
        {
            get { return this.expensesId; }

            set { this.expensesId = value; }

        }

        public float HotelExpenses
        {
            get { return this.hotelExpenses; }

            set { this.hotelExpenses = value; }
        }

        public float VehicleExpenses
        {
            get { return this.vehicleExpenses; }

            set { this.vehicleExpenses = value; }
        }

        public float OtherExpenses
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

        public Expenses(int id , float hotel, float vehicle, float other, int crewid)
        {
            ExpensesId = id;

            VehicleExpenses = vehicle;

            HotelExpenses = hotel;

            OtherExpenses = other;

            CrewId = crewid; 
        }

        #endregion 
    }
}
