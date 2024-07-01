<<<<<<< HEAD
﻿using System;
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
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sumandavg(arr);

            Console.WriteLine("----------------------------------------------------------");

            //Q2
            Console.WriteLine("Enter Number To Find The Cube: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"The cube Of {i} IS : {i * i * i}");
            }

            Console.WriteLine("----------------------------------------------------------");

            //Q3
            int[] array = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            getYears(array);
            Console.WriteLine("----------------------------------------------------------");

            //Q4
            Console.WriteLine("Enter Your Age :");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Age In Days Is : {age(myage)}");

            Console.WriteLine("----------------------------------------------------------");

            //Q5
            Console.WriteLine("The Defult Value Is : ");
            person hadeel1 = new person();
            hadeel1.displayInformation();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Your Personal Info :  ");

            person hadeel = new person(1254, "hadeel", 27, "f", "hadeel@gmail.com", "0788888888");
            hadeel.displayInformation();
            

            Console.ReadKey();
        }

        //Q1
        public static void sumandavg(double[] x)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            avg = sum / x.Length;
            Console.WriteLine($"The Sum Of Number Is : {sum}");
            Console.WriteLine($"The AvG Of Number Is : {avg}");
        }

        //Q3
        public static void getYears(int[] year)
        {
            int[] array1 = new int[year.Length];
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    Console.WriteLine(year[i]);
                }
            }
        }

        //Q4
        public static int age(int age)
        {
            int year = age * 365;
            return year;
        }
    }
    public class person
    {
        int Id;
        string Name;
        int Age;
        string Gender;
        string Email;
        string Phone;

        public person()
        {
            this.Id = 1;
            this.Name = "hadeel alzoubi";
            this.Age = 27;
            this.Gender = "f";
            this.Email = "hadeelzoubi@gmail.com";
            this.Phone = "079222222";
        }
        public person(int id, string name, int age, string gender, string email, string phone)
        {
            Id = id;
            Name = name;
            if (age > 18 && age < 60)
            { 
                Age = age;
            }
            else
            {
                Console.WriteLine("You Are Out Of Range . ");
            }        
            Gender = gender;
            Email = email;
            if (phone.Substring(0, 3) == "079" || phone.Substring(0, 3) == "078" || phone.Substring(0, 3) == "077")
              { Phone = phone; }
            else
            {
                Console.WriteLine("Phone Number UnCorrect !!");
            }
        }
        public void displayInformation()
        {
            Console.WriteLine($"Your id is {Id} and Your name is {Name} \n and Your age is {Age} and gender is {Gender} \n and the email is {Email} and the phone is {Phone}");
        }

    }
}

//public class Person
//{
//    int age;
//    char gender;
//    string name;
//    string email;
//    int id;
//    string phone; // such number in index

//    public void setname(string name)
//    {
//        this.name = name;
//        Console.WriteLine(name);
//    }
//    public string getname()
//    {
//        return name;
//    }

//    public void setgender(char gender)
//    {
//        this.gender = gender;
//        Console.WriteLine(gender);
//    }
//    public char getgender()
//    {
//        return gender;
//    }

//    public void setid(int id)
//    {
//        this.id = id;
//        Console.WriteLine(id);
//    }
//    public int getId()
//    {
//        return id;
//    }
//    public void setemail(string email)
//    {
//        this.email = email;
//        Console.WriteLine(email);
//    }

//    public string getemail()
//    {
//        return email;
//    }
//    public void setAge(int age)
//    {
//        if (age >= 18 || age <= 60)
//        {
//            Console.WriteLine(age);
//        }
//        else
//        {
//            Console.WriteLine("Your Are Out Of Range . ");
//        }
//    }

//    public int getAge()
//    {
//        return age;
//    }
//    public void setphone(string phone)
//    {
//        this.phone = phone;
//        Console.WriteLine(phone);
//        //if (phone[0] == 0 && phone[1] == 7)
//        //{
//        //    if (phone[2] == 7 || phone[2] == 8 || phone[2] == 9)
//        //    {
//        //        this.phone = phone;
//        //    }
//        //}
//    }

//    public string getphone()
//    {
//        return phone;
//    }

//}

=======
﻿using System;
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
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sumandavg(arr);

            Console.WriteLine("----------------------------------------------------------");

            //Q2
            Console.WriteLine("Enter Number To Find The Cube: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"The cube Of {i} IS : {i * i * i}");
            }

            Console.WriteLine("----------------------------------------------------------");

            //Q3
            int[] array = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            Console.WriteLine(getYears(array));

            Console.WriteLine("----------------------------------------------------------");

            //Q4
            Console.WriteLine("Enter Your Age :");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Age In Days Is : {age(myage)}");

            Console.WriteLine("----------------------------------------------------------");

            //Q5
            Console.WriteLine("Your Personal Info :  ");
            //string len = Console.ReadLine();
            //string[] arr0 = new string[len.Length];
            //for (int i = 0; i < arr0.Length; i++)
            //{
            //    arr0[i] = Convert.ToInt32(Console.Read());
            //}
            Person hadeel = new Person();

            hadeel.setname("hadeel");
            hadeel.getname();
            hadeel.setphone("07888888");
            hadeel.getphone();
            hadeel.setemail("hadeel@gmail");
            hadeel.getemail();
            hadeel.setAge(27);
            hadeel.getAge();
            hadeel.setgender('F');
            hadeel.getgender();
            hadeel.setid(1111111);
            hadeel.getId();

            Console.ReadKey();
        }

        //Q1
        public static void sumandavg(double[] x)
        {
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            avg = sum / x.Length;
            Console.WriteLine($"The Sum Of Number Is : {sum}");
            Console.WriteLine($"The AvG Of Number Is : {avg}");
            //return sum;
        }

        //Q3
        public static int getYears(int[] year)
        {
            int[] array1 = new int[year.Length];
            for (int i = 0; i < year.Length; i++)
            {
                if (year[i] > 1950)
                {
                    //array1[i] = year[i] ;
                    Console.WriteLine(year[i]);
                }
            }
            return 0;
        }

        //Q4
        public static int age(int age)
        {
            int year = age * 365;
            return year;
        }
    }
    public class Person
    {
        int age;
        char gender;
        string name;
        string email;
        int id;
       string phone; // such number in index

        public void setname(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public string getname()
        {
            return name;
        }

        public void setgender(char gender)
        {
            this.gender = gender;
            Console.WriteLine(gender);
        }
        public char getgender()
        {
            return gender;
        }

        public void setid(int id)
        {
            this.id = id;
            Console.WriteLine(id);
        }
        public int getId()
        {
            return id;
        }
        public void setemail(string email)
        {
            this.email = email;
            Console.WriteLine(email);
        }

        public string getemail()
        {
            return email; 
        }
        public void setAge(int age)
        {
            if (age >= 18 || age <= 60)
            {
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("Your Are Out Of Range . ");
            }
        }

        public int getAge()
        {
            return age;
        }
        public void setphone(string phone)
        {
            this.phone = phone;
            Console.WriteLine(phone);
            //if (phone[0] == 0 && phone[1] == 7)
            //{
            //    if (phone[2] == 7 || phone[2] == 8 || phone[2] == 9)
            //    {
            //        this.phone = phone;
            //    }
            //}
        }

        public string getphone()
        {
            return phone;
        }

    }

}
>>>>>>> 04a881904deaeeb9dbcc4f4b5c066779c83a0776
