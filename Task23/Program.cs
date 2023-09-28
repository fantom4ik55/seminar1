// Задача 23: 

// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

public class Answer
{
   static void ShowCube(int N)
    {
      int count = 1;
     while (count <= N){
        Console.WriteLine(count * count * count);
        count++;
     }
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}