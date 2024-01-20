/*Задача 1: Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.*/

using System;

while(true)
{
    Console.WriteLine("Введите число. Для выхода нажмите 'q'.");
    string nums = Console.ReadLine();
    if (nums.Length == 1 && nums == "q")
    {
       Console.WriteLine("Завершение работы.");
       break;
    }
    else if(OddSum(nums) == false)
    {
        Console.WriteLine("Сумма цифр числа четная. Завершение работы.");
        break;
    }
    else
    {
        Console.WriteLine("Сумма цифр числа нечетная.");
    }    
}

int Sum(string num)
{
    int inum = Convert.ToInt32(num);
    int sum = 0;
    for (int i = 0; inum > 0; i++)
    {
        sum += inum % 10;
        inum /= 10;
    }
    Console.WriteLine("sum = " + sum);
    return sum;
}

bool OddSum(string num)
{
    if (Sum(num) % 2 == 0) return false;
    else return true;
}