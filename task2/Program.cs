// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите первое число от 1 до 7: ");
int A = int.Parse(Console.ReadLine());

if(A == 1)
{Console.WriteLine("Понедельник");}

if(A == 2)
{Console.WriteLine("Вторник");}

if(A == 3)
{Console.WriteLine("Среда");}

if(A == 4)
{Console.WriteLine("Четверг");}

if(A == 5)
{Console.WriteLine("Пятница");}

if(A == 6)
{Console.WriteLine("Суббота");}

if(A == 7)
{Console.WriteLine("Воскресенье");}

// if(int 2 == "Вторник");
// if(int 3 == "Среда");
// if(int 4 == "Четверг");
// if(int 5 == "Пятница");
// if(int 6 == "Суббота");
// if(int 7 == "Воскресенье");
