using System;
using System.Collections.Generic;
namespace BadgeMaker
{
    class Program
    {

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Enter first name (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }

                // add a console readline for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();
                // Create a new Employee Instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }

        static void Main(string[] args)
        {
            // This is our employee getting code now
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}

