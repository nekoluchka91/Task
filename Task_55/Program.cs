// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 3},");
            else Console.Write($"{matrix[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int [,] NewArray(int[,] matrixResult) //заменяет строки на столбцы
{
    int[,] matrixNew = new int[matrixResult.GetLength(0), matrixResult.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            matrixNew[i, j] = matrixResult[j, i];
        }
    }
    return matrixNew;
}

int [,] matrixResult = GetMatrix(3, 3);
PrintMatrix(matrixResult);
Console.WriteLine();
if(matrixResult.GetLength(0) != matrixResult.GetLength(1)) Console.WriteLine("Невозожно выполнить");
else
{
    int[,] newMatrix = NewArray(matrixResult);
    PrintMatrix(newMatrix);
}

