// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
    //int length = array.Length;
    //Console.Write("[");
    // for (int i = 0; i < length-1; i++)
    // {
    //     Console.Write($"{array[i]}, ");
    // }
    // Console.Write($"{array[length-1]}]");
    Console.Write("[" + string.Join(", ", array) + "]");
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
        Console.Write(arr[i] + " ");
    }
    Console.Write("-> ");
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetInfo("Введите размерность массива: ");
int[] arr = new int[number];
FillArray(arr);
PrintArray(arr);