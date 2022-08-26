// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5


Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num) //5 4 3 2 1
{
    if(num == 0) return; //когда дойдем от N до 0, выходим 
    NaturalNumber(num - 1); // идем от N до 0
    Console.Write($"{num} "); // чтобы перевернуть ответ и олучить числа от 0 до N, а не наоборот
}

NaturalNumber(number);