// task13

// Console.Write("Введите число: ");
// int a = Math.Abs(int.Parse(Console.ReadLine()!));
// int count = 0;
// int a1 = a;
// while (a1 != 0)
// {
//     a1 = a1 / 10;
//     count++;
// }
// if (count < 3)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     int rang = (int)Math.Pow(10, count - 3);
//     int result = a / rang % 10;
//     Console.WriteLine("Третья цифра: " + result);
// }

// Число превращается в строку

Console.Write("Введите число: ");
int a = Math.Abs(int.Parse(Console.ReadLine()!));
string aString = a.ToString();
if (aString.Length >= 3)
{
    Console.WriteLine(aString[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}