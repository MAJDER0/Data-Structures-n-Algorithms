using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    public class Shell_Sort
    {
        //Time Comlexity:

        //Worst Case: O(n^2)
        //Average Case: O(n^2)
        //Best Case: O(nlogn)

        // ** gap sequence: n/2 where n is the number of elements in the array

        //Space Complexity: O(1)

        //Implementation for an array of integers
        static void Shell(int[] arrayOfNumbers)
        {
            int length = arrayOfNumbers.Length;

            for (int gap = length / 2; gap > 0; gap /= 2) {

                for (int i = gap; i < length; i++) {
                    
                    int temp = arrayOfNumbers[i];
                    int j;

                    for (j = i; j >= gap && arrayOfNumbers[j-gap] > temp ; j-=gap) 
                        arrayOfNumbers[j] = arrayOfNumbers[j-gap];

                    arrayOfNumbers[j] = temp;
                }
            }
        }

        //Generic Implementation for any Type
        static void Shell<T>(T[] arrayOfItems) where T : IComparable<T> {
            
            int length = arrayOfItems.Length;

            for (int gap = length / 2; gap > 0; gap /= 2) {

                for (int i = gap; i < length; i++) {
                    
                    T temp = arrayOfItems[i];
                    int j;

                    for (j = i; j >= gap && arrayOfItems[j - gap].CompareTo(temp) > 0; j -= gap)
                        arrayOfItems[j] = arrayOfItems[j-gap];

                    arrayOfItems[j] = temp;
                }
            }    
        }
    }
}