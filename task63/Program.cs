//Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные
// числа в промежутке от 1 до N.


// string NumbersRec(int a, int b)
// {
//     if (a < b + 1) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(NumbersRec(1, N));

// void LineNumbers(int n)
// {
//     if (n != 1) LineNumbers(n - 1);
//     Console.Write($"{n} ");
// }
// LineNumbers(5);

string LineNumbers2(int n)
{
    return (n >= 2) ? LineNumbers2(n - 1) + $" {n}" : "1";
}
LineNumbers2(5);