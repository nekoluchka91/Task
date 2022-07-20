// Напишите программу, которая принимает
// на вход число (N) и
// выдает таблицу квадратов чисел от 1 до N.
// 5 - > 1, 4, 9, 16, 25
// 2 - > 1, 4

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

WriteSquareTable(n);

void WriteSquareTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($"| {i} | {i * i, 3} |");
        i++;
    }
}