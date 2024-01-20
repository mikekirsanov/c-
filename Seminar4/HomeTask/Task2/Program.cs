//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

int[] CreateMassive(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbersCount(int[] array)
{
    int count = 0;
    foreach (int e in array)
    {
        if (e % 2 == 0) count += 1;
    }
    return count;
}

Console.WriteLine("Введите размер массива.");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateMassive(size);
PrintMassive(array);
Console.WriteLine("Количество четных чисел в массиве равно " + EvenNumbersCount(array));