// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10, 99].

// Пример на 5 элементах:
// [5, 18, 123, 6, 2] -> 1
// [10, 11, 12, 13, 14] -> 5

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

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int GetSumCount (int [] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max + 1)
        count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(123, 10, 100); 
PrintArray(array);
Console.WriteLine();
int count = GetSumCount(array, 10, 99); 
Console.WriteLine($"Количество элементов в заданном отрезке -> {count}");