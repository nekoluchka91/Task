// 1) Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// 2) Найдите сумму отрицательных и положительных элементов массива.
// 3) Вывод результата.

//сначала создаем массив из подзадачи 1)
int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size]; // int[] arr - создали массив
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)//начинаем перебирать с индекса 0
    {
        arr[i] = rnd.Next(min, max + 1);//min = -9, max = 9, но увеличиваем на +1 (т.е. 10), так как 9 не будет входить в ином случае в наш диапазон
    }
    return arr;
} 
//затем находим сумму отр и полож чисел из подзадачи 2)
int [] GetSumPosNegElem (int [] array) // array - переменная
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sumNeg += array [i];
        }
        else
        {
            sumPos += array [i];
        }
    }
    return new int [] {sumNeg, sumPos};
}

// подзадача 3) создаем метод для вывода на печать результата
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
// теперь нужно вызвать каждый метод
int[] array = CreateArrayRndInt(12, -9, 9); //записываем метод в переменную и подставляем условия нашей задачи
PrintArray(array); //выводим на печать наш случайный массив
int[] sumPosNegElem= GetSumPosNegElem(array); //присваиваем методу переменную и вызываем второй метод по сумме отр и полож чисел
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPosNegElem[1]}"); //1 - sumPos
Console.WriteLine($"Сумма отрицательных чисел = {sumPosNegElem[0]}"); //0 - sumNeg