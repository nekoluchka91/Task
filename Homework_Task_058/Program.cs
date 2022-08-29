// Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.

int[,] MatrixFirst(int m, int n)
{
    int[,] MatrixFirst = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            matrixFirst[i, j] = rnd.Next(1, 10);
        }
    }
    return matrixFirst;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int[,] MatrixSecond(int n, int z)
{
    int[,] matrixSecond = new int[n, z];
    Random rnd = new Random();
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            matrixSecond[i, j] = rnd.Next(1, 10);
        }
    }
    return matrixSecond;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int[,] MatrixFirstSecond(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixFirstSecond = new int[matrixFirst.GetLength(1), matrixSecond.GetLength(0)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int y = 0; y < matrixSecond.GetLength(0); y++)
                {
                    matrixFirstSecond[i, j] = matrixFirst[i, j] * matrixSecond[y, j];
                }
        }
    }
    return matrixFirstSecond;
}

int[,] matrixFirst = MatrixFirst(3, 3);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = MatrixSecond(3, 3);
PrintMatrix(matrixtSecond);
Console.WriteLine();
int[,] matrixFirstSecond = MatrixFirstSecond(matrixFirst, matrixSecond);
PrintMatrix(matrixFirstSecond);