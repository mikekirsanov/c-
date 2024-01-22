// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char [] array = new char[]{'t','y','3','r','$',};
string str = "";

for (int i = 0; i < array.Length; i++)
{
    str = str + array[i];
}

System.Console.WriteLine(str);
