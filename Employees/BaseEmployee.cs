using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    abstract class BaseEmployee
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _position;
        private DateTime _employmentDate;
        public int Id { get; set; }
        public string FirstName 
        { 
            get { return this._firstName;  }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("FirstName is required");
                }
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("LastName is required");
                }
                this._lastName = value;
            }
        }
        public string Email
        {
            get { return this._email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email is required");
                }
                this._email = value;
            }
        }
        public string Position
        {
            get { return this._position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Position is required");
                }
                this._position = value;
            }
        }
        public DateTime EmploymentDate
        {
            get { return this._employmentDate; }
            set
            {
                this._employmentDate = value;
            }
        }

        public abstract double GetSalary();        
        public void FullName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}
