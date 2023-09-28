// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Введите пяти значтоне число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }


using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Проверяем, является ли число пятизначным
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        string numberStr = number.ToString();

        int left = 0;
        int right = numberStr.Length - 1;

        while (left < right)
        {
            if (numberStr[left] != numberStr[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 55555;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        Console.WriteLine($"{result}");
    }
}