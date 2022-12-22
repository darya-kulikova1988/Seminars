// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Split() ?
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// СПОСОБ №0!!!!
// Console.Write("Введите любое количество чисел, через пробел: ");
// string array1 = Console.ReadLine()!;
// string[] arr = array1.Split(" ");
// Count(arr);

// void Count(string[] m)
// {
//     int count = 0;
//     for (int j = 0; j < m.Length; j++)
//     {
//         if (int.Parse(m[j]) > 0) count++;
//         Console.Write(m[j] + " ");
//     }
//     Console.WriteLine($"--> Количество чисел больше нуля  = {count}");
// }

// СПОСОБ №1!!!!
// Console.Write("Введите любое количество чисел, через пробел: ");
// string array1 = Console.ReadLine()!;
// string[] arr = array1.Split(" ");
// Array(array1);
// Count(arr);
// void Array(string array1)
// {
//     int i = 0;
//     while (i < arr.Length - 1)
//     {
//         Console.Write($"{arr[i]}, ");
//         i++;
//     }
//     Console.Write(arr[i]);
// }
// void Count(string[] m)
// {
//     int count = 0;
//     for (int j = 0; j < m.Length; j++)
//     { if (int.Parse(m[j]) > 0) count++; }
//     Console.WriteLine($"--> Количество чисел больше нуля  = {count}");
// }



// Способ 2!!!

Console.Write("Введите количество символов M, содержащихся в массиве: ");
int M = int.Parse(Console.ReadLine()!);
int[] array = GetArray(M);

Console.WriteLine(string.Join(" ", array));
Console.Write($"Количество чисел больше <0> = {Count(M)}");

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

int Count(int a)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return (count);
}