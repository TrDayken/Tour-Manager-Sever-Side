using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Model
{
    public class UserCred
    {
        #region private field
        private string userName;

        private string password;

        #endregion

        #region get, set

        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.userName = value; 
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value; 
            }
        }

        #endregion

        #region constructor

        public UserCred(string accountname, string password)
        {
            this.UserName = accountname;
            this.Password = password;
        }

        #endregion
    }
}
