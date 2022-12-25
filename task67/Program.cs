// Задача 67: Напишите программу, которая будет принимать на
//  вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfChar(int A)
{
    if (A > 0)
    {
        return A = A % 10 + SumOfChar(A / 10);
    }
    else
    {
        return 0;
    }
}
Console.Write(543 + "-->" + SumOfChar(543));