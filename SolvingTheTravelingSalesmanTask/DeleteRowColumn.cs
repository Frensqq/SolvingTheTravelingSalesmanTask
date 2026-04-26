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

        public int[][] initMatrix(int lenght, int width)
        {
            int[][] result = new int[lenght][];
            for (int i = 0; i < lenght; i++)
            {
                result[i] = new int[width];
            }
            return result;
        }



        public int[][] BlockReversePath(int[][] matrix, int[] cell)
        {
            int globalI = -1;
            int globalJ = -1;
            for (int i = 0; i< matrix.Length; i++)
            {
                if(matrix[i][0] == cell[2]) globalI = i;
            }
            for (int J = 0; J < matrix.Length; J++)
            {
                if (matrix[0][J] == cell[1]) globalJ = J;
            }



            if (cell[2] < matrix.Length && cell[1] < matrix.Length)
            {
                if (globalI != -1 && globalJ != -1) {
                    matrix[globalI][globalJ] = -1;
                }
            }
            return matrix;
        }
    }
}
