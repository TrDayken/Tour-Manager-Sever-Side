using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Tour_Manager_Sever_Side.Objects;
using Tour_Manager_Sever_Side.Objects.person;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class TransferData
    {
        private static TransferData instance;
        public static TransferData Instance
        {
            get { if (instance == null) instance = new TransferData(); return TransferData.instance; }
            private set { TransferData.instance = value; }
        }
        private TransferData() { }



        public List<Transfer> GetAllTransfer()
        {
            List<Transfer> Transfers = new List<Transfer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from giao_dich;");
            foreach (DataRow item in data.Rows)
            {
                Transfer Transfer = new Transfer(item);
                Transfers.Add(Transfer);
            }
            return Transfers;
        }

        public Transfer GetTransfer(int id)
        {

            List<Transfer> Transfers = new List<Transfer>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from doan where id_giao_dich = @id ;", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Transfer Transfer = new Transfer(item);
                Transfers.Add(Transfer);
            }
            return Transfers[0];
        }
        public void updateTransfer(Transfer transfer)
        {
            string update = "UPDATE giao_dich SET ";
            string transferDate = "ngay_giao_dich = @ngay_giao_dich ,";
            string Ammount = " so_tien = @so_tien ,";
            string AccountId = " id_tai_khoan = @id_tai_khoan ";
            string where = "where id_giao_dich = @id ; ";
            string query = update + transferDate + Ammount + AccountId + where;
            DataProvider.Instance.ExecuteVoidQuery(query,
                new object[] { transfer.TransferDate, transfer.Ammount, transfer.AccountId, transfer.IdTransfer });
        }
        public void deteleTransfer(int id)
        {
            DataProvider.Instance.ExecuteVoidQuery("DELETE FROM giao_dich WHERE id_giao_dich = @id ;", new object[] { id });
        }
        public void insertTransfer(Transfer transfer)
        {
            DataProvider.Instance.ExecuteVoidQuery("select add_transfer( @ngay_giao_dich , @so_tien , @id_tai_khoan );",
                new object[] { transfer.TransferDate, transfer.Ammount, transfer.AccountId });
        }
    }
}
