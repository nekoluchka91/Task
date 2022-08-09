// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4: массив [6, 7, 19, 345, 3] -> нет
// 3: массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
} 

void Elem (int [] array, int search)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == search)
        {
            Console.WriteLine($"Число {search} есть в массиве");
            return;
        }
    }
Console.WriteLine($"Числа {search} нет в массиве");
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(6, 0, 11); 
PrintArray(array);
Console.WriteLine();
Elem(array, num); 
