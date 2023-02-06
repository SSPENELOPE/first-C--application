using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        // Api call function to get random employee data
        async public static Task<List<Employee>> GetFromApi()
        {
            // Declare the employees variable as a new List 
            List<Employee> employees = new List<Employee>();

            // Use an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                // This is the api call stored in a string
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                // Parse the Json object into something readable
                JObject json = JObject.Parse(response);

                // Loop through the data 
                foreach (JToken token in json.SelectToken("results")!)
                {
                    // Parse JSON data, remember this is the format used in the Employee.cs when we declared the Employee arguments
                    Employee emp = new Employee
                    (
                      token.SelectToken("name.first")!.ToString(),
                      token.SelectToken("name.last")!.ToString(),
                      Int32.Parse(token.SelectToken("id.value")!.ToString().Replace("-", "")),
                      token.SelectToken("picture.large")!.ToString()
                    );
                    // Add the employee data to the employees list
                    employees.Add(emp);
                }
            }
            // Remember to return the data
            return employees;
        }
    }
}