using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace WindowsFormsApp1
{
    class AzkariDataBase
    {
        static string connectionString = "Data source=.;initial catalog=AzkarDB;Integrated security = true;";

        public static string GetRandowZekr()
        {
            string zekr="";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "select top 1 *  from Azkar order by newid();";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                zekr = (string)reader["zekr"];

                    reader.Close();
                }

            }
            catch
            {
                zekr = "#";
            }
            finally
            {
                connection.Close();
            }







            return zekr;
        }




        public static bool AddZekr(string newZekr)
        {
            //bool isADDEd = false;
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = $"insert  into Azkar (zekr) values('{newZekr}'); ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();


              
            }
            catch
            {
               
            }
            finally
            {
                connection.Close();
            }

            return (rowAffected > 0);



        }




        public static DataTable Azkarlist()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "select * from Azkar;";
            SqlCommand command = new SqlCommand(query,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool Delete(int ID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string qurey =$"delete from Azkar where id = {ID}";
            SqlCommand command = new SqlCommand(qurey, connection);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowAffected > 0);

        }




    }








}
