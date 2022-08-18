﻿// Задайте двумерный массив размера m x n, 
// каждый элемент в массиве находится по формуле: Amn = m + n.
// Выведите полученный массив на экран. 
// m = 3, n = 4



int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            if (j < array.GetLength(1) -1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i, j], 3}]");
        }
        Console.WriteLine();
    }
}

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);