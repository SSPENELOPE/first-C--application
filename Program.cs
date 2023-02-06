using System.Threading.Tasks;
namespace CatWorx.BadgeMaker
{
    class Program
    {


        // Main function/entry point
        async static Task Main(string[] args)
        {
            // Run the function to get the api data
            List<Employee> employees = await PeopleFetcher.GetFromApi();

            // Print the data in the console
            Util.PrintEmployees(employees);

            // Add the data to our CSV file
            Util.MakeCSV(employees);

            // Create badges with the data
            await Util.MakeBadges(employees);
        }
    }
}
