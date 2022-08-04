// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    while (n > 0)
    {
    number = n % 10;
    n = n / 10;
    sum = sum + number;
}
return sum;
}
int res = GetSum(n);
Console.WriteLine($"Сумма цифр в заданном числе = {res}");