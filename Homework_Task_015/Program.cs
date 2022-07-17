// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 1)
{
    Console.WriteLine("Понедельник. Не является выходным днем");
}
else if (dayWeek == 2)
{
    Console.WriteLine("Вторник. Не является выходным днем");
} 
else if (dayWeek == 3)
{
    Console.WriteLine("Среда. Не является выходным днем");
} 
else if (dayWeek == 4)
{
    Console.WriteLine("Четверг. Не является выходным днем");
} 
else if (dayWeek == 5)
{
    Console.WriteLine("Пятница. Не является выходным днем");
} 
else if (dayWeek == 6)
{
    Console.WriteLine("Суббота. Выходной день");
} 
else if (dayWeek == 7)
{
    Console.WriteLine("Воскресенье. Выходной день");
} 
else
{
Console.WriteLine("Введена некорректная цифра");
}