using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //Correct the syntax error:

            //string[] ARR = [1, 7  9  45,]
            int[] ARR = { 1, 7, 9, 45 };
            //int arr2 = ["Str" "alex","moh"
            string[] arr2 = { "Str", "alex", "moh" };
            //string arr3= 'the','fox' 'over' lazy, 'dog',  ]
            string[] arr3 = { "the", "fox", "over ", "lazy", "dog" };


            //Q2

            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            int Banan = 0;
            int Tomato = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                {
                    Banan = i;
                }
                if (fruits[i] == "Tomato")
                {
                    Tomato = i;
                }
            }

            Console.WriteLine("The Index Of Banana : " + Banan);
            Console.WriteLine("The Index Of Tomato : " + Tomato);

            //Q3

            Console.WriteLine("---------------------------------");

            string[] food = { "Tomato", "Botato", "Mansaf", "Zaater", "Labana" };
            string[] sport = { "Jumping Rop", "Run", "Walk" };
            string[] movie = { "Avatar", "on Side Out 1 ", "On Side Out 2", "Enola" };

            foreach (var item in food)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            foreach (var item in sport)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            foreach (var item in movie)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("---------------------------------");

            //Q4
            Console.Write("Enter 3 Number Separated By , ");
            string num = Console.ReadLine();

            string[] numbers = num.Split(',');
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine("The sum of three numbers: " + sum);

            //Q5
            Console.WriteLine("---------------------------------");
            int sum1 = 0;

            for(int i = 0;i < 100;i++)
            {
                if(i %2 != 0)
                {
                    sum1 += i;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum1);

            //Q6
            Console.WriteLine("---------------------------------");

            int number = 5;

            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            //Q7
            Console.WriteLine("---------------------------------");
  
            int numc = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(numc + " ");
                    numc++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
