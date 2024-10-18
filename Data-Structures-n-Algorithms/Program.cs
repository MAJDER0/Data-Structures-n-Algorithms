using Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms;
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

            int[] listOfNumbers = {23,4,2,6,21,6,2,76,2,5467,342,5,23,65,213,56,12,564,12,4536,1,234,567,123,45,2,65,1,567,1,46,2346,567};

            //int[] listOfNumbers = {-234,-54,-45,-453,-45,-76,-87,-45,-12434,-54645,-23423,-546,-676,-67543,-56443};


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

            //Selection_Sort.Selection(listOfNumbers);


            /* ---------- Quick Sort ---------- */

            //Quick_Sort.Quick(listOfNumbers,0,listOfNumbers.Length-1);


            /* ---------- Counting Sort ---------- */

            listOfNumbers = Counting_Sort.Counting(listOfNumbers);


            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Data_Structures.Linear_Data_Structure.Array.Array array = new Data_Structures.Linear_Data_Structure.Array.Array(4);


            array[3] = 76235;

            Console.WriteLine(array[3]);

        }
    }
}
