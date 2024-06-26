using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());

            hours = hours * 60;
            sum = hours + minutes;

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
