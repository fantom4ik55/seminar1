﻿// Задача 29: 

// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.



class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] numbers = new int[8];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 99);
        }

        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}