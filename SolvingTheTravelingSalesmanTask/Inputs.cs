using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class Inputs
    {
        public int[][] Matrix() {
            Console.Write("Введите кол-во пунктов: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        matrix[i][j] = -1;
                    }
                    else
                    {
                        Console.Write("[" + (i + 1) + ";" + (j + 1) + "] = ");
                        matrix[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return matrix;
        }

        public void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j],3} + |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Конец\n");
        }
    }
}
