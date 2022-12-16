// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// f(n) = f(n-1) + f(n-2);

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Числа Фибоначчи: ");
Fibonachi(N);

void Fibonachi(int n)
{
    int a = 0;
    int b = 1;
    int c;
    for (int i = 0; i < n; i++)
    {
        c = a;
        a = b;
        b = b + c;
        Console.Write(c);
    }
}
