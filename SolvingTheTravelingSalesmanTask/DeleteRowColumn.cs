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
            int rows = originalArray.GetLength(0);
            int cols = originalArray.GetLength(1);

            int[][] result = new int[rows-1][];

            for (int i = 0,j = 0; i < rows; i++) { 
            
                if (i == rowToRemove)
                    continue;

                result[i] = new int[cols - 1];

                for (int k = 0, u = 0; k < cols; k++)
                {
                    if (k == columnToRemove)
                        continue;

                    if (i == columnToRemove && k == rowToRemove)
                    {
                        result[j][u] = -1;
                    }
                    else
                    {
                        result[j][u] = originalArray[i][k];
                    }
                    u++;
                }
                j++;
            }
            return result;
        }

        public int SumArray(int[] array) {
            int sum = 0;
            foreach (var item in array)
            {
                if (item != -1) 
                { 
                    sum += item;
                }
            }
            return sum;
        }

    }
}
