// Напишите программу, которая перевернет одномерный массив.
// [1 2 3 4 5] -> [5 4 3 2 1]

void Reverse (int[] array)
{
    int size = array.Length;
    int index1 = 0; //первый эл-т массива
    int index2 = size - 1; // последний эл-т массива

    while (index1 < index2)
    {
        int obj = array[index1]; // obj или temp - временная переменная для хранения временного значения
        array[index1] = array[index2];
        array[index2] = obj;

        index1 ++;
        index2 --;
    }

}

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
} 

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] arr = CreateArrayRndInt(8, 1, 9);
PrintArray(arr);
Reverse(arr); 
Console.WriteLine();
PrintArray(arr);
