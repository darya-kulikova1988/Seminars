// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int n, int m)
{
    if (n > m) return n > m ? n + SumRec(m, n - 1) : n;
    else return m > n ? m + SumRec(m - 1, n) : m;
}
Console.WriteLine(SumRec(4, 8));

