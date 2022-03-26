using System;
using System.Collections.Generic;
namespace BadgeMaker
{
    class Program
    {

        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                // Create a new Employee Instance
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee.GetName());
            }
            return employees;
        }

        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        static void Main(string[] args)
        {
            // This is our employee getting code now
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}

