﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(int[] collection) // void - метод ничего не возвращает
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 50);
        index++;
    }
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

int[] array = new int[5];

FillArray(array);
PrintArray(array);



Console.Write(" -> ");