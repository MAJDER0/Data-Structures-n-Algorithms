using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Quick_Sort
    {
        // 10 80 30 90 40 (pivot)
        // 10 30 80 90 40
        // 10 30 40 (pivot) 90 80
        // 10 30 (pivot)   90 80 (pivot)
        // 10 30   80 90   
        // 10   30   80   90
        // 10 30 40 80 90

        //Time Complexity:

        //Worst Case: O(n^2) when the smallest or largest element is always chosen as the pivot
        //Average Case: O(nlogn) the pivot divides the array into two parts, but not necessarily equal
        //Best Case: O(nlogn) when the pivot element divides the array into two equal halves

        //Space Complexity: O(n)

        //Implementation for an array of integers

        public static void Quick(int[] arrayOfNumbers, int start, int end) {

            if (end <= start) return;

            int pivot = Partition(arrayOfNumbers, start, end);

            Quick(arrayOfNumbers, start, pivot - 1);
            Quick(arrayOfNumbers, pivot + 1, end);

        }

        private static int Partition(int[] arrayOfNumbers, int start, int end) {

            int pivot = arrayOfNumbers[end];

            int i = start - 1;

            for (int j = start; j < end; j++) {

                if (arrayOfNumbers[j] <= pivot) {
                    i++;
                    (arrayOfNumbers[i], arrayOfNumbers[j]) = (arrayOfNumbers[j], arrayOfNumbers[i]);
                }

            }

            (arrayOfNumbers[i + 1], arrayOfNumbers[end]) = (arrayOfNumbers[end], arrayOfNumbers[i + 1]);

            return i + 1;
        }


        //Generic Implementation for any Type

        public static void Quick<T>(T [] arrayOfItems, int start, int end) where T : IComparable<T> {

            if (end <= start) return;

            int pivot = Partition(arrayOfItems, start, end);

            Quick(arrayOfItems, start, pivot - 1);
            Quick(arrayOfItems, pivot + 1, end);
        }

        private static int Partition<T>(T[] arrayOfItems, int start, int end) where T : IComparable<T> {

            T pivot = arrayOfItems[end];

            int i = start - 1;

            for (int j = start; j < end; j++) {

                if (arrayOfItems[j].CompareTo(pivot) < 0) {

                    i++;
                    (arrayOfItems[i], arrayOfItems[j]) = (arrayOfItems[j], arrayOfItems[i]);
                
                }

            }

            (arrayOfItems[i + 1], arrayOfItems[end]) = (arrayOfItems[end], arrayOfItems[i + 1]);

            return i + 1;
        }
    }
}
