using System;
using System.Collections.Generic;

namespace business
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company KittenMittens = new Company("Kitten Mittens", new DateTime(2010, 6, 7), new List<Employee>());

            // Create three employees
            Employee Charlie = new Employee("Charlie", "Kelly", "CEO", new DateTime(2010, 6, 7));
            Employee Ronald = new Employee("Ronald", "MacDonald", "Videographer", new DateTime(2010, 8, 10));
            Employee Frank = new Employee("Frank", "Reynolds", "Investor", new DateTime(2010, 10, 5));
            // Assign the employees to the company
            KittenMittens.Employees.Add(Charlie);
            KittenMittens.Employees.Add(Ronald);
            KittenMittens.Employees.Add(Frank);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            KittenMittens.EmployeesList();
        }
    }
}