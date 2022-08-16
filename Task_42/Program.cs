// Напишите программу, которая будет преобразовывать дестичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string Result (int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res += num % 2; //оставляем остаток от деления на 2
        num /= 2; //делим число на 2
    }
    return res;
}

void PrintString(string result)
{
    for (int i = result.Length - 1; i >= 0; i--)
    {
        Console.Write(result[i]);
    }
}

string res = Result(num);
PrintString(res);