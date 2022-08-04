// Напишите программу, которая на вход принимает число N и 
// выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetDigit(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count = count * i;
    }
    return count;
}
int res = GetDigit(n);
Console.WriteLine($"{n} -> {res}");