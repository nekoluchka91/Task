// Напишите программу, которая принимает на вход число и 
// выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 123456 -> 6

Console.WriteLine("Введите число: ");
int a =Convert.ToInt32(Console.ReadLine());

int GetCountNum(int numb)
{
    int index = 1;
    int x = 0;
    while (index <= numb)
    {
        x++;
        index = index * 10; //с кажд разом увеличиваем на 1 разряд, проверяем, пока не больше условия
    }
    return x;
}
int res = GetCountNum(a);
Console.WriteLine($"Количество цифр в заданном числе = {res}");