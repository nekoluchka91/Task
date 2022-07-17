// Напишите программу, которая принимает
// на вход трехзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехначное число: "); // 456
int numA = Convert.ToInt32(Console.ReadLine());
int numB = numA / 10; // 456 / 10 = 45
int result = numB % 10; // 45 % 10 = 5
Console.WriteLine(result);
