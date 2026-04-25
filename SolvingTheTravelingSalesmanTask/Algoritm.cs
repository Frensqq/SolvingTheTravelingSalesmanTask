using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask;


public class Algoritm()
{
    public int[][] searchZeroCells(int[][] matrix)
    {
        int[][] ratings = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            ratings[i] = new int[matrix[i].Length];
            for(int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    ratings[i][j] = ratingZeroCells(matrix, i, j);
                }
            }
        }
        return ratings;
    }
    public int ratingZeroCells(int[][] matrix, int zeroI, int zeroJ)
    {
        int minI = 0;
        for(int i = 0; i < matrix.Length;)
        {
            if(matrix[zeroI][i] < minI && matrix[i][zeroJ] != -1)
            {
                minI = matrix[zeroI][i];
            }
        }

        int minJ = 0;
        for (int i = 0; i < matrix.Length;)
        {
            if (matrix[i][zeroJ] < minI && matrix[i][zeroJ]!=-1)
            {
                minJ = matrix[i][zeroJ];
            }
        }
        return minI + minJ;
    }

    public int[] searchMaxRating(int[][] rating)
    {
        int[] cell = new int[3];
        for (int i = 0; i < rating.Length;i++) { 
            for (int j = 0; j < rating[i].Length; j++)
            {
                if (rating[i][j] > cell[0]) {
                    cell[0] = rating[i][j]; 
                    cell[1] = i;
                    cell[2] = j;
                }

            }
        }
        return cell;
    }

    public int lowerLimit(int oldLowerlimit, int[] minRow, int[] minColumn)
    {
        ArrayAction action = new ArrayAction();
        int summMinRow = action.SumArray(minRow);
        int summMinColumn = action.SumArray(minColumn);

        return oldLowerlimit + summMinRow + summMinColumn;
    }
}