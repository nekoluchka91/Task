// Напишите программу, которая 
// по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");

int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc) // метод
{
    if (xc == 1) return "x > 0, y > 0";
    if (xc == 2) return "x < 0, y > 0";
    if (xc == 3) return "x < 0, y < 0";
    if (xc == 4) return "x > 0, y < 0";
    return "введена некоректная четверть";
}

string result = Quarter(x); // вызов метода, присваиваем переменной result строковая string
Console.WriteLine(result);
