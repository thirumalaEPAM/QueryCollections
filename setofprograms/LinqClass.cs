using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setofprograms
{
    public class LinqClass
    {

        /// <summary>
        /// This Method display Employees data whose Salary > 500000
        /// </summary>
        /// <param name="employees"></param>

        public void filteremp_highsal(List<Employee> employees)
        {


            var highSalary = employees.Where(e => e.Salary > 50000);

            foreach (var emp in highSalary)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary} - {emp.Age} - {emp.Deportmanet}");
            }

        }


        /// <summary>
        /// Get All Employees Data
        /// </summary>
        /// <returns></returns>

        public List<Employee> get_employees()
        {
            return Task_Constant.employees;
        }

        public void display_employee_names(List<Employee> employees)
        {
            var names = employees.Select(e => e.Name).ToList();
            foreach (var name in names)
            {
                Console.WriteLine($"employeename - {name}");
            }
        }

        public void sort_employee_salary(List<Employee> employees, char t)
        {
            if (t == 'a')
            {
                var emp = employees.OrderBy(e => e.Salary).FirstOrDefault();
            }
            else
            {
                var emp = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
            }
        }



        public void sort_employee_multiple(List<Employee> employees)
        {
            var emp = employees.OrderBy(e => e.Deportmanet)
                .ThenBy(e => e.Salary).ToList();
            show_emp_info(emp);
        }
        public void show_emp_info(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary} - {emp.Age} - {emp.Deportmanet}");
            }
        }

        //Create a method to group employees by department and display the count of employees in each department.
        public void group_by_department(List<Employee> employees)
        {
            var grouped = employees.GroupBy(e => e.Deportmanet)
                .Select(g => new { Department = g.Key, Count = g.Count() });
            foreach (var group in grouped)
            {
                Console.WriteLine($"Department: {group.Department}, Count: {group.Count}");
            }
        }

        //Create a method to find the average salary of employees in each department.
        public void average_salary_by_department(List<Employee> employees)
        {
            var averageSalaries = employees.GroupBy(e => e.Deportmanet)
                .Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) });
            foreach (var group in averageSalaries)
            {
                Console.WriteLine($"Department: {group.Department}, Average Salary: {group.AverageSalary}");
            }


        }
    }
}
