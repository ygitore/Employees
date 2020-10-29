using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public DateTime EmploymentDate { get; set; }
        public abstract double GetSalary();        
        public void FullName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}
