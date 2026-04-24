using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class SearchMin
    {
        public double[] MinRow(double[][] matrix)
        {
            double[] result = new double[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    double min = double.MaxValue;
                    if (matrix[i][j] != -1)
                    {
                        if (matrix[i][j] < min)
                        {
                            min = matrix[i][j];
                        }
                    }
                    result[i] = min;
                }
            }
            return result;
        }


        public double[] MinColumn(double[][] matrix)
        {
            double[] result = new double[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                for (int i = 0; i < matrix[j].Length; i++)
                {
                    double min = double.MaxValue;
                    if (matrix[i][j] != -1)
                    {
                        if (matrix[i][j] < min)
                        {
                            min = matrix[i][j];
                        }
                    }
                    result[j] = min;
                }
            }
            return result;
        }
    }


}
