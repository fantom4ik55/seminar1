// Задача 4

// Напишите программу ,которая принимает на вход три числа 
// и выдает максимальное из этих числе.

// Пример:

// 2,3,7-> 7
// 44,5,78 -> 78
// 22, 3, 9 -> 22


Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine("Максимальное из этих чисел = " + max);