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
           
         
            Console.WriteLine("Press v for Vegi, and key for Meat");
            Console.WriteLine();
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.V)
            {

               PrintVegi();
            }
            else
            {
                PrintMeat();
            }
            Console.Read();

            


        }
    }
}
