// Напишите программу, которая будет
// принимать на вход два числа и
// выводить, является ли второе число кратным первому.
// Если второе число не кратно первому, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;

if (result == 0) ;
Console.WriteLine($"{num1}, {num2} -> кратно");
else
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, {result}");
}