// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний эл-ты, второй и предпоследний и т.д.
// Результат запишите в новый массив.
// [1, 2, 3, 4, 5] -> 5, 8, 3
// [6, 7, 3, 6] -> 36, 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] arraySum(int[] array) // ДОП ДЗ СДЕЛАТЬ РЕФАКТОРИНГ - вместо двух циклов, сделать один цикл, так как условия почти одинаковые!!!
{
    if (array.Length % 2 == 0) //проверяем условие четности длины массива
    {
        int[] newArray = new int[array.Length / 2];//если четный, создаем новый массив длиной в половину меньше
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];//перемножаем первый и посл эл-ты
        }
        return newArray;
    }
    else //если нечетное кол-во эл-ов в массиве
    {
        int[] newArray = new int[array.Length / 2 + 1]; //на 1 эл-т больше полуится массив, тк остается средний эл-т без пары
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
        }
        newArray[newArray.Length - 1] = array[array.Length / 2]; //добавляем этот средний эл-т в конец
        return newArray;
    }
}


int[] array = CreateArrayRndInt(5, 1, 5);
PrintArray(array);
Console.WriteLine();
int[] count = arraySum(array);
PrintArray(count);