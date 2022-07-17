// 11. Напишите программу, которая 
// выводит случайное трехзначное число и
// удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);

// //int DeleteSecond (int number)
// {
//     int a = num / 100; // 456 - > 4

//     int b = num % 10; // 456 - > 6
//     int res = a * 10 + b;
//     Console.WriteLine($"{num} -> {res}");
// }

int num = new Random().Next(100, 1000);
int result = RemoveSecond(num);
Console.WriteLine($"{num} -> {result}");

int RemoveSecond(int num)
{
    int first = num / 100;
    int third = num % 10;
    return first * 10 + third;
}