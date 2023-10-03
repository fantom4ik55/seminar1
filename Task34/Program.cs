// // Задача 34: 

// // Задайте массив заполненный случайными
// // положительными трёхзначными числами. Напишите
// // программу, которая покажет количество чётных чисел в
// // массиве.

// //[345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

for (int arr = 0; arr < numbers.Length; arr++)
    if (numbers[arr] % 2 == 0)
        count++;

Console.WriteLine($"-> чётных {count} значения ");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}