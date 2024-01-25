// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int num = int.Parse(Console.ReadLine());  //  123

int GetSumNum(int newNum) // 123
{
    if(newNum==0)
    {
        return 0;
    }

    return (newNum%10 + GetSumNum(newNum/10));   // 3 + 2+1 +0
}
System.Console.WriteLine(GetSumNum(num));

