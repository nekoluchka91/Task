// 0. Демонстрация решения
// Напишите программу, 
// 1. которая на вход
// принимает число и 
// 2. выдает его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49 

Console.Clear();
string str = "Привет!";

Console.Write("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
// int num = 4;
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");
