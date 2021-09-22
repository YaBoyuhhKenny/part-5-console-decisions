using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5_console_decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //stages
            
            int age;
            string result;

            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 0 && age <= 5)
            {
                result = "toddler";
                Console.WriteLine($"you are a " + result);
            }

            else if (age > 5 && age <= 10)
            {
                result = "child";
                Console.WriteLine($"you are a " + result);
            }

            else if (age > 10 && age <= 12)
            {
                result = "preteen";
                Console.WriteLine($"you are a " + result);
            }

            else if (age > 12 && age <= 18)
            {
                result = "teen";
                Console.WriteLine($"you are a " + result);
            }


            else if (age > 18)
            {
                result = "adult";
                Console.WriteLine($"you are a " + result);
            }

            Console.ReadLine();
        }
    }
}
