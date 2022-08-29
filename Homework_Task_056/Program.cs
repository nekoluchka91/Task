// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

int[,] GetMatrix(int m, int n) //задаем двум массив
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

// метод печати на экран двумерного массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int [] GetString (int[,] matrix)
{
    int [] newArray = new int [matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            newArray[i] = sum;
        }
    }
    sum = 0;
    return newArray;
}

void SearchMinElement (int[] array)
{
    int index = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (index > array[i])
        {
            index = array[i];
            int minElem = index;
            count = i + 1;
        }
    }
    if (count == 0)
    {
        count++;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке - > {count}");
}

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
Console.WriteLine();
int[] result = GetString(matrixResult);
SearchMinElement(result);