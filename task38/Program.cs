// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// (попрактиковать next double)
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

Console.Write($" -> Разница между максимальным и минимальным элементами массива = {SumMaxMin(5)}");

int SumMaxMin(int i)
{
    int max = array[0];
    int min = array[0];

    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    int result = max - min;
    return result;
}


// int max = array[0];
// int min = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max) max = array[i];
//     else if (array[i] < min) min = array[i];
// }
// int result = max - min;
// Console.Write(result);
// // Console.Write($" {max} {min}");