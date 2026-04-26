using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class Reduction
    {
        public void Row(int[] min, int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for(int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != -1)
                    {
                        matrix[i][j] -= min[i-1];
                    }
                }
            }
        }

        public void Column(int[] min, int[][] matrix) {
            for (int j = 1; j < matrix.Length; j++)
            {
                for (int i = 1; i < matrix[j].Length; i++)
                {
                    if (matrix[i][j] != -1)
                    {
                        matrix[i][j] -= min[j-1];
                    }
                }
            }
        }
    }
}
