 class Notes {
        public Notes() {
            /* Any function that does not return a value needs to be declared "void"*/
           /*  static void PrinteEmloyees() {
                /* Code Here*/
           // } 

               /* Console.log */
            string greeting = "Hello";
            greeting = greeting + "World";
            Console.WriteLine($"greeting: {greeting}"); 
            Console.WriteLine("greeting: {0}", greeting);

            /* Float is 32 bit foating point data type
               Holds 7 decimal points   */
            float side = 3.14F;
            float area = side * side;
            Console.WriteLine("area: {0}", area);

            /* Double is 64 bit floating data type
               accomodates 15 to 16 digits    */
            double sides = 3.14;
            double areas = sides * sides;
            Console.WriteLine("area: {0}", areas);
            Console.WriteLine("area is a {0}", area.GetType());
            Console.WriteLine("area is a {0}", areas.GetType());


            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
            Console.WriteLine(1 + 2 * 3);     // order of operations
            Console.WriteLine(10 / 3.0);      // int's and doubles
            Console.WriteLine(10 / 3);        // int's 
            Console.WriteLine("12" + "3");    // What happens here? Logs "123" 

            /* Number Declaration */
            int num = 10;
            /* Same as javascript, will add 100 to the num variable*/
            num += 100;
            Console.WriteLine(num);

            /* Same as javascript, will increment the num variable by 1 unless told to do so more times by a loop */
            num ++;
            Console.WriteLine(num);

            /* Booleans */
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

            /* Declaring a number as a string
                and then converting it     */
            string stringNum = "2";
            int intNum = Convert.ToInt32(stringNum);
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());


            /*            C# Dictionary                  */
            /*  -Declare the Dictionary type and give it the key:value pair by declaring <string, int>
                -create the variable myScoreboard and declare it as a "new Dictionary" with the key:value pair
                -stored as a function    */
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            
            /* Use the .Add() method to add key:value pairs to the myScoreboard variable */
            myScoreBoard.Add("firstInning", 10);
            myScoreBoard.Add("secondInning", 20);
            myScoreBoard.Add("thirdInning", 30);
            myScoreBoard.Add("fourthInning", 40);
            myScoreBoard.Add("fifthInning", 50);

            /*  Console log all the keys from the myScoreBoard variable  
                Will return all the stored values  */
            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);


            /*            C# ARRAYS          */
            /* Declare the array
                You do not have to declare the object with stored values */
            string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };

            /* You can alter the stored values just like javascript */
            favFoods[0] = "coffee";

            /* Give each index a unique variable */
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];

            /* console log the indexes you will be using I.E. ("I like {0}, {1}, and {2}")
                pass the arguements of the variables with the stored values I.E. (firstFood, secondFood, thirdFood) */
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);


            /*        C# LIST'S          */
            /* Declare the variable of employees as a list 
                declare a new list with a value of <string> */
            List<string> employees = new List<string>() { "adam", "amy" };
            employees.Add("barbara");
            employees.Add("billy");
            Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);


            /*          C# FOR LOOPS            */
            for (int i = 0; i < employees.Count; i++) {
            Console.WriteLine(employees[i]);
            }

            /* C# Input and null coalescing operator "??" */
            /* The "??" operator will check for a null value and replace it with an empty string */
            string input = Console.ReadLine() ?? "";

            // As long as a cs file falls under the same namespace and public is declared, it can be reached through all other files
            /* When declaring a list and passing it a class
                your list declaration needs to include the class */
           /*  List<Employee> employees = new List<Employee>(); */


           /*    USING AND STREAMWRITER          */
            /* This will use the streamwriter as much as you want */
            StreamWriter file = new StreamWriter("data/employees.csv");

            /* This will only use whatever code you put in the curly braces for the streamwriter, after that it stops writing the data
             The keyword using has two distinct meanings that depend on the context (importing a namespace versus temporarily using a resource).  */
             
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
            // Any code that needs the StreamWriter would go in here
            }


        }
    }