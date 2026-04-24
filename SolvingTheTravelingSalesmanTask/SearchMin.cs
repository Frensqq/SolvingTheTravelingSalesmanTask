using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class SearchMin
    {
        public int[] MinRow(int[][] matrix)
        {
            int[] result = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int min = int.MaxValue;
                    if (matrix[i][j] != -1)
                    {
                        if (matrix[i][j] < min)
                        {
                            min = matrix[i][j];
                        }
                    }
                    result[i] = min;
                }
            }
            return result;
        }


        public int[] MinColumn(int[][] matrix)
        {
            int[] result = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                for (int i = 0; i < matrix[j].Length; i++)
                {
                    int min = int.MaxValue;
                    if (matrix[i][j] != -1)
                    {
                        if (matrix[i][j] < min)
                        {
                            min = matrix[i][j];
                        }
                    }
                    result[j] = min;
                }
            }
            return result;
        }
    }


}
