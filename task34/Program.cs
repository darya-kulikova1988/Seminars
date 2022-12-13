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
void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
}
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = GetArray(n);
Console.Write("[");
PrintArray(array);
Console.Write("] --> ");
int count = 0;
foreach (int el in array)
{
    if (el % 2 == 0)
    {
        count++;
    }
}
Console.Write(count);