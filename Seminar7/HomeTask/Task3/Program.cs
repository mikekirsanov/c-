// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System;
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();

Console.WriteLine("Новый массив:");
int[] array = CreateArray(size);
Console.WriteLine();

Console.WriteLine("Перевернутый массив:");
PrintReverseArray(array, size);

int[] CreateArray(int size)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 1000);
        Console.Write($"{array[i]}\t");
    }
    return array;
}

void PrintReverseArray(int[] array, int index)
{
{
    if(index < 1)
    return;
}
Console.Write(array[index - 1] + "\t");
PrintReverseArray(array, index - 1);
}