// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void GetNewMatrix(int[,] matrix) // метод сортировки массива. Лекция 3 (продолжение)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = 0; t < matrix.GetLength(1) - 1; t++)
            {
                int maxNum = matrix[i, t];
                if (matrix[i, t] < matrix[i, t + 1])
                {
                    int temp = matrix[i, t + 1];
                    matrix[i, t + 1] = matrix[i, t];
                    matrix[i, t] = temp;
                    maxNum = matrix[i, t];
                }
            }
        }

    }
}

int[,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
Console.WriteLine();
GetNewMatrix(matrixResult);
PrintMatrix(matrixResult);