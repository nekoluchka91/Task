// Напишите программу, которая принимает 
// на вход число (А) и
// выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// for (int i = 1; i <= num; i ++)
// {
//     sum = sum + i; //0+1=1, затем 1(нов знач sum) +1 (i)=2, затем 2+1=3, 3+1=4, 4+1  и тд пока не дойдем до числа num
// }
// Console.WriteLine($"Сумма числе от 1 до {num} = {sum}");


// МЕТОД
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i; 
    }
    return sum;
}
int result = GetSum(num);
Console.WriteLine($"Сумма числе от 1 до {num} = {result}");