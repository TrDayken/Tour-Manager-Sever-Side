using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Objects.person
{
    public class Transfer
    {
        #region private field
        private int idTransfer;

        private DateTime transferDate;

        private float ammount;

        private int accountId;
#endregion

        #region get, set
        public int IdTransfer
        {
            get { return this.idTransfer; }

            set { this.idTransfer = value; }
        }

        public DateTime TransferDate
        {
            get { return this.transferDate; }

            set { this.transferDate = value; }
        }

        public float Ammount
        {
            get { return this.ammount; }

            set { this.ammount = value; }
        }

        public int AccountId
        {
            get { return this.accountId; }

            set { this.accountId = value; }
        }
#endregion

        #region constructor
        public Transfer()
        {
            
        }

        public Transfer(int id, DateTime date, float ammount, int accountid)
        {
            idTransfer = id;

            TransferDate = date;

            Ammount = ammount;

            AccountId = accountid; 
        }
#endregion  
    }
}
