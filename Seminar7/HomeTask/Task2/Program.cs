// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;
Console.WriteLine("Введите первое число.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Результат вычисления функции Аккермана для m = {m} и n = {n}: {result}");

int Ackermann(int M, int N)
{
    if (M == 0)
            return N + 1;
        else if (M > 0 && N == 0)
            return Ackermann(M - 1, 1);
        else if (M > 0 && N > 0)
            return Ackermann(M - 1, Ackermann(M, N - 1));

        return 0;
}