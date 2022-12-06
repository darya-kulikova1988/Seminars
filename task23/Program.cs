// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int B = 1;
while (B <= N)
{
    if (B == N)
    { Console.Write(B * B * B + "."); }
    else
    {
        Console.Write(B * B * B + ", ");
    }
    B++;
}