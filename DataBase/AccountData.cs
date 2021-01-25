using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class AccountData
    {
        private static AccountData instance;
        public static AccountData Instance
        {
            get { if (instance == null) instance = new AccountData(); return AccountData.instance; }
            private set { AccountData.instance = value; }
        }
        private AccountData() { }

        public List<int> GetAllId()
        {
            List<int> id_accounts = new List<int>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select id_tai_khoan from tai_khoan;");
            foreach (DataRow item in data.Rows)
            {
                int id = item["id_tai_khoan"].GetHashCode();
                id_accounts.Add(id);
            }
            return id_accounts;
        }
        public int login(string tk, string mk)
        {
            int id =(int) DataProvider.Instance.ExecuteScalar("Select login( @tk , @mk )", new object[] { tk, mk });
            return id;
        }
        public int register(string tk, string mk)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("select register( @tk , @mk )", new object[] { tk, mk });
            return id;
        }
        public int  update(string tk, string mk, string new_mk)
        {
            return (int)DataProvider.Instance.ExecuteScalar("select update_account( @tk , @mk , @new_mk );", new object[] { tk, mk, new_mk }); 
        }
        public Person GetPersonByIDAccount(int id)
        {
            List<Person> Persons = new List<Person>();
            string select = "select nguoi.*  ";
            string from = "from nguoi ";
            string where = "where id_tai_khoan = @id ;";
            string query = select + from + where;
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Person Person = new Person(item);
                Persons.Add(Person);
            }
            return Persons[0];
        }
    }
}
