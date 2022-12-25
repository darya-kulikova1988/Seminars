// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

// void LineNumbers(int n, int m)     // разобраться как работает!!!!
// {
//     if (n != m) LineNumbers(n - m);
//     Console.Write($"{n} ");
// }
// LineNumbers(5, 3);

// string NumbersRec(int a, int b)
// {
//     if (a < b + 1) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(3, 8));

// string LineNumbers2(int n, int m)   // разобраться как работает!!!!
// {
//     return (n >= m + 1) ? LineNumbers2(n - 1) + $" {n}" : "{m}";
// }
// LineNumbers2(5, 2);


void NumbersRec2(int m, int n)
{
    if (m < n) NumbersRec2(m, n - 1);
    Console.Write($"{n} ");
    if (m > n) NumbersRec2(m, n + 1);

    // return (m > n) ? NumbersRec2(m - 1, n) : NumbersRec2(m, n - 1);
}

NumbersRec2(10, 1);