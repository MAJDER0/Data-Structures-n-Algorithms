﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Static_Data_Structure.Array.Problems.Medium
{
    public class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            int N = 9;

            HashSet<char>[] rows = new HashSet<char>[N];
            HashSet<char>[] cols = new HashSet<char>[N];
            HashSet<char>[] boxes = new HashSet<char>[N];

            for (int r = 0; r < N; r++)
            {
                rows[r] = new HashSet<char>();
                cols[r] = new HashSet<char>();
                boxes[r] = new HashSet<char>();
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    char val = board[r][c];

                    if (val == '.') continue;

                    if (rows[r].Contains(val)) return false;

                    rows[r].Add(val);

                    if (cols[c].Contains(val)) return false;

                    cols[c].Add(val);

                    int idx = (r / 3) * 3 + c / 3;

                    if (boxes[idx].Contains(val)) return false;

                    boxes[idx].Add(val);
                }
            }

            return true;
        }
    }
}
