using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ContractEmployees:BaseEmployee
    {
       
        public double HourlySalary { get; set; }
        public int TotalHoursWorked { get; set; }        
        public override double GetSalary()
        {
            return this.HourlySalary * this.TotalHoursWorked;
        }
        
    }
}