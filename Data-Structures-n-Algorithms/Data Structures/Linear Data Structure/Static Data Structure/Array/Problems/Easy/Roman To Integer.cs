using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Easy
{
    public class Roman_To_Integer
    {

        private static Dictionary<char, int> values =
     new Dictionary<char, int>() { { 'I', 1 },   { 'V', 5 },   { 'X', 10 },
                                      { 'L', 50 },  { 'C', 100 }, { 'D', 500 },
                                      { 'M', 1000 } };

        public int RomanToInt(string s)
        {
            int total = 0;
            int i = 0;
            while (i < s.Length)
            {
                char currentSymbol = s[i];
                int currentValue = values[currentSymbol];
                int nextValue = 0;
                if (i + 1 < s.Length)
                {
                    char nextSymbol = s[i + 1];
                    nextValue = values[nextSymbol];
                }

                if (currentValue < nextValue)
                {
                    total += (nextValue - currentValue);
                    i += 2;
                }else
                 {
                    total += currentValue;
                    i += 1;
                 }
            }

            return total;
        }
    }
}
