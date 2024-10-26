using Data_Structures_n_Algorithms.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Algorithms.Sorting_Algorithms
{
    public class Bucket_Sort
    {
        //Time Complexity:

        //Worst Case: O(n^2) or O(nlogn) if we use merge sort
        //Average Case: O(n + k) 
        //Best Case: O(n + k)

        //Space Complexity: O(n+k)


        public static void Bucket(float[] arrayOfNumbers) {

            //Each bucket is a list of floats
            List<float>[] buckets = new List<float>[arrayOfNumbers.Length];

            for (int i = 0; i < arrayOfNumbers.Length; i++) {

                buckets[i] = new List<float>();

            }

            //Put numbers into right buckets
            for (int i = 0; i < buckets.Length; i++) { 
            
                int key = (int)(arrayOfNumbers[i] * arrayOfNumbers.Length);
                buckets[key].Add(arrayOfNumbers[i]);
            }

            for (int i = 0; i < buckets.Length; i++) {
                Insertion(buckets[i]);
            }

            int index = 0;

            //Merge sorted buckets into the original array
            for (int i = 0; i < arrayOfNumbers.Length; i++) {
                for (int j = 0; j < buckets[i].Count(); j++) {

                    arrayOfNumbers[index++] = buckets[i][j];
                    
                }
            }     
        }

        private static void Insertion(List<float> bucket) {

            for (int i = 1; i < bucket.Count; i++) {
            
                float key = bucket[i];
                int j = i - 1;

                while (j >= 0 && bucket[j] > key) {

                    bucket[j + 1] = bucket[j];
                    j--;
                }

                bucket[j + 1] = key;          
            }      
        }

    }
}
