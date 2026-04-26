using SolvingTheTravelingSalesmanTask;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Algoritm algoritm = new Algoritm();
        Inputs inputs = new Inputs();
        int[][] matrix = inputs.Matrix();
        int[][] roadMatrix = inputs.RoadMatrix(matrix);
        inputs.PrintMatrix(roadMatrix);
        

        int H = 0;
        List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        Console.WriteLine("\n=== Начало алгоритма ===\n");

        while (matrix.Length > 2)
        { 
            SearchMin searchMin = new SearchMin();
            Reduction reduction = new Reduction();
            ArrayAction arrayAction = new ArrayAction();

            int[] minRow = searchMin.MinRow(matrix);
            reduction.Row(minRow, matrix);

            int[] minColumn = searchMin.MinColumn(matrix);
            reduction.Column(minColumn, matrix);

            H = algoritm.lowerLimit(H, minRow, minColumn);

            inputs.PrintMatrix(matrix);
            Console.WriteLine($"Текущая нижняя граница: {H}");

            int[][] ratingMatrix = algoritm.searchZeroCells(matrix);
            int[] bestEdge = algoritm.searchMaxRating(ratingMatrix, roadMatrix);

            if (bestEdge[1] == -1 || bestEdge[2] == -1) break;

            Console.WriteLine($"Выбрано ребро: {bestEdge[3]} -> {bestEdge[4]} (оценка: {bestEdge[0]})");
            path.Add(new Tuple<int, int>(bestEdge[1], bestEdge[2]));

            arrayAction.BlockReversePath(matrix, bestEdge[1], bestEdge[2]);

            matrix = arrayAction.TrimArray(bestEdge[1], bestEdge[2], matrix);
            matrix = arrayAction.TrimArray(bestEdge[3], bestEdge[4], ratingMatrix);

            inputs.PrintMatrix(matrix);
        }

        if (matrix.Length == 2)
        {
            int row1 = 0, row2 = 1;
            int col1 = -1, col2 = -1;

            for (int j = 0; j < 2; j++)
            {
                if (matrix[0][j] != -1) col1 = j;
                if (matrix[1][j] != -1) col2 = j;
            }

            if (col1 != -1)
                path.Add(new Tuple<int, int>(row1, col1));
            if (col2 != -1 && col2 != col1)
                path.Add(new Tuple<int, int>(row2, col2));

            SearchMin searchMin = new SearchMin();
            int[] minRow = searchMin.MinRow(matrix);
            int[] minColumn = searchMin.MinColumn(matrix);
            ArrayAction arrayAction = new ArrayAction();
            
            H = algoritm.lowerLimit(H, minRow, minColumn);
        }

        Console.WriteLine("\n=== Результат ===");
        Console.WriteLine($"Минимальная длина маршрута: {H}");

        List<int> route = algoritm.BuildRoute(path);
        Console.Write("Маршрут: ");
        for (int i = 0; i < route.Count; i++)
        {
            Console.Write(route[i] + 1);
            if (i < route.Count - 1) Console.Write(" -> ");
        }
        Console.WriteLine();
    }


}
