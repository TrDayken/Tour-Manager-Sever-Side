using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects.person;
using Tour_Manager_Sever_Side.Objects;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class PersonData
    {
        private static PersonData instance;
        public static PersonData Instance
        {
            get { if (instance == null) instance = new PersonData(); return PersonData.instance; }
            private set { PersonData.instance = value; }
        }
        private PersonData() { }

        

        public List< Person> GetAllPerson()
        {
            List< Person>  Persons = new List<Person>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from nguoi;");
            foreach (DataRow item in data.Rows)
            {
                 Person person = new Person(item);
                 Persons.Add( person);
            }
            return  Persons;
        }

        public  Person GetPerson(int id)
        {

            List< Person>  persons = new List< Person>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from nguoi where id_ = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                 Person  person = new  Person(item);
                 persons.Add( person);
            }
            return  persons[0];
        }
        public void updatePerson(Person person)
        {
            string update = "UPDATE nguoi SET ";
            string ten = "ten = @ten ,";
            string cmnd = " cmnd = @cmnd ,";
            string gioi_tinh = " gio_tinh = @gio_tinh ,";
            string dien_thoai = " dien_thoai = @dien_thoai ,";
            string id_tai_khoan = " id_tai_khoan = @id_tai_khoan ";
            string where = "where id_ = @id ; ";
            string query = update + ten + cmnd + gioi_tinh + dien_thoai + id_tai_khoan + where;
            DataProvider.Instance.ExecuteVoidQuery(query, 
                new object[] { person.Name, person.IdentificationCard, person.Gender, person.PhoneNumber, person.AccountId, person.PersonId });
        }
        public void detelePerson(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM nguoi WHERE id_ = @id ;", new object[] { id });
        }
        public void insertPerson(Person person)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_person( @ten , @cmnd , @goi_tinh , @dien_thoai , @id_tai_khoan );", 
                new object[] { person.Name, person.IdentificationCard, person.Gender, person.PhoneNumber, person.AccountId });
        }
    }
}
