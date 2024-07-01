using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("car", 2012, 11.000, "10", "Pal", "red");
            car.FullInfo();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            BMW bmw = new BMW("BMW", 2020, 11.880, "30", "Pal", "white");
            //bmw.FullInfo();

            Console.ReadKey();

        }
    }

    //1.Implement a Car class which has fields to store the car's make, year, Type, Price, model, Pallet No, and color

    class Car
    {
        private string make;
        private int year;
        private double price;
        private string model;
        private string pallet;
        private string color;

        //Use Properties
        public string Make
        { get; set; }
        public int Year
        { get; set; }
        public double Price
        { get; set; }
        public string Model
        { get; set; }
        public string Pallet
        { get; set; }
        public string Color
        { get; set; }

        //2.Implement a constructor for the car class which takes parameters corresponding to each of the fields

        public Car(string Make, int Year, double Price, string Model, string Pallet, string Color)
        {
            make = Make;
            year = Year;
            price = Price;
            model = Model;
            pallet = Pallet;
            color = Color;
        }

        //3.Implement a method to start and stop engine.
        public void StartEngine()
        {
            Console.WriteLine("Engine started for the " + make + " " + model);
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine Stoped for the " + make + " " + model);
        }
        //4.Try to return a string containing full information about the car
        public void FullInfo()
        {
            Console.WriteLine($"Make : {make} ");
            Console.WriteLine($"Year : {year} ");
            Console.WriteLine($"Price : {price} ");
            Console.WriteLine($"Model : {model} ");
            Console.WriteLine($"Pallet : {pallet} ");
            Console.WriteLine($"Color : {color} ");
        }

    }

    //5.Apply inheritance for the base class (create class BMW (Derived Class))
    class BMW : Car
    {

        public BMW(string Make, int Year, double Price, string Model, string Pallet, string Color)
            : base(Make, Year, Price, Model, Pallet, Color)
        {

            FullInfo();

        }



    }

}
