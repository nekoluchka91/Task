// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента 
// или сообщает, что такого элемента нет.
// 1 4 7 2   
// 5 9 2 3  
// 8 4 2 4 
// [1, 7] - элемента с данными позициями нет в массиве.

Console.WriteLine("Введите позицию i элемента: ");
Console.Write("i: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию j элемента: ");
Console.Write("j: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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

void SearchElem(int[,] matrix, int num1, int num2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num1 <= i && num2 <= j) 
            {
                Console.WriteLine($"{num1}, {num2} - Элемент с заданными позициями есть в массиве");
                return;
            }
        }
    }
    Console.WriteLine($"{num1}, {num2} - Элемента с заданными позициями нет в массиве");
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
SearchElem(matrixResult, num1, num2); 
