using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -5, -2, 6, 0, -1 };

            Array.Sort(array);
           
            Console.WriteLine( array.Max());

            Console.ReadKey();
        }
    }
}
