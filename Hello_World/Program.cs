using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt 2020!");

            var lunchLoader = new LunchLoader();
            Console.WriteLine("Press v for Vegi, and key for Meat");
            Console.WriteLine();
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.V)
            {

                lunchLoader.PrintVegi();
            }
            else
            {
                lunchLoader.PrintMeat();
            }
            Console.Read();

            


        }
    }
}
