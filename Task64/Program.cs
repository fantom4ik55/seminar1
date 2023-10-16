// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"





int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string result)
{
    Console.WriteLine("\"" + result + "\"");
}



string LineGenRec(int num)
{
    if (num == 0)
    {
        return string.Empty;
    }
    else
    {
        return num + " ," + LineGenRec(num - 1);
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);

if (resultLine.EndsWith(","))
{
    resultLine = resultLine.Remove(resultLine.Length - 1);
}

Console.Write($"N={number}->  ");
PrintResult(resultLine);
