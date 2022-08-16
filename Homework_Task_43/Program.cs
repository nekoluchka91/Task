// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x + b1 = k2*x + b2; x*(k1-k2) = b2-b1; x=(b2-b1)/(k1-k2);
// x=(4-2)/(5-9)=2/(-4)=-1/2=-0,5;
// y=5*(-0,5)+2=(-2,5)+2=-0,5;
// x = -0,5; y = -0,5;

Console.WriteLine("Введите значение b");
Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k");
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
Console.WriteLine($"Точка пересечения двух прямых -> {x}, {k1 * x + b1}");