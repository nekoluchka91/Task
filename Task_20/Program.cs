// Напишите программу, которая принимает
// на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// формула расчета расстояния от точки до точки и извлекаем квадратный корень из этого
// double - вещественные (дробные) числа
Console.WriteLine(Math.Round(result,2)); // 2 - оставляем два знака после запятой с функцией округления