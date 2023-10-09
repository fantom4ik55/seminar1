
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите количество чисел:");
//         int m = Convert.ToInt32(Console.ReadLine());

//         int count = 0;

//         for (int i = 0; i < m; i++)
//         {
//             Console.WriteLine($"Введите число {i + 1}:");
//             int number = Convert.ToInt32(Console.ReadLine());

//             if (number > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел, больших нуля -> {count}");
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел:");
        int m = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int[] numbers = new int[m];

        for(int i = 0; i < m; i++)
        {
            numbers[i] = rand.Next(-100, 100); 
            Console.Write($"{i + 1}");
            Console.Write("{numbers[i]}");
        }

        int count = 0;

        for (int i = 0; i < m; i++)
        {
            if (numbers[i] > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших нуля -> {count}");
    }
}
