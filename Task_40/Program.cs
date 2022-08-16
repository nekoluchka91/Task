// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать трегуольник со сторнами такой длины.
// !!! Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
// двух других сторон.

int first = GetUserInput();
int second = GetUserInput();
int third = GetUserInput();

if (IsRectangle(first, second, third))
    Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} может существовать");
else
    Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} НЕ может существовать");

bool IsRectangle(int first, int second, int third)
{
    if (first < second + third && second < first + third && third < first + second)
        return true;
    return false;
}

int GetUserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}