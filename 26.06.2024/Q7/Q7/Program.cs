using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = Convert.ToInt32(Console.ReadLine());
            int min;
            int min2;
            min2 = minutes / 60;

            min = minutes % 60;
            Console.WriteLine(min2 + " Hours " + min + " Minutes "); 


            Console.ReadKey();
        }
    }
}
