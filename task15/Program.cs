﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine()!);

if (a==1) {Console.Write("Понедельник, нет, не выходной");}

if (a==2) {Console.Write("Вторник, нет, не выходной");}

if (a==3) {Console.Write("Среда, нет, не выходной");}

if (a==4) {Console.Write("Четверг, нет, не выходной");}

if (a==5) {Console.Write("Пятница, нет, не выходной");}

if (a==6) {Console.Write("Суббота, да, выходной");}

if (a==7) {Console.Write("Воскресенье, да, выходной");}

if (a>7 || a<1) {Console.Write("Введены некорректные данные");}