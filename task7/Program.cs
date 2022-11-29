// Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int ABC = int.Parse(Console.ReadLine());
int result = ABC%10;
// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int C = int.Parse(Console.ReadLine());
Console.WriteLine(result);