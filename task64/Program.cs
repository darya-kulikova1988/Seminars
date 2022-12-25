// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string NumbersRec(int a, int b)
{
    if (a > b - 1) return $"{a} " + NumbersRec(a - 1, b);
    else return String.Empty;
}
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumbersRec(N, 1));