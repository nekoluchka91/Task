// Напишите программу замены элементов массива:
// положительные элементы заменить на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; // int[] arr - создали массив
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)//начинаем перебирать с индекса 0
    {
        arr[i] = rnd.Next(min, max + 1);//min = -9, max = 9, но увеличиваем на +1 (т.е. 10), так как 9 не будет входить в ином случае в наш диапазон
    }
    return arr;
} 

void GetRevers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
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

int[] array = CreateArrayRndInt(4, -100, 100); //4 элемента массива, диапазон какой захотим
PrintArray(array); 
GetRevers(array);
Console.WriteLine();
PrintArray(array); 

