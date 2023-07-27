using DataStructureAlgorithm;

public class Program
{
    static string searchFilePath = @"D:\Bridgelabz Problem statement\DataStructureAlgorithm\DataStructureAlgorithm\Files\Search.txt";
    public static void Main(string[] args)
    {
        Console.WriteLine("Data Structure\n");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter a option \n1.BinarySearch \n2.Check Anagram\n3.Replace String\n4.Exit");
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
                    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.InsertionSortAlgorithm(arr);
                    Console.WriteLine("\nSorted array:");
                    insertionSort.PrintArray(arr);
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    flag = false;
                    break;
            }
        }


    }
}