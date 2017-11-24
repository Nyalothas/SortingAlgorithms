using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 4, 6, 1, 3 };
            StringBuilder sortedArray = new StringBuilder();

            SortingAlgorithms.InsertionSort(ref arr);

            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray.Append(arr[i] + " ");
            }

            Console.WriteLine(sortedArray);

            Console.ReadKey();
        }
    }
}
