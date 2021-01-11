using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Person
    {
        #region private field
        private int personId;

        private string name;

        private string identificationCard;

        private bool gender;

        private string phoneNumber;

        private int accountId;

        #endregion

        #region get, set
        public int PersonId
        {
            get { return this.personId; }

            set { this.personId = value; }
        }

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public string IdentificationCard
        {
            get { return this.identificationCard; }

            set { this.identificationCard = value; }
        }

        public bool Gender
        {
            get { return this.gender; }

            set { this.gender = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }

            set { this.phoneNumber = value; }
        }

        public int AccountId
        {
            get { return this.accountId; }

            set { this.accountId = value; }
        }

        #endregion

        #region constructor
        public Person() { }

        public Person(int id, string name, string card, bool gender, string phone, int accountid)
        {
            PersonId = id;

            Name = name;

            IdentificationCard = card;

            Gender = gender;

            PhoneNumber = phone;

            AccountId = accountid; 
        }
        public Person(DataRow row)
        {
            PersonId = row["id_"].GetHashCode(); 

            Name = row["ten"].ToString();

            IdentificationCard = row["cmnd"].ToString();

            Gender = Convert.ToBoolean(row["gio_tinh"]);

            PhoneNumber = row["dien_thoai"].ToString();

            AccountId = row["id_tai_khoan"].GetHashCode() ;
        }

        #endregion
    }
}
