// Напишите цикл, который принимает на вход два числа (А и В) и
// возводит число А в натуральную степень В.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 (2⁴)

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число a в степени b = " + Math.Pow(a, b));