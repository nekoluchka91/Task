// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце
// 1     4     7     2
// 5     9     2     3
// 8     4     2     4
// ср.арифм.кажд.столбца
// 4,6  5,6   3,6    3

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

void GetAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average += matrix[i, j];
        }
        double result = average/matrix.GetLength(0);
        result = Math.Round(result, 1);
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {result}");
    }
}  

int [,] matrixResult = GetMatrix(3, 4);
PrintMatrix(matrixResult);
Console.WriteLine();
GetAverage(matrixResult);