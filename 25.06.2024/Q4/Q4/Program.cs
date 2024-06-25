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
            Console.WriteLine("Enter Your First Name  :  ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name  :  ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Your BirthDay  :  ");
            int birthday = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(fName + " " + lName + " " + birthday);

            Console.ReadKey();
        }
    }
}
