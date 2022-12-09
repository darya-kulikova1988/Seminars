// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе = {Sum(num)}");
int Sum(int number)
{
    int sum = 0;
    int num1 = 0;
    int sumTotal = 0;
    while (number > 10)
    {
        num1 = number % 10;
        sum = sum + num1;
        number = number / 10;
    }
    if (number < 10)
    { sumTotal = sum + number; }
    return sumTotal;
}


