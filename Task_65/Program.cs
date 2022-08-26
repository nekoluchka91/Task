// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числав промежутке от M до N.
// M = 1, N = 5 -> 1, 2, 3, 4, 5
// M = 4, N = 8 -> 4, 5, 6, 7, 8

Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());


void WriteNaturalNum(int m, int n) 
{
    if(m > n) return;  
    Console.Write($"{m} "); 
    WriteNaturalNum(++m, n);
}

Console.Write($"M = {m}, N = {n} -> ");
WriteNaturalNum(m, n);