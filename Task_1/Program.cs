// Напишите программу, которая 
// на вход принимает два целых числа и 
// проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -3 -> yes
// a = -3, b = 9 -> no

Console.WriteLine("Введите первое целое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

int res = num_2 * num_2;
if (res == num_1)
{
Console.WriteLine("Yes");
}
else 
{
Console.WriteLine("No");
}