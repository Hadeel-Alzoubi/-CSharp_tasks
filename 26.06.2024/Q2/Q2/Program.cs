using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            if (number < 0)
            {
                Console.WriteLine("-");
            }

            Console.ReadKey();
        }
    }
}
