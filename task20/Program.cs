// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату X точки A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки A: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату X точки B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки B: ");
int yb = int.Parse(Console.ReadLine()!);
double hypotenuse = (double)Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
Console.WriteLine("Расстояние между точками = " + Math.Round(hypotenuse, 2));
// AB = квадратный корень ((xb-xa) + (yb-ya))