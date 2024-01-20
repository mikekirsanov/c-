//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ChangeMassive(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

void PrintMassive(int[] array)
{
    foreach (int e in array)
    {
        Console.Write(e + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива.");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateMassive(size);
PrintMassive(array);
ChangeMassive(array);
Console.WriteLine("Перевернутый массив:");
PrintMassive(array);