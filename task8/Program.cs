// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Count = 2;
while (Count <= N)
{
Console.Write(Count+" ");
Count = Count+2;
}
