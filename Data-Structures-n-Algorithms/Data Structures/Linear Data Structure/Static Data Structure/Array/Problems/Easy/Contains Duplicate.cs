using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Easy
{
    public class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {

            System.Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }
            return false;
        }
    }
}
