using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] cars = {"opel","Toyota","Mercedess","Nissan","Volvo","Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[5]);

            Console.WriteLine("The Length Of array is : ");
            Console.WriteLine(cars.Length);

            Console.ReadKey();
        }
    }
}
