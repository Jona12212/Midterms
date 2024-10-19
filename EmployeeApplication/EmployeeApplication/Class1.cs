using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class Employee
    {// Properties
        public string EmployeeId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Position { get; private set; }

        // Default constructor
        public Employee() { }

        // Overloaded constructor
        public Employee(string employeeId, string firstName, string lastName, string position)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }
    }
}
