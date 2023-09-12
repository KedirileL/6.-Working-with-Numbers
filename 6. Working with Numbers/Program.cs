using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(50);

            //You can also use the normal operators straight into the brackets
            //You can write the numbers inquotes to see them on console without calculation
            Console.WriteLine(10 + 6);
            Console.WriteLine(10 * 6);
            Console.WriteLine(10 - 6);

            //Remember the Console see the numbers as integers, so do a 2.0 to get the double
            Console.WriteLine(5 / 2.0);

            Console.WriteLine(5%2);
            Console.WriteLine("\n5 divided by 2 is " + " " + 5 / 2 + " reminder " + 5 % 2);

            int num1 = 2; //initializing num1 to 2
            num1 = num1 + 1; //adding +1 to the num1 which was two now 3
            num1 += 1; // incrementing from the previous num1 = 3 , now it will be 3

            Console.WriteLine("\n\nNum 1 = " + num1);

            int num2 = 2;
            num2++;

            Console.WriteLine("Num 2 = " + num2);

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Min(5,40)); // determines the minimum between the two
            Console.WriteLine(Math.Max(5, 40)); //Determines the maximum
            Console.WriteLine(Math.Pow(2,2));
            //Freeze the console
            Console.ReadLine();
        }
    }
}
