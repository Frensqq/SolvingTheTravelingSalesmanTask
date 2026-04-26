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
        int minI = int.MaxValue;
        for (int i = 0; i < matrix.Length; i++)
        {
            if (i != zeroJ && matrix[zeroI][i] != -1 && matrix[zeroI][i] < minI)
            {
                minI = matrix[zeroI][i];
            }
        }
        if (minI == int.MaxValue) minI = 0;

        int minJ = int.MaxValue;
        for (int i = 0; i < matrix.Length; i++)
        {
            if (i != zeroI && matrix[i][zeroJ] != -1 && matrix[i][zeroJ] < minJ)
            {
                minJ = matrix[i][zeroJ];
            }
        }
        if (minJ == int.MaxValue) minJ = 0;

        return minI + minJ;
    }

    public int[] searchMaxRating(int[][] rating, int[][] roadMatirx)
    {
        int[] cell = { -1, -1, -1 };
        for (int i = 0; i < rating.Length; i++)
        {
            for (int j = 0; j < rating[i].Length; j++)
            {
                if (rating[i][j] > cell[0])
                {
                    cell[0] = rating[i][j];
                    cell[1] = i;
                    cell[2] = j;
                    cell[3] = roadMatirx[i+1][0];
                    cell[4] = roadMatirx[0][j+1];
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

    public List<int> BuildRoute(List<Tuple<int, int>> edges)
    {
        Dictionary<int, int> next = new Dictionary<int, int>();
        foreach (var e in edges)
        {
            next[e.Item1] = e.Item2;
        }
        List<int> route = new List<int>();
        int start = edges[0].Item1;
        int current = start;
        while (next.ContainsKey(current))
        {
            route.Add(current);
            current = next[current];
        }
        route.Add(current);
        route.Add(start);

        return route;
    }
}
