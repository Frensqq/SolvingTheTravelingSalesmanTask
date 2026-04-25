using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class ArrayAction
    {
        public int[][] TrimArray(int rowToRemove, int columnToRemove, int[][] originalArray)
        {
            int rows = originalArray.Length;
            int cols = originalArray[0].Length;

            int[][] result = new int[rows - 1][];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i == rowToRemove) continue;

                result[newRow] = new int[cols - 1];
                int newCol = 0;

                for (int j = 0; j < cols; j++)
                {
                    if (j == columnToRemove) continue;
                    result[newRow][newCol] = originalArray[i][j];
                    newCol++;
                }
                newRow++;
            }
            return result;
        }

        public int SumArray(int[] array) {
            int sum = 0;
            foreach (var item in array)
            {
                if (item != -1 && item != int.MaxValue) 
                { 
                    sum += item;
                }
            }
            return sum;
        }

        public void BlockReversePath(int[][] matrix, int from, int to)
        {
            if (from < matrix.Length && to < matrix.Length)
            {
                matrix[to][from] = -1;
            }
        }
    }
}
