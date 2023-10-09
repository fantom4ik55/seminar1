// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int num = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = num;
                num += k;
            }
        }

        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        Console.WriteLine($"The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i].ToString("0.00") + "\t");
        }
        Console.WriteLine();

    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[] averages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, j];
            }
            averages[j] = sum / rows;
        }

        return averages;
    }

    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            n = 3;
            m = 4;
            k = 2;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}
