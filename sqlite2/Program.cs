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

            List<Employee> employees = CompanyDAO.GetEmployees();
            employees.ForEach(e => Console.WriteLine(e));
        }
    }
}
