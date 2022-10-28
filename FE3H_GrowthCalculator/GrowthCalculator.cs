using FE3H_GrowthCalculator;
using System;
using System.Threading;

namespace FE3HGrowthCalculator
{
    public class GrowthCalculator
    {
        public static Growths theGrowth = new Growths();

        public static void ThreadProc()
        {
            theGrowth.setCharacterList(JsonReader.readCharacters("Character.json"));
        }

        private static void singleClass()
        {
            theGrowth.isValid = false;
            while (!theGrowth.isValid)
            {
                Console.WriteLine($"Please Enter The Name Of The Class You Will To Check");
                string? userClass = Console.ReadLine();
                theGrowth.isCharValid(userClass);
            }
            Console.WriteLine($"The Growths Of {theGrowth.userChar.Name} In Class {theGrowth.userClass.Name}\n" +
                $"");
        }

        private static void allClasses()
        {
        }

        public static void Main(string[] args)
        {
            Thread t2 = new Thread(new ThreadStart(ThreadProc));

            t2.Start();
            JsonReader.readClasses("Class.json");
            t2.Join();
            while (!theGrowth.isValid)
            {
                Console.WriteLine($"Please Enter The Name Of The Character You Will To Check");
                string? userChar = Console.ReadLine();
                theGrowth.isCharValid(userChar);
            }
            Console.WriteLine($"Single Class or All?");
            string? menuSelection = Console.ReadLine();
            switch (menuSelection?.ToLower())
            {
                case "single":
                    singleClass();
                    break;

                case "all":
                    allClasses();
                    break;

                default:
                    Console.WriteLine("Error: Invalid Selection\nTry Entering All or Single!");
                    break;
            }
        }
    }
}