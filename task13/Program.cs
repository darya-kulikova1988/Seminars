// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int n = 10;
int count = 0;
while (a > 0)
    {
    a = a/n; 
    count++;
    }
Console.WriteLine(count);

// Console.WriteLine("Третья цифра: " + a%n);
// while ((a/(n*10)) > n/10 & (a/(n*10)<n))
//    {
//     if ((a/(n*10)) > n/10 & (a/(n*10)<n))    //526855 n=10  n=100 n=1000
//     {
//         Console.WriteLine("Третья цифра: " + a%n);
//     }
//     else
//     {

//     }
//   n = n * 10;}
 

// int sqrt_n = n*n;
// if (a/(sqrt_n) > n/n & a/sqrt_n < n)
// {
//     Console.WriteLine("Третья цифра: " + a%n);
// }

// не универсальное решение
// if (a/100 >1 & a/100 <10)
// {
//     Console.WriteLine("Третья цифра: " + a%10);
// }
// if (a/100 <1)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// if (a/100 >10 & a/100 <100)
// {
//     Console.WriteLine("Третья цифра: " + a%100/10);
// }
// if (a/100 >100 & a/100 <1000)
// {
//     Console.WriteLine("Третья цифра: " + a%1000/100);
// }