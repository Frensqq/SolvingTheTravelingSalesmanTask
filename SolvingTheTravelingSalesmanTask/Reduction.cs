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
            for (int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != -1)
                    {
                        matrix[i][j] -= min[i];
                    }
                }
            }
        }

        public void Column(int[] min, int[][] matrix) {
            for (int j = 0; j < matrix.Length; j++)
            {
                for (int i = 0; i < matrix[j].Length; i++)
                {
                    if (matrix[i][j] != -1)
                    {
                        matrix[i][j] -= min[j];
                    }
                }
            }
        }
    }
}
