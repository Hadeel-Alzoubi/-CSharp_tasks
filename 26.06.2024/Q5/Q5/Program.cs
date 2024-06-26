using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilo = Convert.ToInt32(Console.ReadLine());
            double mil = Convert.ToDouble(kilo);
            mil = kilo * 0.621371;

            Console.WriteLine(mil);

            Console.ReadKey();
        }
    }
}
