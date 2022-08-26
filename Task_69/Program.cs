// Напишите программу, которая 
// на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// А = 3, В = 5 - > 243
// А = 2, В = 3 - > 8

Console.Write("Задайте число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetPower(int num, int num2)
{
    if(num2 == 0) return 1;
    return GetPower(num, num2 - 1) * num;
}
if(number >= 0)
{
    int result = GetPower(number, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Степень должна быть натуральной");