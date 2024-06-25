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
            int num;

            Console.WriteLine("Enter Length Of Array  :  ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];
            int[] number = new int[count];
            for (int i = 0; i < count; i++) {
               num = Convert.ToInt32(Console.ReadLine());
                number[i] =num;
               numbers[i] = number[i];
            }

            Console.WriteLine("Array : ");
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" - " , numbers));


            Console.ReadKey();
        }
    }
}
