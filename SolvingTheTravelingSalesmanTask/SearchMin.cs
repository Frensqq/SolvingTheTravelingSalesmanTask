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
            int[] result = new int[matrix.Length-1];
            for (int i = 1; i < matrix.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != -1 && matrix[i][j] < min)
                    {
                        min = matrix[i][j];
                    }
                    if(min == int.MaxValue) result[i-1] = 0;
                    else result[i-1] = min;
                }
            }
            return result;
        }


        public int[] MinColumn(int[][] matrix)
        {
            int[] result = new int[matrix.Length-1];
            for (int j = 1; j < matrix.Length; j++)
            {
                int min = int.MaxValue;
                for (int i = 1; i < matrix.Length; i++)
                {
                    if (matrix[i][j] != -1 && matrix[i][j] < min)
                    {
                        min = matrix[i][j];
                    }
                }
                if (min == int.MaxValue) result[j-1] = 0;
                else result[j-1] = min;
            }
            return result;
        }

        
    }


}
