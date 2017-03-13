using MergeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rd = new Random();


            #region sort_even_arr
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(0, 100);
            }
            arr = MergeSortClass.Sorting(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region sort_odd_arr
            int[] arr2 = new int[101];
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = rd.Next(0, 100);
            }

            arr2 = MergeSortClass.Sorting(arr2);
            foreach (var item in arr2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            int[] nullarr = MergeSortClass.Sorting(null);

        }
    }
}
