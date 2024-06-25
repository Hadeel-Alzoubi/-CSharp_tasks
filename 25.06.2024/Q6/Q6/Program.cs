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
            Console.WriteLine("Enter the Number of Index in Array : ");

            int num = Convert.ToInt32(Console.ReadLine());
            //int element;
            int sum = 0;
            int[] arr = new int[num];

            for (int i = 0; i < num; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("The Sum Of the Element Is :  ");
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
