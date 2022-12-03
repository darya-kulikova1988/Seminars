// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 0;
int a1 = a;
while (a1 != 0)
    {
    a1 = a1/10; 
    count++;
    }
// Console.WriteLine("Счетчик равен " + count);
int result = (int)(a %(Math.Pow(10,(-2+count)))/(Math.Pow(10,(-3+count))));
if (count < 3)
{
   Console.WriteLine("Третьей цифры нет");
}
else if (count > 2)
{
    if (result < 0)
    {
        result = result * -1;
    }    
Console.WriteLine("Третья цифра: " + result);
}


// __________________________________________________________________________________
// ОСТАВИЛА ЗДЕСЬ ДЛЯ СРАВНЕНИЯ

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// int count = int.Parse(Console.ReadLine()!);
// int b = Convert.ToInt32(Math.Pow(10,(-2+count)));
// int c = Convert.ToInt32(Math.Pow(10,(-3+count)));
// int result = a%b/c;
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine("Третья цифра: " + result);

// Работает, но иногда дает сбой, показывает 2 цифру или 4

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = 10;
// int count = 0;
// int a1 = a;
// while (a1 != 0)
//     {
//     a1 = a1/n; 
//     count++;
//     }
// Console.WriteLine("Счетчик равен " + count);
// int result = Convert.ToInt32(a%(Math.Pow(n,(-2+count)))/Math.Pow(n,(-3+count)));
// if (count < 3)
// {
//    Console.WriteLine("Третьей цифры нет");
// }
// else if (count > 2)
// {
//     if (result < 0)
//     {
//         result = result * -1;
//     }    
// Console.WriteLine("Третья цифра: " + result);
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