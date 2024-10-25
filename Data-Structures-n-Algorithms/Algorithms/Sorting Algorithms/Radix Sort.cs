using Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    // 170 45 75 90 802 24 2 66
    // 170 90 802 2 24 75 45 66
    // 802 2 24 45 66 170 75 90
    // 2 24 45 66 75 90 170 802
    // 2 24 45 66 75 90 170 802

    //Time Complexity:

    //Worst Case: O(n + k)
    //Average Case: O(n + k) 
    //Best Case: O(n + k)

    // ** where n is number of elements in the input array, and k is number of digits in the maximum number

    //Space Complexity: 

    //Implementation for an array of Integers
    public class Radix_Sort
    {
        public static void Radix(int[] arrayOfNumbers, int arrayLength) {

            int max = arrayOfNumbers[0];

            //Find the maximum number in the array
            for (int i = 1; i < arrayLength ; i++) {

                if (arrayOfNumbers[i]>max)
                    max = arrayOfNumbers[i];

            }

            for (int exponent = 1; max / exponent > 0 ;exponent*=10) {

                countSort(arrayOfNumbers,arrayLength,exponent); //counting sort for each digit (LSD)
            }

        }

        private static void countSort(int[] arrayOfNumbers, int arrayLength, int exponent) {

            int[] output = new int[arrayLength]; // output array
            int[] count = new int[10]; // count array for counting occurrences

            int i;

            for (i = 0; i < 10; i++) {
                count[i] = 0;
            }

            for (i = 0; i < arrayLength; i++) {

                count[(arrayOfNumbers[i] / exponent)%10]++;

            }

            //Prefix sum

            for (i = 1; i < 10; i++){

                count[i] += count[i - 1];
            }

            //Build an output array

            for (i = arrayLength - 1; i >= 0; i--) {

                output[count[(arrayOfNumbers[i]/exponent) % 10] - 1] = arrayOfNumbers[i];
                count[(arrayOfNumbers[i] / exponent) % 10]--;
            }

            //Copy output array to original array

            for (i = 0; i < arrayLength; i++) {
                arrayOfNumbers[i] = output[i];
            }
        }
    }
}
