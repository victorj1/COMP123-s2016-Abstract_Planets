using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Victor Jdanovitch
 * Date Created: June 17th, 2016
 * Date Last Updated: July 9th, 2016
 * Student#: 300869472
 * Description: Abstract Planets: Building and implementing classes and interfaces (Assignment 3)
 * Version: 0.02 - Final with all documentation
 */

namespace COMP123_s2016_Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PLANETS");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------");
            Planet giantPlanet = new GiantPlanet("Sporta Y", 3000000000, 5000000000, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Planet terrestrialPlanet = new TerresstrialPlanet("Scurn T", 995000, 120000000, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            waitForAnyKey();



            Console.BackgroundColor = ConsoleColor.Black;

        }

        public static void waitForAnyKey()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
