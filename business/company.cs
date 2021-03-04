using System;
using System.Collections.Generic;

namespace business
{
    public class Company
    {
        public DateTime DateFounded { get; }
        public string CompanyName { get; }
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime founded, List<Employee> employees)
        {
            CompanyName = name;
            DateFounded = founded;
            Employees = employees;
        }

        public void EmployeesList()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} has worked for {CompanyName} since {employee.StartDate.ToString("d")}.");
            }
        }
    }
}