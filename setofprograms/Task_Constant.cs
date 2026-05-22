using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setofprograms
{
    static class Task_Constant
    {
        public static int val = 12222;
       
        public static List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Raj", Salary = 50000, Age = 30, Deportmanet = "IT" },
            new Employee { Name = "Sam", Salary = 60000, Age = 28 , Deportmanet = "Pharma" },
            new Employee { Name = "John", Salary = 70000, Age = 35, Deportmanet = "IT" },
            new Employee { Name = "Ravi", Salary = 40000, Age = 25, Deportmanet = "Pharma" }
        };
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Deportmanet { get; set; }
    }
}
