using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects
{
    public class Account
    {
        #region private field
        private int accountId;

        private string accountName;

        private string accountPassword;

        #endregion

        #region get, set

        public int AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.accountId = value;
            }
        }

        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.accountName = value;  
            }
        }

        public string AccountPassword
        {
            get
            {
                return this.accountPassword;
            }


            set
            {
                this.accountPassword = value; 
            }
        }

        #endregion

        #region constructor

        public Account(int id, string accountname, string accountpassword)
        {
            AccountId = id;
            AccountName = accountname;
            AccountPassword = accountpassword; 
        }
        public Account(DataRow row)
        {
            AccountId = row["id_tai_khoan"].GetHashCode();
            AccountName = row["ten_tai_khoan"].ToString();
            AccountPassword = row["mat_khau"].ToString();


        }

        #endregion 

    }
}
