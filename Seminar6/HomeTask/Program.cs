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

using System;
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