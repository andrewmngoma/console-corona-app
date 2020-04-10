using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_for_Corna
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Surname;
            string IdNum;
            double Temp;
            bool fahrenheit;

            Console.WriteLine("What is your Name:");
            Name = Console.ReadLine();

            Console.WriteLine("What is your Surname:");
            Surname = Console.ReadLine();

            Console.WriteLine("What is your RSA ID number:");
            IdNum = Console.ReadLine();

            Console.WriteLine("Enter temperature of " + Name + " " + Surname);
            Temp = Convert.ToDouble(Console.ReadLine());

            if (Temp > 38)
            {
                Console.WriteLine($"{Name + " " + Surname} you have COVID-19!");
            }
            else
            {
                Console.WriteLine(Name + " " + Surname + " you are well my friend!");
            }

            Console.WriteLine($"{Name + " " + Surname}, would you like to convert your temperature in degrees fehrenheit?");
            fahrenheit = false;
            if (fahrenheit == true)
            {

            }
            else
            {

            }
        }
    }
}
