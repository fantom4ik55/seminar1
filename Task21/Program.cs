// Задача 21: 
// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB) // Введите свое решение ниже
    {
    
        int deltaX = pointB[0] - pointA[0];
        int deltaY = pointB[1] - pointA[1];
        int deltaZ = pointB[2] - pointA[2];

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance; 
    }
    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}