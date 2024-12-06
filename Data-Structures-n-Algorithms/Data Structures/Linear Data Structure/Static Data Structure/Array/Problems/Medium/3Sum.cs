using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Medium
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            System.Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
                if (i == 0 || nums[i - 1] != nums[i])
                {
                    TwoSumII(nums, i, result);
                }

            return result;
        }

        void TwoSumII(int[] nums, int i, List<IList<int>> res)
        {
            int leftPointer = i + 1, rightPointer = nums.Length - 1;
            while (leftPointer < rightPointer)
            {
                int sum = nums[i] + nums[leftPointer] + nums[rightPointer];
                if (sum < 0)
                {
                    ++leftPointer;
                }
                else if (sum > 0)
                {
                    --rightPointer;
                }
                else
                {
                    res.Add(new List<int> { nums[i], nums[leftPointer++], nums[rightPointer--] });
                    while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer - 1]) ++leftPointer;
                }
            }
        }
    }
}
