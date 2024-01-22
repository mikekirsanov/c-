// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


/*char [] array = new char[]{'t','y','3','r','$',};
string str = "";

for (int i = 0; i < array.Length; i++)
{
    str = str + array[i];
}

System.Console.WriteLine(str);
*/
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

System.Console.WriteLine("Введите строчку");
string str = Console.ReadLine();
char [] array = new char[str.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = str[i];
    System.Console.Write(array[i] + "");
}