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
            
            // Language Integrated Query (LINQ)
           //employees.Where(e => e.AGE > 20).ToList().ForEach(e => Console.WriteLine(e));

            var result = from e in employees
                                     where e.AGE > 20
                                     orderby e.AGE
                                     select e;

            result.ToList().ForEach(e => Console.WriteLine(e));
        }
    }
}
