using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            Console.WriteLine(bmw.Display());
            Car car = new Car();
            Console.WriteLine(car.Display());
            Car bmwcar = new BMW();
            Console.WriteLine(bmwcar.Display());
            Console.ReadKey();
        }
    }

   public class Car
    {
        int make;
        int year;
        string type;
        float price;
        int model;
        int palletNo;
        string color;

        public void DisplayInfo(int make,int year)
        {

        }
        public void DisplayInfo(int make)
        {

        }
        public virtual string Display()
        {
            return "Welcome Car";
        }
        //public  string Display()
        //{
        //    return "Welcome Car";
        //}

    }

    public class BMW :Car
    {
        public override string Display()
        {
            return "welcome BMW";
        }
        //public string Display()
        //{
        //    return "welcome BMW";
        //}
    }
}
