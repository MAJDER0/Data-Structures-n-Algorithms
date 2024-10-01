using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Sorting_Algorithms
{
    public class Bubble_Sort
    {

        // 5 6 1 3 --> 5 1 6 3 --> 5 1 3 6 --> 1 5 3 6 --> 1 3 5 6 

        //Time Complexity:

        //Worst Case: O(n^2) - when the array is sorted in reverse order
        //Average Case: O(n^2)
        //Best Case: O(n) - when the array is already sorted

        //Space Complexity: O(1)


        //Implementation for an array of integers

        public static int[] Bubble(int[] listOfNumbers)
        {

            bool swaped;

            for (int i = 0; i < listOfNumbers.Length - 1; i++)
            {
                swaped = false;

                for (int j = 0; j < listOfNumbers.Length - 1 - i; j++)
                {
                    if (listOfNumbers[j] > listOfNumbers[j + 1])
                    {
                        swaped = true;
                        (listOfNumbers[j], listOfNumbers[j + 1]) = (listOfNumbers[j + 1], listOfNumbers[j]); //swap elements

                    }
                }

                if (!swaped)
                {
                    break; //If no swaps occured, the list is already sorted
                }
            }

            return listOfNumbers;
        }



        //Generic Implementation for any type

        public static T[] Bubble<T>(T[] listOfItems) where T: IComparable<T> {

            bool swaped;

            for (int i = 0; i < listOfItems.Length; i++)
            {
                swaped = false;

                for (int j = 0;j < listOfItems.Length-1-i; j++)
                {
                    if (listOfItems[j].CompareTo(listOfItems[j+1])>0)
                    {
                        swaped = true;
                        (listOfItems[j], listOfItems[j + 1]) = (listOfItems[j+1], listOfItems[j]); 
                    }
                }

                if (!swaped) {
                    break; 
                }

            }

            return listOfItems;
        }
    }
}
