// Напишите программу, которая выводит
// массив из 8 элементов, заполненный
// нулями и едициницами в случайном порядке.
// [0, 1, 1, 1, 0, 0, 1, 0]

int [] array = new int [8];
int rndNum = new Random().Next(0, 2);
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0, 2);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array [i] + " ");
}