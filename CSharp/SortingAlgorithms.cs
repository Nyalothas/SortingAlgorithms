using System;
using System.Text;

namespace CSharp
{
    class SortingAlgorithms
    {
        public static void Print(int[] arr, bool sorted = false)
        {
            StringBuilder sortedArray = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray.Append(arr[i] + " ");
            }

            if(sorted)
                Console.WriteLine(sortedArray.Append("- sorted"));
            else
                Console.WriteLine(sortedArray.Append("- unsorted"));
        }

        // Swaps two values in an array
        public static void Exchange(ref int[] arr, int m, int n)
        {
            int temp = arr[m];

            arr[m] = arr[n];
            arr[n] = temp;
        }

        // Insertion sort
        public static void InsertionSort(int[] arr)
        {
            int temp, j;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }

            Print(arr,true);
        }



    }
}
