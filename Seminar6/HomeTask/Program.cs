//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

/*using System;
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
*/

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

/*using System;
Random rnd = new Random();
Console.WriteLine("Введите размер строки.");
int num = Convert.ToInt32(Console.ReadLine());
string str = "";
for(int i = 0; i < num; i++)
{
    int numchar1 = rnd.Next(65,91);
    int numchar2 = rnd.Next(97,123);
    int alfa = rnd.Next(1,3);
    if(alfa == 1) str += (char)numchar1;
    else str += (char)numchar2;
}
Console.WriteLine(str);
string str2 = str.ToLower();
Console.WriteLine(str2);
*/
//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

using System;
Console.WriteLine("Введите строку.");
string? str = Console.ReadLine();
int size = str.Length;
char[] symArray = new char[size];
for(int i = 0; i < size; i++)
{
    symArray[i] += str[i];
}
bool pal = true;
for(int i = 0; i < size/2; i++)
{
    if(symArray[i] == symArray[size - 1 - i]) pal = true;
    else
    {
        pal = false;
        break;
    }
}
if(pal) Console.WriteLine("Введенная строка является палиндромом");
else Console.WriteLine("Введенная строка не является палиндромом");
