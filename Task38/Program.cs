// Задача 38: 

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[size];
FillArrayRandomNum(numbers);
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

void FillArrayRandomNum(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(1, 100))/10;
    }
}

for (int arr = 0; arr < numbers.Length; arr++)
{
    if (numbers[arr] > max)
    {
        max = numbers[arr];
    }
    if (numbers[arr] < min)
    {
        min = numbers[arr];
    }
}

Console.WriteLine($"-> {max - min}");


void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}