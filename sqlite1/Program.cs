using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1612
{
    class Program
    {
        static void Main(string[] args)
        {
            // NUGGET ---- System.Data.SQLite

            string path = "C:\\itay\\sqlite\\sql1.db";
            using (SQLiteConnection con = new SQLiteConnection($"Data source ={path}; Version = 3;")) // Connection String
            {
                con.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM COMPANY", con))
                {

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader.GetValue(0)}, {reader.GetValue(1)}, {reader.GetValue(2)}, {reader.GetValue(3)}, {reader.GetValue(4)}");
                        }
                    }
                    //reader.Close();
                }

                //cmd.Dispose();
            }
            //con.Close(); // happen always because of te using

        }
    }
}
