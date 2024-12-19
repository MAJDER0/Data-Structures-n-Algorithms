using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Easy
{
    public class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>();

            triangle.Add(new List<int>());
            triangle[0].Add(1);

            for (int rowNum = 1; rowNum < numRows; rowNum++)
            {
                List<int> row = new List<int>();
                List<int> prevRow = (List<int>)triangle[rowNum - 1];
                row.Add(1);

                for (int j = 1; j < rowNum; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                row.Add(1);
                triangle.Add(row);
            }

            return triangle;
        }
    }
}
