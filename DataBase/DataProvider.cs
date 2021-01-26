using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Npgsql;

namespace Tour_Manager_Sever_Side.DataBase
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string connectionSTR =string.Format("Server=ec2-3-208-168-0.compute-1.amazonaws.com;Port=5432;User Id=vgcvxlntnyswvl;Password=eb13c1aa2c1c097713d5d57edae2eea31669b603cbddcec944fbbfe86573b534;Database=dd66c0poj6fdq5;Pooling=true;SslMode=Require;Trust Server Certificate=true;");
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionSTR))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    command.Prepare();

                   
                }

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalarStored(string query, object[] parameter = null)
        {
            object data = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionSTR))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    command.Prepare();

                
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
        public DataTable ExecuteQueryStored(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionSTR))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    command.Prepare();

                    
                }

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionSTR))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    command.Prepare();

                   // command.ExecuteNonQuery();
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
        public void ExecuteVoidQuery(string query, object[] parameter = null)
        {
            object data = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionSTR))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                    command.Prepare();

                    command.ExecuteNonQuery();
                }

                //data = command.ExecuteScalar();

                connection.Close();
            }
         
        }
    }
}
