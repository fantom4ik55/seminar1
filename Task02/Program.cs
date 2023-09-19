// Задача 2
// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число больше, какое меньше.

// Пример:

// a=5 ; b=7 -> max= 7
// a=2; b=10 -> max=10
// a=-9; b= -3 -> max=-3

Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число " + number1 + " большее");
    Console.Write("Число " + number2 + " меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine("Число " + number1 + " равно числу " + number2);
}
else
{
    Console.WriteLine("Число " + number2 + " большее");
    Console.Write("Число " + number1 + " меньшее");
}
