// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*void ShowNums(int n)
{
    Console.Write(n + " ");

    if (n > 1)

    {
        ShowNums(n - 1);
    }
}

Console.Write("Input a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*int SumOfNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        return SumOfNaturalNumbers(m + 1, n) + m;
    }
    return 0;
}

Console.Write("Input a first natural number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second natural number greater than first number: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNaturalNumbers(m, n);
Console.Write($"The sum of the numbers from {m} to {n} is {sum}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return AckermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AckermanFunction(n - 1, AckermanFunction(n, m - 1));

    return 0;
}

Console.Write("Input a first natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second natural number: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = AckermanFunction(n, m);
Console.Write($"A({n},{m}) = {result}");
*/