using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class PrimeAnagramPalidrome
    {
        public  bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            // Reversing the number
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            return originalNumber == reversedNumber;
        }
        public bool checkNumberIsPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                return true;
            else
                return false;

        }
    }
}
