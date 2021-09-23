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

            Console.WriteLine("Please enter your age in numbers");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 0)
            {
                Console.WriteLine("how are you even doing this if your age is negative?");
            }

            else if (age > 0 && age <= 5)
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

            Console.WriteLine();

            //Hurricane


            Console.WriteLine("enter a category number of hurricanes to find out its wind speeds");
            int category = Convert.ToInt32(Console.ReadLine());


            switch (category)
            {
                case 1:
                    Console.WriteLine("category 1 hurricanes have speeds between 78-95 M/H or 119-153KM/H");
                    break;

                case 2:
                    Console.WriteLine("category 2 hurricanes have speeds between 96-110 M/H or 154-177 KM/H");
                    break;

                case 3:
                    Console.WriteLine("category 3 hurricanes have speeds between 111-130 M/H or 178-209 KM/H");
                    break;

                case 4:
                    Console.WriteLine("category 4 hurricanes have speeds between 131-155 M/H or 114 - 135");
                    break;

                case 5:
                    Console.WriteLine("category 5 hurricanes have speeds above 155 M/H or 249 KM/H");
                    break;

                default:
                    Console.WriteLine("hurricanes are classified 1-5 not what you put.");
                    break;

            }

            Console.WriteLine();

            //random divisble

            Random generator = new Random();

            int randomInt = generator.Next(2, 6);

            Console.WriteLine($"enter a higher number than {randomInt}");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int total = (userInput % randomInt);

            if (randomInt > userInput)
            {
                Console.WriteLine($"i said higher than {randomInt} not lower");
            }

            else if (userInput <= 0)
            {
                Console.WriteLine("not a number");
            }

            else if (total == 0)
            {
                Console.WriteLine("thats divisible");
            }

            else if (total > 0)
            {
                Console.WriteLine("not divisible");
            }

            Console.WriteLine("press anything to close this program");
            Console.ReadLine();
        }
    }
}
