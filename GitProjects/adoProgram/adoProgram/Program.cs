using System;

using System.Data.SqlClient;
using System.Configuration;

namespace adoProgram
{
    class Program
    {
        public void createTable()
        {
          string cs=  ConfigurationManager.ConnectionStrings["abc"].ConnectionString;

           SqlConnection con = new SqlConnection(cs);
            using (SqlCommand cmd = new SqlCommand("select * from player", con))
            {
                con.Open();
               SqlDataReader rd= cmd.ExecuteReader();
                while (rd.Read()) { 
                  Console.WriteLine(rd["player_Id"]+" "+rd["country_Id"]+" "+rd["player_Name"]+" "+rd["runs_made"]+" "+rd["wickets_Taken"]);
            }
                //  Console.WriteLine(rd.HasRows);
                // Console.WriteLine(rd.IsClosed);
              
                }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.createTable();
            Console.ReadKey();
        }
    }
}
