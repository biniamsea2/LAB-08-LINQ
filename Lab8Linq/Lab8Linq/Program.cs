using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Lab8Linq
{
    class Program
    {
        public static void Main(string[] args)
            {
            bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = UserInterface();
                }
            }
        public static bool UserInterface()
        {
            Console.Clear();
            Console.WriteLine(" Lab 8: LINQ\n");
            Console.WriteLine(" By clicking '1' you will see all the lists that answer all the questions for lab 8. " +
                "Each list is seperated by a message indicating the new list \n");
            Console.WriteLine(" 1) Show all lists");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                readAndConvertJsonfile();
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }

            //info to change line color from http://www.dotnetperls.com/console-color
            static void readAndConvertJsonfile()
            {

                string readAll = File.ReadAllText("../../../../../JSON/data.json");
                Example nh = JsonConvert.DeserializeObject<Example>(readAll);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Show all neighborhoods from list");
                Console.WriteLine("\n");
                Console.ResetColor();
                int counter = 0;
                var test2 = from nh2 in nh.Features
                            select nh2.Properties.Neighborhood;

                foreach(var hood in test2)
                {
                    Console.WriteLine(hood);
                    counter++;
                    Console.WriteLine($"Number of neighborhoods at this point: {counter} neighborhoods\n");

                }
                
                int counter2 = 0;
                var test3 = from nh3 in test2
                            where nh3.Length != 0
                            select nh3;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("This next list will show all the neighborhoods minus the ones that don't have any names");

                Console.ResetColor();
                foreach (var hood in test3)
                {
                    Console.WriteLine("\n\n" + hood);
                    counter2 ++;
                    Console.WriteLine($"Number of neighborhoods that don't have a name: {counter2}");
                }
                Console.WriteLine("\n");
                //looping through test3 which has all the neighborhoods that have a name, then removing duplicates.
                int counter3 = 0;
                var test4 = test3.Distinct();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("This next list will remove all duplicates from the list.");
                Console.ResetColor();
                foreach (var hood in test4)
                {
                    Console.WriteLine("\n\n" + hood);
                    counter3++;
                    Console.WriteLine($"Number of neighborhoods once duplicates are removed: {counter3}");
                }

                //returns all the neighborhoods where their length is greater than 0, no duplicates, and have names written in one single query.
                int counter4 = 0;
                var test5 = nh.Features.Where(x => x.Properties.Neighborhood.Length != 0)
                    .GroupBy(y => y.Properties.Neighborhood)
                    .Select(z => z.First());
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nThis list shows all the neighborhoods with all the previous queries used in one line.");
                Console.ResetColor();
                Console.WriteLine("\n");
                foreach (var hood in test5)
                {
                    Console.WriteLine(hood.Properties.Neighborhood);
                    counter4++;
                    Console.WriteLine($"Neighborhood count: {counter4}\n");
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nThis list is the first question using an opposing method.");
                Console.ResetColor();
                int counter5 = 0;
                var lastTest = nh.Features.Select(t => t.Properties.Neighborhood);
                foreach (var hood in lastTest)
                {
                    Console.WriteLine("\n" + hood);
                    counter5++;
                Console.WriteLine($"Number of neighborhoods: {counter5}");
                }
            }
        }
    }
}
