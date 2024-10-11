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

        //Time Complexity:

        //Worst Case: O(n log n)
        //Average Case: O(n log n)
        //Best Case: O(n log n)

        //Space Complexity: O(n)


        //Implementation for an array of integers

        public static void Merge(int[] arrayOfNumbers) {

            if (arrayOfNumbers.Length <= 1) //If there is one or less elements in the list, return it
                return;

            int mid = arrayOfNumbers.Length / 2; //Find the middle of an array, and divide it into two halves

            int[] left = new int[mid]; //Create left sub-array 
            int[] right = new int[arrayOfNumbers.Length - mid]; //Create right sub-array

            for (int i = 0; i < mid; i++)
            {
                left[i] = arrayOfNumbers[i]; //Fill the left sub-array with the elements from the left half of the original array
            }

            for (int j = mid; j < arrayOfNumbers.Length; j++)
            {
                right[j - mid] = arrayOfNumbers[j]; //Fill the right sub-array with the elements from the right half of the original array
            }

            Merge(left); //Recursively sort the left sub-array
            Merge(right); //Recursively sort the right sub-array

            MergeSubProblems(arrayOfNumbers, left, right); //Merge the sorted left and right sub-array back into original array

        }

        private static void MergeSubProblems(int[] arrayOfNumbers, int[] left, int[] right) {
            int i = 0, k = 0, j = 0;

            while (i < left.Length && j < right.Length) //Merge elemets from left and right sub-arrays until one is exhausted
            {
                //Insert the smaller value into the main array
                if (left[i] <= right[j])
                {
                    arrayOfNumbers[k++] = left[i++];
                }
                else
                {
                    arrayOfNumbers[k++] = right[j++];
                }

            }

            //If there are remaining elements in the sub-array, add them to the main array
            while (i < left.Length)
                arrayOfNumbers[k++] = left[i++];

            while (j < right.Length)
                arrayOfNumbers[k++] = right[j++];

        }


        //Generic Implementation for any type

        public static void Merge<T>(T[] listOfItems) where T : IComparable<T> {
            if (listOfItems.Length <= 1)
                return;

            int mid = listOfItems.Length / 2;

            T[] left = new T[mid];
            T[] right = new T[listOfItems.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = listOfItems[i];
            }

            for (int i = mid; i < listOfItems.Length; i++)
            {
                right[i - mid] = listOfItems[i];
            }

            Merge(left);
            Merge(right);

            MergeSubProblems(listOfItems, left, right);

        }


        private static void MergeSubProblems<T>(T[] listOfItems, T[] left, T[] right) where T : IComparable<T> {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {

                if (left[i].CompareTo(right[j]) < 0 || left[i].CompareTo(right[j]) == -1)
                {
                    listOfItems[k++] = left[i++];
                }
                else
                {
                    listOfItems[k++] = right[j++];
                }

            }

            while (i < left.Length)
                listOfItems[k++] = left[i++];

            while (j < right.Length)
                listOfItems[k++] = right[j++];
        }
    }
}
