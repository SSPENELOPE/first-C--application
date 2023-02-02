using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class Program {
        /* Function to get employees names */
        static List<Employee> GetEmployees() {
            List<Employee> employees = new List<Employee>();
            while (true) {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                if (input == "") {
                    break;
                }
                Employee currentEmployee = new Employee(input, "smith");
                employees.Add(currentEmployee);
            }
                // This is important!
                // Passes the stored employees to the main
                return employees;
        }
        /* Function to print employee names */
        static void PrintEmployees(List<Employee> employees) {
            for (int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i].GetFullName());
            }
        }

        /* Main function/entry point*/
        static void Main(string[] args) {
              // This is our employee-getting code now
                List<Employee> employees = GetEmployees();
                PrintEmployees(employees);
        }
    }
}
