﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int number;

Console.WriteLine("Введите число");
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Введёное число чётное");
}
else
{
    Console.WriteLine("Введёное число нечётное");
}