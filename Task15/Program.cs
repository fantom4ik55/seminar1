// Задача 15:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.




Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string isWeekend = (dayOfWeek > 0 && dayOfWeek < 8) 
    ? (dayOfWeek == 6 || dayOfWeek == 7) ? "да" : "нет"
    : "не день недели";

Console.WriteLine($"{dayOfWeek} -> {isWeekend}");
