using Employees;
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
                Gender=Gender.Male,
                AnualSalary = 80000,
                Position = "Software Engineer",
                EmploymentDate = new DateTime(2019, 05, 24)
            };

            Console.WriteLine("<---------------------------->");
            ContractEmployees cte = new ContractEmployees()
            {
                Id = 102,
                FirstName = "Smith",
                LastName = "peter",
                Email = "smithpeter@gmail.com",
                Gender = Gender.Male,
                TotalHoursWorked = 40,
                HourlySalary = 35,
                Position = "Cyber Security Specialist",
                EmploymentDate = new DateTime(2015, 09, 13)
            };
            ContractEmployees cte2 = new ContractEmployees()
            {
                Id = 103,
                FirstName = "simon",
                LastName = "David",
                Email = "semon@gmail.com",
                Gender = Gender.Unknown,
                TotalHoursWorked = 35,
                HourlySalary = 45,
                Position = "Cyber Security Specialist",
                EmploymentDate = new DateTime(2016, 09, 13)
            };
            ContractEmployees cte3 = new ContractEmployees()
            {
                Id = 104,
                FirstName = "Ashley",
                LastName = "Cantino",
                Email = "ashley@yahoo.com",
                Gender = Gender.Female,
                TotalHoursWorked = 40,
                HourlySalary = 45,
                Position = "Business Analyst",
                EmploymentDate = new DateTime(2016, 09, 13)
            };
            List<ContractEmployees> emp = new List<ContractEmployees>();
            emp.Add(cte);
            emp.Add(cte2);
            emp.Add(cte3);
            foreach (ContractEmployees cEmp in emp)
            {
                cEmp.FullName();
                Console.Write(cEmp.Gender);
                Console.WriteLine();
            }            
            Console.Read();
        }
        
    }

}