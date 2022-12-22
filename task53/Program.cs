// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку.


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int k = inArray[0, j];
            if (i == 0) { Console.Write(inArray[inArray.GetLength(0) - 1, j] + " "); }
            else if (i == inArray.GetLength(0) - 1) { Console.Write(k + " "); }
            else
            {
                Console.Write(inArray[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, colomns, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);