// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int i = 0;
int n = number.Length;
int count = 0;
while (i < n)
{
    if (number[i] == number[n - i - 1])
    {
        count++;
        i++;
        if (count == n)
        { Console.WriteLine($"Да, число <{number}> является палиндромом"); }
    }
    else
    {
        Console.WriteLine($"Нет, число <{number}> не является палиндромом");
        break;
    }
}