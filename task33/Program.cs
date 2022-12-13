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
    Console.Write(" --> Нет");
}
else
{
    Console.Write(" --> Да");
}



