using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    public class Counting_Sort
    {
        // 5 6 1 3 - input array
        // (index 0)-0 (1)-1 (2)-0 (3)-1 (4)-0 (5)-1 (6)-1 - count array
        // 0 1 1 2 2 3 4 - count array (prefix sum)
        // 1 3 5 6 - output array

        //Time Complexity:

        //Worst Case: O(n+m)
        //Average Case: O(n+m) 
        //Best Case: O(n+m)

        // * where n and m are the size of iput array and count array respectively 

        //Space Complexity: O(n+m)


        //Implementation for an array of integers

        public static int[] Counting(int[] arrayOfNumbers) {


            if (arrayOfNumbers == null || arrayOfNumbers.Length == 0)
                return arrayOfNumbers;


            int minElement = arrayOfNumbers[0]; //set first number as min element so we can run loop one less time
            int maxElement = arrayOfNumbers[0]; //set first number as max element so we can run loop one less time


            for (int i = 1; i < arrayOfNumbers.Length; i++) // start from 1 and look for min and max element
            {
                if (arrayOfNumbers[i] > maxElement)
                    maxElement = arrayOfNumbers[i]; 

                if (arrayOfNumbers[i] < minElement)
                    minElement = arrayOfNumbers[i];
            }


            /* Set range to maxElement - minElement + 1 to make the algorithm work with negative numbers.
               If we did range = maxElement + 1, it would work only for positive numbers.
               We map negative values to positive indices; so if we have numbers from -30 up to 60,
               -30 will be at index 0, and our range will be 90 + 1.
            */
            int range = maxElement - minElement + 1; 
                


            int[] countArray = new int[range];


            // Count how many times a value appears in arrayOfNumbers.
            // If number 3 occurs 5 times in our original list, at index 3 of countArray we will store number 5.

            for (int i = 0; i < arrayOfNumbers.Length; i++) 
                countArray[arrayOfNumbers[i] - minElement]++;


            //Prefix sum to determine correct position at output array

            for (int i = 1; i < countArray.Length; i++)
                countArray[i] += countArray[i - 1];


            int[] outputArray = new int[arrayOfNumbers.Length];

            // Arrange elements at their correct positions. Reverse loop to keep the algorithm stable.

            for (int i = arrayOfNumbers.Length-1;i>=0;i--) {

                outputArray[countArray[arrayOfNumbers[i] - minElement]-1] = arrayOfNumbers[i];
                countArray[arrayOfNumbers[i] - minElement]--;

            }

            return outputArray;
        }

        //Generic Implementation for any Type

        public static T[] Counting<T>(T[] arrayOfItems, Func<T, int> key) where T : IComparable<T>
        {

            if (arrayOfItems == null || arrayOfItems.Length == 0)
                return arrayOfItems;


            int maxKey = key(arrayOfItems[0]);
            int minKey = key(arrayOfItems[0]);


            for (int i = 1; i < arrayOfItems.Length; i++)
            {
                int item = key(arrayOfItems[i]);

                if (item > maxKey) maxKey = item;
                if (item < minKey) minKey = item;

            }

            int range = maxKey - minKey + 1;


            int[] countArray = new int[range];

            for (int i = 0; i < arrayOfItems.Length; i++) {

                countArray[key(arrayOfItems[i])-minKey]++;

            }

            for (int i = 1; i< countArray.Length; i++) {

                countArray[i] += countArray[i-1];
            
            }

            T[] outputArray = new T[arrayOfItems.Length];

            for (int i = arrayOfItems.Length - 1; i >= 0; i--)
            {
                int index = key(arrayOfItems[i]) - minKey; 
                outputArray[countArray[index] - 1] = arrayOfItems[i]; 
                countArray[index]--; 
            }

            return outputArray;
        }
    }
}
