using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Medium
{
    public class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            Dictionary<string, List<string>> hashmap = new Dictionary<string, List<string>>();
            int[] count = new int[26];

            foreach (var s in strs)
            {
                for (int i = 0; i < 26; i++)
                {
                    count[i] = 0;
                }

                foreach (char c in s) count[c - 'a']++;

                StringBuilder stringres = new StringBuilder();

                for (int i = 0; i < count.Length; i++)
                {
                    stringres.Append('#');
                    stringres.Append(count[i]);
                }
                string m = stringres.ToString();
                if (!hashmap.ContainsKey(m))
                {
                    hashmap.Add(m, new List<string>());
                    hashmap[m].Add(s);
                }
                else
                {
                    hashmap[m].Add(s);
                }
            }
            return new List<IList<string>>(hashmap.Values);
        }
    }
}
