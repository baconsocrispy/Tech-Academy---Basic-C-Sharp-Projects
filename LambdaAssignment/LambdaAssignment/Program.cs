using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a list of at least 10 employees
            // at least 2 should have the first name "Joe"
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Joe" });
            employees.Add(new Employee() { Id = 2, FirstName = "Jim" });
            employees.Add(new Employee() { Id = 3, FirstName = "John" });
            employees.Add(new Employee() { Id = 4, FirstName = "Joe" });
            employees.Add(new Employee() { Id = 5, FirstName = "Alice" });
            employees.Add(new Employee() { Id = 6, FirstName = "Arnold" });
            employees.Add(new Employee() { Id = 7, FirstName = "Jill" });
            employees.Add(new Employee() { Id = 8, FirstName = "Janice" });
            employees.Add(new Employee() { Id = 9, FirstName = "Bog" });
            employees.Add(new Employee() { Id = 10, FirstName = "Joe" });

            // create a new list of all "Joe"s using a foreach loop
            List<Employee> joe_list = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joe_list.Add(employee);
                }
            }

            // using a lambda expression make a list of all employees with id > 5
            List<Employee> new_list = employees.Where(employee => employee.Id > 5).ToList();


            // testing that it worked
            foreach (Employee employee in joe_list)
            {
                Console.WriteLine(employee.FirstName);
            }
            foreach (Employee employee in new_list)
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.ReadLine();

        }
    }
}
