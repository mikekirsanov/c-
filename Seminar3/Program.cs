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

int sizeArray = 10;

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
}