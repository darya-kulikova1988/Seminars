// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int[] GetArray(int size) // int [] - описание метода
{
    int[] res = new int[size];  // инициализация массива 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == count - 1) { Console.Write(col[position] + "]"); }
        else if (position == 0) { Console.Write("[" + col[position] + ", "); }
        else
        {
            Console.Write(col[position] + ", ");
        }
        position++;
    }
}
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = GetArray(n);

PrintArray(array);
Console.Write($" --> {CountChar(n)}");

int CountChar(int m)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
// Console.Write(count);

