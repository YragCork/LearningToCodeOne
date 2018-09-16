using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstIntroductionToCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a var of type int set to 50.
            //Use n'th Partial Sum Eq. and store result in var res of type int.
            //Print res to the screen.

            //Number is the value entered
            //int.parse is just dealing with error handling if the user entered alpha
            //Console.ReadLine is resding in the entered value and storing it in the container called number

            Console.Write("Pick a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.Write("The sum of all the numbers between 1 and "
                + number
                + " = "
                + AddNumbers(number));
            }
            catch (FormatException format)
            {
                Console.WriteLine("You must enter an int stupd!");
            }

            int num1 = 5;
            int num2 = 10;

            if (num1 > num2 || num1 != 5)
            {

            }
            else if (num1 == num2)
            {
                //Di this instead
            }
            else
            {
                //Swfault here
            }

            var t = 
                "string";

             

            

            Console.Read();

        }

        static int AddNumbers(int n)
        {
            int result = ((n + 1) * n) / 2;
            return result;
        }
    }
}
