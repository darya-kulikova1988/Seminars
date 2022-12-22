// Составить частотный словарь элементов двумерного массива.
// частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных 
// {1,9,9,0,2,8,0,9} 0 встречается 2 раза, 1 встречается 1 раз и тд

using System.Linq;

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

int[] SortArray(int[,] inArray)
{
    int[] k = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int z = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            k[z] = inArray[i, j];
            Console.Write(k[z]);
            z++;
        }
    }
    Array.Sort(k);
    Console.WriteLine();
    for (int i = 0; i < k.Length; i++)
    {
        Console.Write(k[i]);
    }
    return k;
}

void Dictionary(int[] arr)
{
    Console.WriteLine();
    int count = 1;
    int i = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (i == arr[j])
        { count++; }
        else
        {
            Console.WriteLine($"{i} встречается {count} раз");
            i = arr[j];
            count = 1;
        }
    }
    Console.WriteLine($"{i} встречается {count} раз");
}
// for (int m = 0; m < arr.Length - 1; m++)
// {
//     int minPosition = m;
//     for (int n = m + 1; n < arr.Length; n++)
//     {
//         if (arr[n] < arr[minPosition]) minPosition = n;
//     }
//     char buf = arr[m];
//     arr[m] = arr[minPosition];
//     arr[minPosition] = buf;
// }
// Console.Write($"{arr}");

// for (int l = 0; l < arr.Length; l++)
// {
//     int count = 0;
//     int d = arr[l];
//     while (d == arr[l])
//     {
//         count++;
//     }
//     Console.WriteLine($"{arr[l]} встречается {count} раз");
// }


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colomns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, colomns, 0, 10);
PrintArray(array);
Console.WriteLine();
Dictionary(SortArray(array));



