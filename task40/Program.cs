// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите первую сторону треугольника = ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую сторону треугольника = ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью сторону треугольника = ");
int num3 = int.Parse(Console.ReadLine()!);
Triangle(num1, num2, num3);

void Triangle(int A, int B, int C)
{
    if (A < B + C & B < A + C & C < A + B)
    {
        Console.WriteLine("Треугольник существует");
    }
    else
    {
        Console.WriteLine("Треугольника не существует");
    }
}