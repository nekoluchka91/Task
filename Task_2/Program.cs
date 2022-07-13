// Напишите программу, 
// которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.Write("Введите номер дня недели: ");
int day_week = Convert.ToInt32(Console.ReadLine());

if (day_week == 1) 
{
Console.WriteLine("Monday");
} 
else if (day_week == 2) 
{
Console.WriteLine("Tuesday"); 
} 
else if (day_week == 3) 
{
Console.WriteLine("Wednesday");
} 
else if (day_week == 4) 
{
Console.WriteLine("Thursday");
} 
else if (day_week == 5) 
{
Console.WriteLine("Friday");
} 
else if (day_week == 6) 
{
Console.WriteLine("Saturday");
} 
else if (day_week == 7) 
{
Console.WriteLine("Sunday");
} 
else 
{
    Console.WriteLine("Error");
}  