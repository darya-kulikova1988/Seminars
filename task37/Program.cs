// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = GetArray(n);
Console.Write("[");
PrintArray(array);
Console.Write("] --> ");
Console.Write("[");

int i = 0;
int j = array.Length - 1;
int c = 1;
int b = array.Length / 2;
if (array.Length % 2 == 0)
{
    while (i < array.Length / 2)
    {
        c = array[i] * array[j];
        i++;
        j--;
        Console.Write(c + " ");
    }
}
else
{
    while (i < array.Length / 2)
    {
        c = array[i] * array[j];
        i++;
        j--;
        Console.Write(c + " ");
    }
    Console.Write(array[b]);

}
Console.Write("]");
