using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };

            SortingAlgorithms.Print(arr);

            // Insertion Sort
            SortingAlgorithms.InsertionSort(arr);

            Console.ReadKey();
        }
    }
}
