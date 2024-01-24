//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

using System;
char [,] array = {{'H', 'e', 'l', 'l', 'o', ','}, {' ', 'w', 'o', 'r', 'l', 'd'}};
string str = "";
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        str += array[i,j];
    }
}
Console.WriteLine(str);