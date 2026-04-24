using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheTravelingSalesmanTask
{
    internal class Inputs
    {
        public double[][] Input() {
            Console.Write("Введите кол-во пунктов: ");
            int size = Convert.ToInt32(Console.ReadLine());

            double[][] matix = new double[size][];

            for (int i = 0; i < size; i++)
            {
                matix[i] = new double[size];
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        matix[i][j] = -1;
                    }
                    else
                    {
                        Console.Write("[" + (i + 1) + ";" + (j + 1) + "] = ");
                        matix[i][j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            return matix;
        }
    }
}
