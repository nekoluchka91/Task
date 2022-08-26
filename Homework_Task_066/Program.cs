// Задача 66.
// Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных
// элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 4, N = 8 -> 4+5+6+7+8=30

Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void GetSumDigit(int m, int n, int sum) 
{
    if(m > n) 
    {
        Console.WriteLine($"Сумма чисел от {m} до {n} = {sum}");
        return;
    }
    sum = sum + m;
    m++;
    GetSumDigit(m, n, sum); 
}

GetSumDigit(m, n, 0); 


