using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class ExpensesData
    {
        private static ExpensesData instance;
        public static ExpensesData Instance
        {
            get { if (instance == null) instance = new ExpensesData(); return ExpensesData.instance; }
            private set { ExpensesData.instance = value; }
        }
        private ExpensesData() { }



        public List<Expenses> GetAllExpenses()
        {
            List<Expenses> expensess = new List<Expenses>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from chi_phi;");
            foreach (DataRow item in data.Rows)
            {
                Expenses expenses = new Expenses(item);
                expensess.Add(expenses);
            }
            return expensess;
        }

        public Expenses GetExpenses(int id)
        {

            List<Expenses> Expensess = new List<Expenses>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan where id_chi_phi = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Expenses Expenses = new Expenses(item);
                Expensess.Add(Expenses);
            }
            return Expensess[0];
        }
        public void updateExpenses(Expenses Expenses)
        {
            string update = "UPDATE chi_phi SET ";
            string VehicleExpenses = "chi_phi_phuong_tien = @chi_phi_phuong_tien ,";
            string HotelExpenses = " chi_phi_khach_san = @chi_phi_khach_san ,";
            string OtherExpenses = " chi_phi_khac = @chi_phi_khac ,";
            string CrewId = " id_doan = @id_doan ";
            string where = "where id_chi_phi = @id ; ";
            string query = update + VehicleExpenses + HotelExpenses+OtherExpenses + CrewId + where;
            DataProvider.Instance.ExecuteVoidQuery(query,
                new object[] { Expenses.VehicleExpenses, Expenses.HotelExpenses, Expenses.OtherExpenses, Expenses.CrewId, Expenses.ExpensesId });
        }
        public void deteleExpenses(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM chi_phi WHERE id_chi_phi = @id ;", new object[] { id });
        }
        public void insertExpenses(Expenses Expenses)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_expenses( @chi_phi_phuong_tien , @chi_phi_khach_san , @chi_phi_khac , @id_doan );",
                new object[] { Expenses.VehicleExpenses, Expenses.HotelExpenses, Expenses.OtherExpenses, Expenses.CrewId });
        }
    }
}
