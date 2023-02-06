using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        async public static Task<List<Employee>> GetFromApi()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                Console.WriteLine(json.SelectToken("results[0].name.first"));
                Console.WriteLine(json.SelectToken("results[1].name.first"));
                Console.WriteLine(json.SelectToken("results[2].name.first"));
            }

            List<Employee> employees = new List<Employee>();
            return employees;
        }
    }
}