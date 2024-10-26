using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    public class Shell_Sort
    {
        public static void Shell(float[] arrayOfNumbers) {

            int n = arrayOfNumbers.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    float temp = arrayOfNumbers[i];
                    int j = i;
                    while (j >= gap && arrayOfNumbers[j - gap] > temp)
                    {
                        arrayOfNumbers[j] = arrayOfNumbers[j - gap];
                        j -= gap;
                    }
                    arrayOfNumbers[j] = temp;
                }
            }
        }
    }
}
