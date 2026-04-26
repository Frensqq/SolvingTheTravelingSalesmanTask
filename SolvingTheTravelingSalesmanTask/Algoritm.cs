using System;

namespace SolvingTheTravelingSalesmanTask;

public class Algoritm()
{
    public int[][] searchZeroCells(int[][] matrix)
    {
        int[][] ratings = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            ratings[i] = new int[matrix[i].Length];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                
                if (i != 0 && j != 0 && matrix[i][j] == 0)
                {
                    ratings[i][j] = ratingZeroCells(matrix, i, j);
                }
            }
        }
        return ratings;
    }

    public int ratingZeroCells(int[][] matrix, int zeroI, int zeroJ)
    {
        int minI = int.MaxValue;
        
        for (int i = 1; i < matrix[zeroI].Length; i++)
        {
            if (i != zeroJ && matrix[zeroI][i] != -1 && matrix[zeroI][i] < minI)
            {
                minI = matrix[zeroI][i];
            }
        }

        int minJ = int.MaxValue;
        
        for (int i = 1; i < matrix.Length; i++)
        {
            if (i != zeroI && matrix[i][zeroJ] != -1 && matrix[i][zeroJ] < minJ)
            {
                minJ = matrix[i][zeroJ];
            }
        }
        

        return minI + minJ;
    }

    public int[] searchMaxRating(int[][] rating, int[][] roadMatirx)
    {
        int[] cell = { -1, -1, -1, -1, -1 };
        for (int i = 1; i < rating.Length; i++)
        {
            for (int j = 1; j < rating[i].Length; j++)
            {
                
                if (rating[i][j] >= cell[0])
                {
                    cell[0] = rating[i][j];
                    cell[1] = i;
                    cell[2] = j;
                    cell[3] = roadMatirx[i][0];
                    cell[4] = roadMatirx[0][j];
                }
            }
        }
        return cell;
    }

    public int[] BuildPath(int[][] pairs)
    {
        List<int> result = new List<int>();
        int current = pairs[0][1]; 

        for (int i = 0; i <= pairs.Length; i++)
        {
            result.Add(current);

            for (int j = 0; j < pairs.Length; j++)
            {
                if (pairs[j][0] == current)
                {
                    current = pairs[j][1];
                    break;
                }
            }
        }

        return result.ToArray();
    }
}
