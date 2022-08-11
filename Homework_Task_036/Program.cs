// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
//  0  1  2   3   -> [1]+[3]
// [3, 7, 23, 12] -> 19
//   0   1  2   3   -> [1]+[3]
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int [] GetSum (int [] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
        sum += array[i];
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}


int[] array = CreateArrayRndInt(4, -10, 10); 
PrintArray(array); 
int[] sum = GetSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях -> {sum[1]}");
