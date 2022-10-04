using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Suisse
{
    internal class Database
    {

        private string connectionString;
        private SqlConnection cnn;
        private SqlCommand cmd;

        private SqlConnection ConexaoBanco()
        {;
            //Connect SQL server
            try
            {
                //string connection SQL server
                connectionString = @"Data Source=DESKTOP-9GCFA48\SQLEXPRESS;Initial Catalog=wallet;User ID=muriloteste;Password=159753";
                cnn = new SqlConnection(connectionString);

                //Open SQL server connection
                cnn.Open();
                Console.WriteLine("Connect SQL server Open!");
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se Conectar no banco de dados \n " +
                    "Verifique os dados informados" + erro);
            }
            return cnn;
        }

        public void getListTrades()
        {

            //Command SQL --SqlCommand

            try
            {
                cmd = new SqlCommand("SELECT * FROM trades");

                //connect with the bank
                cmd.Connection = ConexaoBanco();

                //run command
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Trading trade = new Trading(reader.GetInt32(2), reader.GetInt32(0), reader.GetString(1));
                        trade.showData();
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();

                //closer connection SQL serve
                cnn.Close();
            }
            catch (SqlException erro)
            {
                Console.WriteLine(erro);
            }
        }
    }
}
