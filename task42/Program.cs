// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число в десятичной системе счисления = ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Число <{N}> в двоичной системе: <{Binary(N)}>");

string Binary(int a)
{
    string c = string.Empty;
    while (a > 0)
    {
        c = a % 2 + c;
        a = a / 2;
    }
    return c;
}