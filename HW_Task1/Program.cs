﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите число а");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");

int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число");
    Console.WriteLine(a);
    Console.WriteLine("больше");
    
}
else
{
    Console.WriteLine("Число");
    Console.WriteLine(b);
    Console.WriteLine("больше");
}

if (a == b)
{
    Console.WriteLine("Вы ввели равные числа");
}