using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    //Time Complexity:

    //Worst Case: O(nlogn)
    //Average Case: O(nlogn)
    //Best Case: O(nlogn)

    //Space Complexity: O(logn)

    //Implementation for an array of integers
    public class Heap_Sort
    {
       public static void Heap(int[] arrayOfNumbers)
       {
            int length = arrayOfNumbers.Length;

            for (int i = length / 2 - 1; i >=0; i--) {

                Heapify(arrayOfNumbers,length,i);

            }

            for (int i = length - 1; i > 0; i--) {

                (arrayOfNumbers[0], arrayOfNumbers[i]) = (arrayOfNumbers[i], arrayOfNumbers[0]);
                Heapify(arrayOfNumbers,i,0);

            }

       }

        private static void Heapify(int[] arrayOfnumbers, int length, int currentNodeIndex)
        {
            int largest = currentNodeIndex;

            int left = 2 * currentNodeIndex + 1;
            int right = 2* currentNodeIndex + 2;

            if (left < length && arrayOfnumbers[left] > arrayOfnumbers[largest]) 
                largest = left;

            if(right < length && arrayOfnumbers[right] > arrayOfnumbers[largest])
                largest = right;

            if (largest != currentNodeIndex) {

                (arrayOfnumbers[currentNodeIndex], arrayOfnumbers[largest]) = (arrayOfnumbers[largest], arrayOfnumbers[currentNodeIndex]);
                Heapify(arrayOfnumbers,length,largest);
            }
        }
    }
}
