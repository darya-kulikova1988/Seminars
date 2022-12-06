// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number / 1000 == number % 10 * 10 + number / 1000 % 10)
{
    Console.WriteLine($"Да, число <{number}> является палиндромом");
}
else
{
    Console.WriteLine($"Нет, число <{number}> не является палиндромом");
}

// Console.WriteLine(number / 1000);
// Console.WriteLine(number % 10 * 10);
// Console.WriteLine(number / 1000 % 10);

// Другой способ, более примитивный:

// Console.WriteLine("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int a1 = (number % 100000 / 10000);
// // Console.WriteLine(a1);
// int a2 = (number % 10000 / 1000);
// // Console.WriteLine(a2);
// int a4 = (number % 100 / 10);
// // Console.WriteLine(a4);
// int a5 = (number % 10);
// // Console.WriteLine(a5);
// if (a1 == a5 & a2 == a4)
// {
//     Console.WriteLine($"Да, число <{number}> является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Нет, число <{number}> не является палиндромом");
// }

// Решение через строку
// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// int i = 0;
// int n = number.Length;
// int count = 0;
// while (i < n)
// {
//     if (number[i] == number[n - i - 1])
//     {
//         count++;
//         i++;
//         if (count == n)
//         { Console.WriteLine($"Да, число <{number}> является палиндромом"); }
//     }
//     else
//     {
//         Console.WriteLine($"Нет, число <{number}> не является палиндромом");
//         break;
//     }
// }

