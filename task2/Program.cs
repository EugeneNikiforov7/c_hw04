// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант 1

// int GetSumDig(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }

// int GetInfo(string message)
// {
//     Console.Write(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int number = GetInfo("Введите число: ");
// int  res = GetSumDig(number);
// Console.Write($"{number} -> {res}");

// Вариант 2

int GetSumDig(string num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        result = result + Int32.Parse((num[i].ToString()));
    }
    return result;
}

string GetInfo(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}

string number = GetInfo("Введите число: ");
int  res = GetSumDig(number);

Console.Write($"{number} -> {res}");