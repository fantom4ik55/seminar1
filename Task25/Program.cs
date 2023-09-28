// Задача 25: 

// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень");
int darge = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 1; i <= darge; i++) 
{
    result *= number;
}

Console.WriteLine("{0} в степени {1} = {2}", number, darge, result );