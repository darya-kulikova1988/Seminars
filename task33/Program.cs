// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size) // int [] - описание метода
{
    int[] res = new int[size];  // инициализация массива 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-10, 11);
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
int[] array = GetArray(5);
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

PrintArray(array);
int i = 0;
int count = 0;
while (i < array.Length)
{
    if (A == array[i])
    {
        count++;
    }
    i++;
}
if (count == 0)
{
    Console.Write("Нет");
}
else
{
    Console.Write("Да");
}


