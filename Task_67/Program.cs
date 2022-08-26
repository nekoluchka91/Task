// Напишите программу, которая будет
// принимать на вход число и
// возвращать сумму его цифр.
// 453 - > 12
// 45 - > 9

int m = InputNumbers("Задайте число: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int sum = 0;
int Sum (int n, int sum)
{
    if(n == 0) return sum;
    sum += n % 10;
    return Sum(n / 10, sum); // рекурсия
}

int c = Sum(m, 0);
Console.WriteLine(c);

