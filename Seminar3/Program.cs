/*int [] array = new int [10];

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string find= "Нет";

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0,100);
Console.Write(array[i]+ " ");

if(array[i]== num)
{
find = "Да";
}
}
Console.WriteLine(find);
*/
// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

/*int sizeArray = 10;

int [] array = new int [sizeArray];

for (int i = 0; i < array.Length; i++)
{
[i] = new Random().Next(-10,11);
Console.Write([i]+ " ");
}

System.Console.WriteLine();

for (int i = 0; i < .Length; i++)
{
[i] = -1 * [i];
Console.Write([i]+ " ");
}*/

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

/*System.Console.WriteLine("Введите размер массива.");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeArray];
int[] array2 = new int[sizeArray / 2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}

System.Console.WriteLine();

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[array.Length - 1 - i];
    System.Console.Write(array2[i] + "\t");
}*/

// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

System.Console.WriteLine("Введите трехзначное число.");
int num = Convert.ToInt32(Console.ReadLine());
int sizeArray = 3;

int[] array = new int[sizeArray];

for (int i = 0; num > 0; i++, num /= 10)
{
    array[i] = num % 10;
    Console.Write(array[i] + " ");
}