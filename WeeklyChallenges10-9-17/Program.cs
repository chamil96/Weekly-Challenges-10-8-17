//1. Write a method that divides two numbers(provided as parameters).
//Tip: you will need to use the modifiers public and static. 
//Do not hardcode the two numbers.
using System;

namespace Challenge1
{
    class Program
    {
        public int FindQuotient(int num1, int num2)
        {

            int result = num1 / num2;


            return result;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number.");
                int userInput1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter another number.");
                int userInput2 = Convert.ToInt32(Console.ReadLine());

                int quotient;

                Program a = new Program();


                quotient = a.FindQuotient(userInput1, userInput2);
                Console.WriteLine("Your answer is");
                Console.WriteLine(quotient);
                break;
            }

        }
    }
}