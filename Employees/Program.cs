using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployees fte = new FullTimeEmployees()
            {
                Id = 101,
                FirstName = "Mak",
                LastName = "Joe",
                Email = "makjoe@gmail.com",
                AnualSalary = 80000,
                Position = "Software Engineer",
                EmploymentDate = new DateTime(2019, 05, 24)
            };
            fte.FullName();
            Console.WriteLine("Salary",fte.GetSalary());
            Console.WriteLine("<---------------------------->");
            ContractEmployees cte = new ContractEmployees()
            {
                Id = 101,
                FirstName = "Smith",
                LastName = "peter",
                Email = "smithpeter@gmail.com",
                TotalHoursWorked = 40,
                HourlySalary = 35,
                Position = "Cyber Security Specialist",
                EmploymentDate = new DateTime(2015, 09, 13)
            };
            cte.FullName();
            Console.WriteLine("Salary", cte.GetSalary());
            Console.Read();
        }

    }
}