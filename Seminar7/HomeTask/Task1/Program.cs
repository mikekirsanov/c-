// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;
Console.WriteLine("Введите первое число.");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int N = Convert.ToInt32(Console.ReadLine());
int min = M;
int max = N;
if(M > N)
{
    min = N;
    max = M;
}

PrintRangeOfNumbers(min, max);

void PrintRangeOfNumbers(int Min, int Max)
{
    if(Min > Max)
    {
        return;
    }

    Console.Write(Min + "\t");
    PrintRangeOfNumbers(Min+1, Max);
}