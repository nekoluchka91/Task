// Задайте двумернйы массив.
// Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.
// Например,
// 1 4 7 2       1  4 7 2
// 5 9 2 3  ->   5  9 2 3
// 8 4 2 4       64 4 8 4

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

int[,] GetNewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix [i, j];
        }
    }
    return matrix;
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
Console.WriteLine();
int[,] newMatrix = GetNewMatrix(matrixResult);
PrintMatrix(newMatrix);
