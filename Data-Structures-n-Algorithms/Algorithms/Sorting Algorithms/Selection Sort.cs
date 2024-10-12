using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Selection_Sort
    {
        // 64 25 12 22 11
        // 11 25 12 22 64
        // 11 12 25 22 64
        // 11 12 22 25 64
        // 11 12 22 25 64

        //Time Comlexity:

        //Worst Case: O(n^2) - when the array is sorted in reverse order
        //Average Case: O(n^2)
        //Best Case: O(n^2) - when the array is already sorted

        //Space Complexity: O(1) 

        //Implementation for an array of integers

        public static void Selection(int[] arrayOfNumbers) {
            for (int i = 0; i < arrayOfNumbers.Length-1; i++) 
            {
                int min  = i;

                for (int j = i+1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[j] < arrayOfNumbers[min]) {
                        min = j;
                    }

                }

                (arrayOfNumbers[i], arrayOfNumbers[min]) = (arrayOfNumbers[min],arrayOfNumbers[i]);
            }

        }


        //Generic Implementation for any type

        public static void Selection<T>(T[] arrayOfItems) where T : IComparable<T> {
            for (int i = 0; i < arrayOfItems.Length-1; i++)
            {
                int min = i;

                for (int j = i+1; j < arrayOfItems.Length; j++)
                {
                    if (arrayOfItems[j].CompareTo(arrayOfItems[min]) < 0) 
                    {
                        min = j;
                    }
                }

                (arrayOfItems[i], arrayOfItems[min]) = (arrayOfItems[min], arrayOfItems[i]);
            }
        
        }
    }
}
