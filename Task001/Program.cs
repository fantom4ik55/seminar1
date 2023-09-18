// Напишите программу ,которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

// Пример:
// а= 25 , b= 5 -> да
// а= 2 ,  b=10 -> нет
// a= 9,   b=-3 -> да
// a= -3,  b= 9 -> нет


Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine("Первое число является квадратом");
}
else
{
    Console.WriteLine("Первое число не является квадратом");
} 