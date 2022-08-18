// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали.
// С индексами (0,0), (1,1), (2,2).
// Напр.,
// 1 4 7 2
// 5 9 2 3  -> (0,0) 1 + (1,1) 9 + (2,2) 2 = 12.
// 8 4 2 4

int[,] GetMatrix(int m, int n)
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

int GetSumElem(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix [i, j];
        }
    }
    return sum;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) -1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
int result = GetSumElem(matrixResult); 
Console.WriteLine($"Сумма элементов главной диагонали равна {result}");