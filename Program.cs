using System;

namespace CatWorx.BadgeMaker {
    class Program {
        static void Main(string[] args) {
            

     
        }
    }
    
    class Notes {
        public Notes() {

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

            /* Doube is 64 bit floating data type
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
            Console.WriteLine("12" + "3");    // What happens here?

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
        }
    }
}
