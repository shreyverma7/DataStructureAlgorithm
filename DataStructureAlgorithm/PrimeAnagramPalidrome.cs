using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class PrimeAnagramPalidrome
    {
        public void CheckPrimeAnagramPalindrome()
        {
            Console.WriteLine("Prime numbers in the range 0 - 1000:");
            for (int num = 0; num <= 1000; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine("\nPrime numbers that are also anagrams:");
            for (int num1 = 0; num1 <= 1000; num1++)
            {
                if (IsPrime(num1))
                {
                    for (int num2 = num1 + 1; num2 <= 1000; num2++)
                    {
                        if (IsPrime(num2) && AreAnagrams(num1, num2))
                        {
                            Console.Write(num1 + " ");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\nPrime numbers that are also palindromes:");
            for (int num = 0; num <= 1000; num++)
            {
                if (IsPrime(num) && IsPalindrome(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public bool AreAnagrams(int num1, int num2)
        {
            char[] num1Array = num1.ToString().ToCharArray();
            char[] num2Array = num2.ToString().ToCharArray();
            Array.Sort(num1Array);
            Array.Sort(num2Array);
            return new string(num1Array) == new string(num2Array);
        }
        static bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            int left = 0;
            int right = numStr.Length - 1;
            while (left < right)
            {
                if (numStr[left] != numStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
