﻿Console.WriteLine("Введите число.");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Введенное число кратно 7 и 23");
}
else
{
    Console.WriteLine("Введенное число не кратно 7 и 23");
}