﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7) Console.WriteLine("Выходой день");
else if(num > 7 || num < 1) Console.WriteLine ("Такого дня нет");
else Console.WriteLine("Рабочий день");
