/* Console.WriteLine("Введите трехзначное число.");
int num = Convert.ToInt32(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
if(num > 99 && num < 1000)
{
    int num1 = num / 100;
    int num3 = num % 10;
    int result = num1 * 10 + num3;
    Console.WriteLine(result);
}
*/

/* int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num2 = num / 10 % 10;
Console.WriteLine(num2);
int num3 = num % 10;
Console.WriteLine(num3);
int result = 1;
for(int i = 1; i <= num3; i++)
{
    result = result * num2;
}
Console.WriteLine(result);
*/

/*Console.WriteLine("Введите число");
int num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введдите число");
int num2= Convert.ToInt32(Console.ReadLine());

if(num2 % num1 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine($"Нет, {num2 % num1}");
}*/

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    int result = num / 100 % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while(num >= 1000)
    {
    num = num / 10;   
    }
int result = num % 10;
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}