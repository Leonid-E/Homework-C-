﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число для проверки: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine ("Это чётное число");
else Console.WriteLine ("Это нечётное число");
