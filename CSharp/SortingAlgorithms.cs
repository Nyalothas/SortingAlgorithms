using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SortingAlgorithms
    {
        // Swaps two values in an array
        public static void Exchange(ref int[] arr, int m, int n)
        {
            int temp = arr[m];

            arr[m] = arr[n];
            arr[n] = temp;
        }

        // Insertion sort
        public static void InsertionSort(ref int[] arr)
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
        }

    }
}
