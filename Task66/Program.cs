// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30




class Program
{
    static int Main()
    {
        int m, n;
        Console.Write("Введите значение M: ");
        m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        n = int.Parse(Console.ReadLine());

        if (m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }

        int sum = SumNaturalNumbers(m, n);
        Console.WriteLine($"M={m}; N={n} -> {sum}");

        return 0;
    }

    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else if (m <= 0)
        {
            return SumNaturalNumbers(m + 1, n);
        }
        else
        {
            return m + SumNaturalNumbers(m + 1, n);
        }
    }
}
