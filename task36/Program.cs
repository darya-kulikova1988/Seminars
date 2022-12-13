// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = GetArray(n);
PrintArray(array);
Console.Write(" --> Cумма элементов, стоящих на нечётных позициях = ");
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) sum = sum + array[i];
}
Console.Write(sum);