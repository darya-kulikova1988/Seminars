// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result1=a%7;
int result2=a%23;
if (result1 == 0 & result2 == 0)
{
    Console.WriteLine("Да, кратно");
}
else
{
    Console.WriteLine("Нет, не кратно"); 
}