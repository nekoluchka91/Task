// Не используя рекурсию, выведите первые N чисел Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// f0 = 0; f1 = 1; 0 + 1; fn = fn-1 + fn-2 для n>1;

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int num = UserInputInt ("Введите количество чисел: ");

void Fibonacci (int number)
{
    int f0 = 0;
    int f1 = 1;
    int fn = 0; // summa
    Console.Write($"{f0} {f1}");
    for (int i = 0; i < number-2; i++);
    {
        fn = f0+f1;
        Console.Write($" {fn}");
        f0 = f1;
        f1 = fn;
    }
}

Fibonacci(num);

