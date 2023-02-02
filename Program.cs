using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class Program {
        /* Function to get employees names */
        static List<string> GetEmployees() {
            List<string> employees = new List<string>();
            while (true) {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                if (input == "") {
                    break;
                }
                employees.Add(input);
            }
                // This is important!
                // Passes the stored employees to the main
                return employees;
        }
        /* Function to print employee names */
        static void PrinteEmloyees(List<string> employees) {
            for (int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i]);
            }
        }

        /* Main function/entry point*/
        static void Main(string[] args) {
              // This is our employee-getting code now
                List<string> employees = GetEmployees();
                PrinteEmloyees(employees);
        }
    }
}
