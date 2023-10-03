// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int GetUserInput(string str)
// (string str) -> потому что мы дальше пишем "Введите число"
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool DivisionTo7and23(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int number = GetUserInput("Enter a number: ");
bool result = DivisionTo7and23(number);

Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");