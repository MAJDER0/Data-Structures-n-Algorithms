using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Easy
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> Occurencies = new Dictionary<int, int>();

            foreach (var value in nums)
            {

                if (Occurencies.ContainsKey(value))
                {
                    Occurencies[value]++;
                }
                else
                {
                    Occurencies.Add(value, 1);
                }
            }

            int maxValue = 0;
            int result = 0;

            foreach (var znak in Occurencies)
            {
                if (maxValue < znak.Value)
                {
                    maxValue = znak.Value;
                    result = znak.Key;
                }
            }
            return result;
        }
    }
}
