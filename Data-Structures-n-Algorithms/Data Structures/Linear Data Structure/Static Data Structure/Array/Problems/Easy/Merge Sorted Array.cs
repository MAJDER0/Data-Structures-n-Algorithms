using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Easy
{
    public class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            System.Array.Sort(nums1);
        }
    }
}
