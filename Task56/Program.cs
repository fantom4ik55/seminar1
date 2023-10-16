﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }

        return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
        int minSum = SumOfRow(matrix, 0);
        int minRowIndex = 0;

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            int rowSum = SumOfRow(matrix, i);
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return new int[] { minRowIndex, minSum };
    }

    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            matrix = new int[,]
            {
                {9, 1, 7},
                {1, 2, 3},
                {4, 5, 6}
            };
        }
        else
        {
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);
        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
    }
}
