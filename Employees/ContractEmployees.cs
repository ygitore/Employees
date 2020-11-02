using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractEmployee
{
    class ContractEmployees : BaseEmployee, IComparable<ContractEmployees> 
    {
       
        public double HourlySalary { get; set; }
        public int TotalHoursWorked { get; set; }        
        public override double GetSalary()
        {
            return this.HourlySalary * this.TotalHoursWorked;
        }
        
        public int CompareTo(ContractEmployees emp)
        {
            return this.FirstName.CompareTo(emp.FirstName);
        }
        
    }
}