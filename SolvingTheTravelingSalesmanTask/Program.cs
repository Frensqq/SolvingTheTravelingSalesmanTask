<<<<<<< HEAD
﻿
=======
﻿using SolvingTheTravelingSalesmanTask;


Inputs inputs = new Inputs();
int[][] matrix = inputs.Matrix();

int[][] result = new int[matrix.Length][];

int H = 0;

for(int i = 0; matrix.Length > 0; i++)
{
    Console.WriteLine($"\n-------{i}-------");
    SearchMin searchMin = new SearchMin();
    Reduction reduction = new Reduction();
    int[] minColumn = searchMin.MinColumn(matrix);
    reduction.Column(minColumn, matrix);
    inputs.PrintMatrix(matrix);

    int[] minRow = searchMin.MinRow(matrix);
    reduction.Row(minRow, matrix);
    inputs.PrintMatrix(matrix);

    ArrayAction arrayAction = new ArrayAction();
    Algoritm algoritm = new Algoritm();
    H += algoritm.lowerLimit(H, minRow, minColumn);

    
    int[][] ratingMatrix = algoritm.searchZeroCells(matrix);
    int[] rating = algoritm.searchMaxRating(ratingMatrix);
    inputs.PrintMatrix(ratingMatrix);

    arrayAction.TrimArray(rating[1], rating[2], matrix);
    inputs.PrintMatrix(matrix);

    result[i] = new int[2];
    result[i][0] = rating[1] + 1;
    result[i][1] = rating[2] + 1;
    Console.WriteLine("--------------\n");
}
Console.WriteLine(result);
>>>>>>> 368415e51c976f664613f49b2b2863c4081d3c12
