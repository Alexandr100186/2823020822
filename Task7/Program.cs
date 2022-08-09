﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите 3-х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0)
{
    Console.WriteLine($"Крайняя цифра введенного числа: {a * -1 % 10}");   
}
else
{
    Console.WriteLine($"Крайняя цифра введенного числа: {a % 10}");
}