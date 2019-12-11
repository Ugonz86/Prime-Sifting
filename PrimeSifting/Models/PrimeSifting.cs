using System.Collections.Generic;

namespace PrimeSifting.Models
{
    public class Sifting
    {
        public static List<int> GetPrimeNumbers(int number)
        {
            List<int> primeNumbers = new List<int>();
            bool primeValidation = true;
            for(int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        primeValidation = false;
                        break;
                    }
                }
                if (primeValidation)
                {
                    primeNumbers.Add(i);
                }
                primeValidation = true;
            }
            return primeNumbers;
        }
    }
}