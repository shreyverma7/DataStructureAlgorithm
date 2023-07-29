using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class MergeSort
    {
        public  void mergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;

            // Create two arrays to hold the left and right halves
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            // Copy data to the left and right arrays
            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid, j = 0; i < arr.Length; i++, j++)
                right[j] = arr[i];

            // Recursive calls for left and right halves
            mergeSort(left);
            mergeSort(right);

            // Merge the two sorted halves
            Merge(arr, left, right);
        }

        public  void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Copy the remaining elements of left and right arrays, i there is available
            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public  void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
