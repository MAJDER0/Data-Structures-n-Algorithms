using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Insertion_Sort
    {

        // 6 8 2 4 1 
        // 6 2 8 4 1
        // 2 6 8 4 1
        // 2 6 4 8 1
        // 2 4 6 8 1
        // 2 4 6 1 8
        // 2 4 1 6 8
        // 2 1 4 6 8
        // 1 2 4 6 8

        //Time Complexity:

        //Worst Case: O(n^2) - when the array is sorted in reverse order
        //Average Case: O(n^2)
        //Best Case: O(n) - when the array is already sorted

        //Space Complexity: O(1) - sorting is done in-place, no extra memory required

        //Implementation for an array of integers
        public static void Insertion(int[] arrayOfIntegers)
        {

            for (int i = 1; i < arrayOfIntegers.Length; i++) // starting at second element. The first one is considered pre-sorted
            {
                int currentIndex = i; 

                while (currentIndex > 0 && (arrayOfIntegers[currentIndex-1] > arrayOfIntegers[currentIndex])) // swap values until it's on right place
                {
                    (arrayOfIntegers[currentIndex-1], arrayOfIntegers[currentIndex]) = (arrayOfIntegers[currentIndex], arrayOfIntegers[currentIndex-1]); // swap values
                    currentIndex--;
                }

            }

        }


        //Generic Implementation for any type
        public static void Insertion<T>(T[] arrayOfItems) where T : IComparable<T> {

            for (int i = 1; i < arrayOfItems.Length; i++) { 
            
                int currentIndex = i;

                while (currentIndex > 0 && (arrayOfItems[currentIndex - 1].CompareTo(arrayOfItems[currentIndex]) > 0)){

                    (arrayOfItems[currentIndex - 1], arrayOfItems[currentIndex]) = (arrayOfItems[currentIndex], arrayOfItems[currentIndex-1]);
                    currentIndex--;

                }
            }
        
        }

    }
}
