using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Merge_Sort
    {
        // 5 6 1 3 
        // 5 6   1 3
        // 5   6   1   3
        // 56   13
        // 1356

        //Time Complexity: O(n log n) worst, O(n log n) average, O(n log n) best
        //Space Complexity: O(n)

        public static void Merge(int[] arrayOfNumbers)
        {

            if (arrayOfNumbers.Length <= 1)
                return;

            int mid = arrayOfNumbers.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[arrayOfNumbers.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arrayOfNumbers[i];
            }

            for (int i = mid; i < arrayOfNumbers.Length; i++)
            {
                right[i - mid] = arrayOfNumbers[i];
            }

            Merge(left);
            Merge(right);

            MergeSubProblems(arrayOfNumbers, left, right);

        }

        private static void MergeSubProblems(int[] arrayOfNumbers, int[] left, int[] right)
        {

            int i=0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {

                if (left[i] <= right[j])
                {
                    arrayOfNumbers[k++] = left[i++];
                }
                else
                {
                    arrayOfNumbers[k++] = right[j++];
                }

            }

            while (i < left.Length)
                arrayOfNumbers[k++] = left[i++];

            while (j < right.Length)
                arrayOfNumbers[k++] = right[j++];

        }
    }
}
