using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            int[] number ={100,-10000,400};
            
            Array.Sort(number);
            Console.WriteLine(string.Join("  ",number.Reverse()));

            Console.ReadKey();


        }
    }
}
