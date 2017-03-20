using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    /// <summary>
    /// static class which contains a MergeSort method
    /// </summary>
    public class Task1
    {
        /// <summary>
        /// Method which sorts an array,
        /// has a one parameter
        /// </summary>
        /// <param name="array">one parameter is array of ints. </param>
        /// <returns>returns a new sorted array of integers</returns>
        public static void Sorting(int[] array)
        {
            int [] sorted_array = MergeSort(array);
            Array.Copy(sorted_array, array, array.Length);
        }

        /// <summary>
        /// Split and calls a Merge method
        /// </summary>
        private static int[] MergeSort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            if (arr.Length == 0 || arr.Length == 1)
                return arr;

            int middle = arr.Length / 2;

            return Merge(MergeSort(arr.Take(middle).ToArray()), MergeSort(arr.Skip(middle).ToArray()));
        }

        /// <summary>
        /// Merges arrays to new one result array
        /// </summary>
        private static int[] Merge(int[] array1, int[] array2)
        {
            int a = 0;
            int b = 0;
            int[] merged = new int[array1.Length + array2.Length];

            for (int i = 0; i < merged.Length; i++)
            {
                if (a < array1.Length && b < array2.Length)
                    if (array1[a] > array2[b])
                    {
                        merged[i] = array2[b++];
                    }
                    else
                    {
                        merged[i] = array1[a++];
                    }
                else if (b < array2.Length)
                {

                    merged[i] = array2[b++];
                }
                else
                    merged[i] = array1[a++];
            }
            return merged;
        }
    }
}

