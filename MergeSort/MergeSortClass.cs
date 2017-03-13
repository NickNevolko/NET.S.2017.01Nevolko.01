using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSortClass
    {
        public static int[] Sorting(int[] array)
        {
            return MergeSort(array);
        }
        private static int[] MergeSort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            if (arr.Length == 0 || arr.Length == 1)
                return arr;

            int middle = arr.Length / 2;

            return Merge(MergeSort(arr.Take(middle).ToArray()), MergeSort(arr.Skip(middle).ToArray()));
        }

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
