// Напишите программу, которая принимает 
// на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// пятизначное число 12821
// номер элемента    01234

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remainder; // remaider - остаток
int temp = num;
int sum = 0;
while (num > 0) // цикл, пока число больше 0
{ 
    remainder = num % 10; // ищем остаток (после запятой)
    sum = sum * 10 + remainder; // умножаем sum на 10 и добавляем остаток
    num = num / 10; // ищем частное от деление (до запятой)
}
if (temp == sum)
{
    Console.WriteLine($"Данное число является палиндромом.");
}
else
{
    Console.WriteLine($"Данное число не является палиндромом.");
}



// void Check(num collection);
// {
//     if (num[0] == num[4] || num[1] == num[3]) "Введенное число является палиндромом.";
//     return "Введенное число не является палиндромом.";
// }

// result = Check(num[index]collection);
// Console.WriteLine(result);

