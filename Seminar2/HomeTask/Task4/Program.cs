﻿Console.WriteLine("Введите число.");
int n = Convert.ToInt32(Console.ReadLine());
int length = 0;
int temp = n;
while (temp > 0) //Определение количества цифр
{
    temp /= 10;
    length += 1;
}
int[] digits = new int[length];
int result = n;
for (int i = 0; i < length; i++) //Формирование массива цифр числа, начиная с младшего разряда
{
    digits[i] = result % 10;
    result /= 10;
}
for (int j = length - 1; j >= 0; j--) // Вывод на консоль массива цифр числа, начиная со старшего разряда
{
    Console.Write(digits[j]);
    if (j > 0)
    {
        Console.Write(", ");
    }
}