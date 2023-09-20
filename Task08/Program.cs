// Задача 8.

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.

// Пример:

// 5 -> 2, 4
// 8-> 2, 4, 6, 8


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= number; index++)
{
    if (index % 2 == 0)
        Console.WriteLine(index + ",");
}