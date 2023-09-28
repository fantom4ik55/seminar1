// Задача 26: 

// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

//Вариант 1


// using System;

// class Program {
//     static void Main(string[] args) {
//         Console.WriteLine("Введите число:");
//         string input = Console.ReadLine(); // считываем введенную строку
//         int count = 0;
//         foreach(char c in input) {
//             if (Char.IsDigit(c)) { // если символ является цифрой
//                 count++; // увеличиваем счетчик цифр
//             }
//         }
//         Console.WriteLine("Количество цифр в числе: " + count);
//         Console.ReadLine();
//     }
// }

//Вариант 2

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int LengthOfNumber(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num!=0)
    {
        count++;
        num = num/10;
    }
    return count;
}

int number = GetUserInput("Enter a number");
int length = LengthOfNumber(number);

Console.WriteLine($"{number} -> {length}");