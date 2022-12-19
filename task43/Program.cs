﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1 = ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k1 = ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2 = ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите k2 = ");
double k2 = double.Parse(Console.ReadLine()!);
Point(b1, k1, b2, k2);

void Point(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, точек пересечения нет");
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        y = (k1 * b2 - k2 * b1) / (k1 - k2);
        x = (y - b2) / k2;
        Console.WriteLine($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}
// Console.WriteLine(Math.Round((decimal)x, 2));




