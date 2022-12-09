// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A в степени B = {GetDegree(A, B)}");

int GetDegree(int numA, int numB)
{
    int degree = 1;
    degree = (int)Math.Pow(numA, numB);
    return degree;
}


// решение не методом
// int degree = (int)Math.Pow(A, B);
// Console.WriteLine(degree);

