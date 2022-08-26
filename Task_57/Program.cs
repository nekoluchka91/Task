// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.

// 1, 2, 3   1 встречается 3 раза
// 4, 6, 1   2 встречается 2 раза
// 2, 1, 6   3 встречается 1 раз
//           4 встречается 1 раз
//           6 встречается 2 раза

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


int[] ConversionArray(int[,] array) //переводим двумер массив в одномерный
{
    int[] arrayNew = new int [array.Length];
    int m = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayNew[m] = array[i, j];
            m++;
        }
    }
    Array.Sort(arrayNew);
    return arrayNew;
}


void WriteDigitCountToConsole(int[] arrayNew)
{
    int number = arrayNew[0];
    int count = 0;
    for (int i = 0; i < arrayNew.Length; i++)
    {
        if (arrayNew[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} - {count} раз");
            number = arrayNew[i];
            count = 1;
        }
        if (i == arrayNew.Length - 1)
        Console.WriteLine($"Число {number} - {count} раз");
    }
}

int [,] matrixResult = GetMatrix(3, 3);
PrintMatrix(matrixResult);

int[] arrayNew = ConversionArray(matrixResult);
WriteDigitCountToConsole(arrayNew);