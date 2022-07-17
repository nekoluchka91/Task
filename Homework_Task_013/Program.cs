// Напишите программу, которая 
// выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите любое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (numA > 1000)
{
    numA / 10;
    return numA;
}
int res = numA % 10;
Console.WriteLine($"Третья цифра заданного числа");

if (numA < 100)
    Console.WriteLine($"Третьей цифры заданного числа не существует");

if (numA < 1000)
{
    int numA = numA % 10;
}
Console.WriteLine($"Третья цифра заданного числа");






// int num = new Random();
// int result = PrintThirdDigit(num);
// Console.WriteLine($"{num} -> {result}");

// //int PrintThirdDigit = int(num)
// while (num > 1000);
// {
//     num / 10;
//     intB = num % 10;
//     return num;
// }
// if (numA < 100;
//     return "Третьей цифры нет";

// result = PrintThirdDigit();
// Console.WriteLine(result);