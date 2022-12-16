// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Split() ?
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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