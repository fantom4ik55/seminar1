﻿// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// // что такого элемента нет



// using System;

// public class Answer {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] matrix = new int[n, m];
//         int num = 1;

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < m; j++)
//             {
//                 matrix[i, j] = num;
//                 num += k;
//             }
//         }

//         return matrix;
//     }

//     public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
//     {
//         int numRows = matrix.GetLength(0);
//         int numCols = matrix.GetLength(1);

//         if (rowPosition < 0 || rowPosition >= numRows || columnPosition < 0 || columnPosition >= numCols)
//         {
//             return new int[] { 0 };
//         }
//         else
//         {
//             return new int[] { matrix[rowPosition, columnPosition], 0 };
//         }
//     }

//     public static void PrintCheckIfError(int[] results, int x, int y)
//     {
//         if (results.Length == 1)
//         {
//             Console.WriteLine("There is no such index");
//         }
//         else
//         {
//             Console.WriteLine("The number in [{0}, {1}] is {2}", x, y, results[0]);
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int n, m, k, x, y;

//         if (args.Length >= 5)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//             k = int.Parse(args[2]);
//             x = int.Parse(args[3]);
//             y = int.Parse(args[4]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             n = 4;
//             m = 5;
//             k = 3;
//             x = 2;
//             y = 2;
//         }

//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                Console.Write($"{matrix[i,j]}"+"\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] newMatrix = new int[n,m];
        int currentValue = 1;
        for (int i=0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                newMatrix[i,j] = currentValue;
                currentValue += k;
            }
        }
        return newMatrix;
    }

    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
        int [] number={0,-1};
        if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
        {
            number[1]=0;
            number[0]=matrix[rowPosition-1,columnPosition-1];
            return number;
        }
        return number;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
        if (results[1]==-1){Console.WriteLine("There is no such index");}
        else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
           x = 2;
           y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
