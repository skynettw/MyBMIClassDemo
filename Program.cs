using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBMIClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass(10, 15);

            m.display();
            Random rand = new Random();
            BMI bmi = new BMI(Convert.ToDouble(rand.Next(60, 120)), Convert.ToDouble(rand.Next(150, 190)));
            Console.WriteLine(bmi.compute());
            string name = "Richard";
            Console.WriteLine("Hello, {0}, {1}", name, "You");
            Random random = new Random();
            int answer = random.Next(1, 100);
            int guess = 0;
            Console.WriteLine(answer);
            do
            {
                Console.Write("Please guess a number:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == answer)
                {
                    Console.WriteLine("You are right!");
                    break;
                }
                else
                {
                    if (guess > answer)
                    {
                        Console.WriteLine("Too large, try again");
                    }
                    else
                    {
                        Console.WriteLine("Too small, try again");
                    }
                }
            } while (true);
            Console.WriteLine("Thank you");
        }
    }
}
