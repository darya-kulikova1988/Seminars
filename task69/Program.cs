﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

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