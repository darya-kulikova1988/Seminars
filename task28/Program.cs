// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел = {GetMultiNums(num)}");

int GetMultiNums(int number)  // называем метод по смыслу, все методы с Большой Буквы, а переменные с маленькой
{
    int multi = 1;
    while (number > 0)
    {
        Console.Write($"{number} ");
        multi *= number; // sum = sum+number
        number--;
    }
    return multi; // обязательно возвращаем сумму, так как метод возвратный
}