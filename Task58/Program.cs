// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



using System;

public class Answer
{
	public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
	{
		if (matrixA.GetLength(1) != matrixB.GetLength(0))
		{
			Console.WriteLine("It is impossible to multiply.");
			return;
		}
		
		int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB);
		PrintMatrix(resultMatrix);
	}

	public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
	{
		int rowsA = matrixA.GetLength(0);
		int colsA = matrixA.GetLength(1);
		int colsB = matrixB.GetLength(1);

		int[,] multipliedMatrix = new int[rowsA, colsB];

		for (int i = 0; i < rowsA; i++)
		{
			for (int j = 0; j < colsB; j++)
			{
				multipliedMatrix[i, j] = 0;

				for (int k = 0; k < colsA; k++)
				{
					multipliedMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
				}
			}
		}

		return multipliedMatrix;
	}

	public static void PrintMatrix(int[,] matrix)
	{
		for(int i = 0; i < matrix.GetLength(0); i++)
		{
			for(int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write(matrix[i,j] + "\t");
			}
			Console.WriteLine();
		}
	}

	public static void Main(string[] args)
	{
		int[,] matrix;

		if (args.Length == 0)
		{
			matrix = new int[,]
			{
				{1, 2},
				{3, 4}
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
		PrintMatrix(matrix);

		int[,] matrixB = {
			{5, 6},
			{7, 8}
		};

		Console.WriteLine("\nMatrix B:");
		PrintMatrix(matrixB);

		Console.WriteLine("\nMultiplication result:");

		MultiplyIfPossible(matrix, matrixB);
	}
}

