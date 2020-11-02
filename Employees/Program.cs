using ContractEmployee;
using Employees;
using FullTimeEmployee;
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
                TotalHoursWorked = 27,
                HourlySalary = 45,
                Position = "Business Analyst",
                EmploymentDate = new DateTime(2016, 09, 13)
            };


            List<ContractEmployees> emp = new List<ContractEmployees>();
            emp.Add(cte);
            emp.Add(cte2);
            emp.Add(cte3);
            ContractEmployees cte5 = new ContractEmployees()
            {
                Id = 105,
                FirstName = "Kevin",
                LastName = "Durilo",
                Email = "kevin@yahoo.com",
                Gender = Gender.Female,
                TotalHoursWorked = 30,
                HourlySalary = 45,
                Position = "Business Analyst",
                EmploymentDate = new DateTime(2016, 09, 13)
            };
            ContractEmployees cte6 = new ContractEmployees()
            {
                Id = 106,
                FirstName = "nati",
                LastName = "naelo",
                Email = "naeolo@yahoo.com",
                Gender = Gender.Female,
                TotalHoursWorked = 40,
                HourlySalary = 45,
                Position = "Business Analyst",
                EmploymentDate = new DateTime(2016, 09, 13)
            };
            List<ContractEmployees> contractEmployees = new List<ContractEmployees>();
            contractEmployees.Add(cte5);
            contractEmployees.Add(cte6);
            contractEmployees.AddRange(emp);

            contractEmployees.Sort();
            foreach (var e in contractEmployees)
            {
                e.FullName();
                Console.WriteLine(e.GetSalary());
            }

            Console.Read();
        }
        
    }
}