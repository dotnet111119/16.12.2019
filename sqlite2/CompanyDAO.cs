using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612
{
    // Data Access Object (DAL)
    public static class CompanyDAO
    {
        internal static List<Employee> GetEmployees()
        {
            List<Employee> results = new List<Employee>();

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
                            //   Console.WriteLine(
                            //     $"{reader.GetValue(0)}, {reader.GetValue(1)}, {reader.GetValue(2)}, {reader.GetValue(3)}, {reader.GetValue(4)}");
                            Employee e = new Employee
                            {
                                ID = reader.GetInt32(0),
                                NAME = reader.GetString(1),
                                AGE = reader.GetInt32(2),
                                ADDRESS = reader.GetString(3),
                                SALARY = reader.GetDouble(4)
                            };
                            results.Add(e);
                        }
                    }
                    //reader.Close();
                }

                //cmd.Dispose();
            }
            //con.Close(); // happen always because of te using
            return results;
        }
    }
}
