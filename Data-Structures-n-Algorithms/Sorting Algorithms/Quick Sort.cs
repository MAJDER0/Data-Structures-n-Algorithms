using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Quick_Sort
    {

        //Implementation for an array of integers

        public static void Quick(int[] arrayOfNumbers, int low, int high) {

            if (low < high) {

                int pivot = PivotIndex(arrayOfNumbers,low,high);

                Quick(arrayOfNumbers,low,pivot-1);
                Quick(arrayOfNumbers,pivot+1,high);

            }

        }

        private static int PivotIndex(int[] arrayOfNumbers, int low, int high) {
            
            int pivot = arrayOfNumbers[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arrayOfNumbers[j] < pivot) {
                    i++;
                    (arrayOfNumbers[i], arrayOfNumbers[j]) = (arrayOfNumbers[j], arrayOfNumbers[i]);
                }
            }

            (arrayOfNumbers[i+1], arrayOfNumbers[high]) = (arrayOfNumbers[high], arrayOfNumbers[i+1]);

            return i + 1;

        }
    }
}
