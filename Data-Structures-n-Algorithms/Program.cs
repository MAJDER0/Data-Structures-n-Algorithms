using Data_Structures_n_Algorithms.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] listOfNumbers = {23,4,2,6,21,6,2,76,2,5467};


            /* ---------- Bubble Sort ---------- */

            //string[] listOfFruits = { "banana", "apple", "pear", "orange" };

            //Bubble_Sort.Bubble(listOfNumbers); //Number Sorting - Standard Implementation
            //Bubble_Sort.Bubble(listOfFruits); //Generic Sorting

            //Console.WriteLine("\n");

            //foreach (var fruit in listOfFruits)
            //{
            //    Console.WriteLine(fruit);
            //}



            /* ---------- Merge Sort ---------- */

            //Merge_Sort.Merge(listOfNumbers);



            /* ---------- Insertion Sort ---------- */

            //Insertion_Sort.Insertion(listOfNumbers);


            /* ---------- Selection Sort ---------- */

            Selection_Sort.Selection(listOfNumbers);


            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
