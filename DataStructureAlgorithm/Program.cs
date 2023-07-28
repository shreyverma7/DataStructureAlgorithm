using DataStructureAlgorithm;
using DataStructureAlgorithm.UnOrderedList;

public class Program
{
    static string searchFilePath = @"D:\Bridgelabz Problem statement\DataStructureAlgorithm\DataStructureAlgorithm\Files\Search.txt";
    static string unOrderedFilePath = @"D:\Bridgelabz Problem statement\DataStructureAlgorithm\DataStructureAlgorithm\UnOrderedList\UnOrdered.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Data Structure\n");
        bool flag = true;
        while (flag)
        {
            RangePrimeNumber rangePrimeNumber = new RangePrimeNumber();
            Console.WriteLine("\n\nEnter a option \n1.BinarySearch \n2.Check Anagram\n3.Replace String\n4.Insertion Sort \n5.Bubble Sort \n6.Range Prime Number \n7.Prime in Range \n8.Prime with palindrome\n9.UnOrdered Add or Delete\n10.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadTextFileAndSearch(searchFilePath);
                    break;
                case 2:
                    CheckAnagram anagram = new CheckAnagram();
                    anagram.checkAnagram();
                    break;
                case 3:
                    ReplaceString replace = new ReplaceString();
                    replace.replaceString();
                    break;
                case 4:
                    int[] arr = { 33,22,11,6,40,55 };
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.InsertionSortAlgorithm(arr);
                    Console.WriteLine("\nSorted array:");
                    insertionSort.PrintArray(arr);
                    break;
                case 5:
                    int[] arr1 = { 5,2,1,4,3 };
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.BubbleSortAlgorithm(arr1);
                    Console.WriteLine("\nSorted array:");
                    bubbleSort.PrintArray(arr1);
                    break;
                case 6:
                    Console.WriteLine("Enter the range :");
                    int range = Convert.ToInt32(Console.ReadLine());
                    for(int i =0; i < range; i++)
                    {
                       rangePrimeNumber.checkNumberIsPrime(i); 
                    }
                    Console.WriteLine("\n");
                    break;
                case 7:
                    Console.WriteLine("Enter the range :");
                    int range1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < range1; i++)
                    {
                        rangePrimeNumber.checkNumberIsPrime(i);
                    }
                    Console.WriteLine("\n");
                    break;
                case 8:
                    PrimeAnagramPalidrome extend = new PrimeAnagramPalidrome();
                    Console.WriteLine("Enter the range :");
                    int range2 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < range2; i++)
                    {
                        if(extend.checkNumberIsPrime(i) && extend.IsPalindrome(i))
                        {
                            Console.Write(i+" ");
                        }
                    }
                    Console.WriteLine("\n");
                    break;
                case 9:
                    Opertion unorderListProblem = new Opertion();
                    unorderListProblem.ReadFileAndPerformOperation(unOrderedFilePath);
                    break;
                case 10:
                    flag = false;
                    break;
            }
        }


    }
}