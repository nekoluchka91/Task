// Напишите программу, которая 
// принимает на вход число и 
// проверяет, кратно ли оно одноременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"{num1} -> да");
else Console.WriteLine($"{num1} -> нет");