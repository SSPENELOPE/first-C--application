using System.Threading.Tasks;
namespace CatWorx.BadgeMaker
{
    class Program
    {


        /* Main function/entry point*/
        async static Task Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = await PeopleFetcher.GetFromApi();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
    }
}
