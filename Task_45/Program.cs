// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] array = CreateArrayRandomInt(5, 1, 9);
int[] newArray = Copy(array);

Console.WriteLine("Исходный массив: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив: " + WriteArrayAsString(newArray));
array[0] = 4;
Console.WriteLine("Изменили первый элемент исходного массива: " + WriteArrayAsString(array));
Console.WriteLine("Скопированный массив без изменений: " + WriteArrayAsString(newArray));

int[] Copy(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = arr[i];  
    }
    return newArray;
}

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[array.Length]; 
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
} 

string WriteArrayAsString (int [] array)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[");
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
        if(i < array.Length - 1)
            sb.Append(", "); 
    }
    sb.Append("]");

    return sb.ToString();
}