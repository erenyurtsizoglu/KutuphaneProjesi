using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace kutuphaneProjesi.Helper
{
    public class Database
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0FRFA5J;Initial Catalog=KutuphaneProje;Integrated Security=True");

        public int execute(string sqlCommand)
        {
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            int kacSatirDegismis = 0;
            try
            {
                cmd.Connection.Open();
                kacSatirDegismis = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "hata/log.txt", true);
                writer.WriteLine("Hata oluştu: " + ex.Message);
                writer.Close();
            }
            cmd.Connection.Close();
            return kacSatirDegismis;
        }

        public DataTable getData(string sqlCommand)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, connection);
            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "hata/log.txt", true);
                writer.WriteLine("Hata oluştu: " + ex.Message);
                writer.Close();
                dt = null;
            }
            connection.Close();
            return dt;
        }
    }
}