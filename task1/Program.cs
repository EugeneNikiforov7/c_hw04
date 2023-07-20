//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int A, int B)
{
    int result = 1;
    for (int i = 1; i<=B; i++)
    {
        result = result * A;
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numberA = GetInfo("Введите число А: ");
int numberB = GetInfo("Введите число В: ");

int res = GetDegree(numberA, numberB);

Console.Write($"{numberA}, {numberB} -> {res}");
