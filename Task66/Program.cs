// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.


int GetSum(int m, int n)
{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int sum = GetSum(m, n);

PrintData($"M={m}, N={n}-> ", sum);



