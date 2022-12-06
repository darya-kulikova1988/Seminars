// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X точки A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки A: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки A: ");
int za = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату X точки B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки B: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки B: ");
int zb = int.Parse(Console.ReadLine()!);
double hypotenuse = (double)Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
Console.WriteLine("Расстояние между точками = " + Math.Round(hypotenuse, 2));