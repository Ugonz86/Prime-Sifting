using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
    class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Prime Number Sifting!");
            Console.WriteLine("Let's return all of the prime numbers less than that number your entered!");
            int userInput = validInput(); //Only numbers
            List<int> primeNumbers = Sifting.GetPrimeNumbers(userInput);
            Console.ForegroundColor = ConsoleColor.Green;
            string result = string.Join(",", primeNumbers);
            Console.WriteLine($"Following are the prime numbers: {result}");
            Console.ResetColor();
        }
        public static int validInput()
        {
            int number = 0;
            Console.WriteLine("Enter a positive number bigger than 1:");

            bool numberInput = Int32.TryParse(Console.ReadLine(), out number);
            if(!numberInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOnly numbers are valid entries!");
                return validInput();
            }
            if (number <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOnly numbers bigger than 1!");
                return validInput();
            }
            return number;
        }
    }
}
