//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = GetArray(5, 0, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
int[] reverseArray = ReverseArray2(array);
// ReverseArray1(array);
Console.WriteLine(string.Join(" ", reverseArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] ReverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}