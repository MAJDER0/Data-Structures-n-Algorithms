using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    public class Counting_Sort
    {

        //Implementation for an array of integers

        public static int[] Counting(int[] arrayOfNumbers) {

            int maxElement = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++) 
                maxElement = Math.Max(maxElement, arrayOfNumbers[i]);
            

            int[] countArray = new int[maxElement+1];


            for (int i = 0; i < countArray.Length; i++) 
                countArray[arrayOfNumbers[i]]++;


            for (int i = 0; i < countArray.Length; i++)
                countArray[i] += countArray[i - 1];

            int[] outputArray = new int[maxElement];

            for (int i = arrayOfNumbers.Length-1;i>=0;i--) {

                outputArray[countArray[arrayOfNumbers[i]]-1] = arrayOfNumbers[i];
                countArray[arrayOfNumbers[i]]--;

            }

            return outputArray;
        }
    }
}
