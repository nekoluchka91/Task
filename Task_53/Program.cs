// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю
// строки массива.

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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i]; // во вр переменную temp  записали значение столбика
        array[0, i] = array[array.GetLength(0) - 1, i]; // это зна-е приравниваем последнему столбику массива
        array[array.GetLength(0) - 1, i] = temp; // это знач-е записываем во вр перем, чтобы пойти по кругу
    }
}

int [,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
Console.WriteLine();
SortArray(matrixResult);
PrintMatrix(matrixResult);