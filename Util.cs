using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using SkiaSharp;
using System.Threading.Tasks;
namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method declared as "static"
        // Function to print employee names 
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        // Function to save employee data to a .csv file
        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if folder exists
            if (!Directory.Exists("data"))
            {
                // If no, create it
                Directory.CreateDirectory("data");
            }
            // using Streamwriter will clear the memory after funcion has executed
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                // Immediatley write this to the top of the .csv file
                file.WriteLine("ID,Name,PhotoUrl");
                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    // create the template in which the items will be written to the file
                    string template = "{0},{1},{2}";
                    // Write the items to the file using the template
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                }
            }
        }

        // Function to make employee badge
        async public static Task MakeBadges(List<Employee> employees)
        {
            // instance of HttpClient is disposed after code in the block has run
            using (HttpClient client = new HttpClient())
            {
                int BADGE_WIDTH = 669;
                int BADGE_HEIGHT = 1044;
                int PHOTO_LEFT_X = 184;
                int PHOTO_TOP_Y = 215;
                int PHOTO_RIGHT_X = 486;
                int PHOTO_BOTTOM_Y = 517;
                int COMPANY_NAME_Y = 150;
                for (int i = 0; i < employees.Count; i++)
                {
                    // Get the employee photo 
                    SKImage photo = SKImage.FromEncodedData(await client.GetStreamAsync(employees[i].GetPhotoUrl()));

                    // Get the bacground image of the badge 
                    SKImage background = SKImage.FromEncodedData(File.OpenRead("badge.png"));

                    // Create bitmap to determine the size of the badge 
                    SKBitmap badge = new SKBitmap(BADGE_WIDTH, BADGE_HEIGHT);

                    // Turn the badge into a canvas 
                    SKCanvas canvas = new SKCanvas(badge);

                    // Add the background and employee photo to the badge 
                    canvas.DrawImage(background, new SKRect(0, 0, BADGE_WIDTH, BADGE_HEIGHT));
                    canvas.DrawImage(photo, new SKRect(PHOTO_LEFT_X, PHOTO_TOP_Y, PHOTO_RIGHT_X, PHOTO_BOTTOM_Y));

                    // SKPAINT object to layout the what our company name will look like
                    SKPaint paint = new SKPaint();
                    paint.TextSize = 42.0f;
                    paint.IsAntialias = true;
                    paint.Color = SKColors.White;
                    paint.IsStroke = false;
                    paint.TextAlign = SKTextAlign.Center;
                    paint.Typeface = SKTypeface.FromFamilyName("Arial");

                    // Print the company name to the canvas
                    canvas.DrawText(employees[i].GetCompanyName(), BADGE_WIDTH / 2f, COMPANY_NAME_Y, paint);

                    // Save the image to the data folder
                    SKImage finalImage = SKImage.FromBitmap(badge);
                    SKData data = finalImage.Encode();
                    data.SaveTo(File.OpenWrite("data/employeeBadge.png"));
                }
            }
        }
    }
}