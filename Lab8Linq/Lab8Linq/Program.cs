using System;
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
                Console.WriteLine(" Please select an option below \n");
                Console.WriteLine(" 1) Output all the neighborhoods in this data list");
                Console.WriteLine(" 2) Filters out all the neighborhoods that dont have any names");
                Console.WriteLine(" 3) Removes all duplicate neighborhoods");
                Console.WriteLine(" 4) Rewrote above queries into one single query");
                Console.WriteLine(" 5) Rewrote #2 using LINQ Query statement.");
                Console.WriteLine(" 6) EXIT ");
            string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    return true;
                }
            else if (userInput == "2")
            {
                return true;
            }
            else if (userInput == "3")
            {
                return true;
            }
            else if (userInput == "4")
            {
                return true;
            }
            else if (userInput == "5")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
