using SolvingTheTravelingSalesmanTask;
using System;
using System.Collections.Generic;

Inputs inputs = new Inputs();
int[][] matrix = inputs.Matrix();
Console.Write("Исходная матрица: ");
inputs.PrintMatrix(matrix);

SearchMin searchMin = new SearchMin();
Reduction reduction = new Reduction();
ArrayAction arrayAction = new ArrayAction();
Algoritm algoritm = new Algoritm();

int H = 0;
int[] MinColumn = new int[matrix.Length-1];
int[] MinRow = new int[matrix.Length - 1];
int[][] path = arrayAction.initMatrix(matrix.Length - 1, 2);
int indexPath = 0;

while (matrix.Length > 2)
{

    MinRow = searchMin.MinRow(matrix);
    Console.Write("di: ");
    inputs.PrintArray(MinRow);
    reduction.Row(MinRow, matrix);
    Console.WriteLine("Матрица после редукции строк: ");
    inputs.PrintMatrix(matrix);


    MinColumn = searchMin.MinColumn(matrix);
    Console.Write("dj: ");
    inputs.PrintArray(MinColumn);
    reduction.Column(MinColumn, matrix);
    Console.WriteLine("Матрица после редукции столбцов: ");
    inputs.PrintMatrix(matrix);
    
    H += arrayAction.SumArray(MinRow) + arrayAction.SumArray(MinColumn);
    Console.WriteLine($"H{indexPath} = {H}");
    int[][] ratingMatrix = algoritm.searchZeroCells(matrix);
    Console.WriteLine($"Матрица оценок: ");
    inputs.PrintMatrix(ratingMatrix);


    int[] cell = algoritm.searchMaxRating(ratingMatrix, matrix);
    path[indexPath][0] = cell[3];
    path[indexPath][1] = cell[4];
   
    //inputs.PrintArray(cell);

    matrix = arrayAction.BlockReversePath(matrix, cell);
    matrix = arrayAction.TrimArray(cell[1], cell[2], matrix);
    Console.WriteLine($"Матрица после удаления {cell[3]} -> {cell[4]}");
    inputs.PrintMatrix(matrix);
    indexPath++;
}

H += matrix[1][1];
path[indexPath][0] = matrix[1][0];
path[indexPath][1] = matrix[0][1];


Console.WriteLine("Результат: ");
int[] rezult = algoritm.BuildPath(path);
for (int i = 0; i < rezult.Length; i++)
{
    if (i != rezult.Length - 1)
    {
        Console.Write(rezult[i] + " -> ");
    }
    else {
        Console.WriteLine(rezult[i] + "  ");
    }
}

Console.Write($"H = {H}");
