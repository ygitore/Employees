using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class FullTimeEmployees:BaseEmployee
    {
        public double AnualSalary { get; set; }
        public double GetSalary()
        {
            return AnualSalary / 12;
        }
    }
}