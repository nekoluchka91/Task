﻿// Напишите программу, которая 
// на входе принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 2 -> -2, -1, 0, 1, 2

Console.Write ("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (n<0)
{
    i = n;
    n = n * -1;
}
else
{
    i = -n;
}
while (i<=n)
{
    Console.Write(i);
    i = i + 1;
}