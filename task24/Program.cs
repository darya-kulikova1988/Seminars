// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");

Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел = {GetSumNums(num1)}");

Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел = {GetSumNums(num2)}");

int GetSumNums(int number)  // называем метод по смыслу, все методы с Большой Буквы, а переменные с маленькой
{
    int sum = 0;
    while (number > 0)
    {
        Console.Write($"{number} ");
        sum += number; // sum = sum+number
        number--;
    }
    return sum; // обязательно возвращаем сумму, так как метод возвратный
}