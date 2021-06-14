using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRACTICE.Model
{
        public class Employee
        {
            public string Name { get; set; }
            public string Role { get; set; }
            public int Birthyear { get; set; }
        }
    public class Root
    {
        public List<Employee> EmployeeLists { get; set; }
    }
}
