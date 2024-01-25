// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

/*int num = int.Parse(Console.ReadLine());  //  123

int GetSumNum(int newNum) // 123
{
    if(newNum==0)
    {
        return 0;
    }

    return (newNum%10 + GetSumNum(newNum/10));   // 3 + 2+1 +0
}
System.Console.WriteLine(GetSumNum(num));

*/

// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

/*
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int firstElement = 1;

PrintNumbers(firstElement,num);

void PrintNumbers(int firstNum, int endNum)
{
    if(firstNum> endNum)
    {
        return;
    }

    System.Console.WriteLine(firstNum);

    PrintNumbers(firstNum+1, endNum);
}
*/

// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

System.Console.WriteLine("Введите строку");
string str = Console.ReadLine();
int index=0;
string vowels= "aeiuoy";

void PrintStr(string newStr, int i)
{

    if(i==newStr.Length)
    {
        return;
    }

    if(!vowels.Contains(newStr[i]))
    {
        System.Console.Write(newStr[i]);
    }
    PrintStr(str,++i);
}
PrintStr(str,index);
