/* Console.WriteLine("Введите число");
 int a = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int b = int.Parse(Console.ReadLine());
 if (a == b * b)
 {
    Console.WriteLine("Первое число является квадратом второго.");
 }
 else
 {
    Console.WriteLine("Первое число не является квадратом второго.");
 }
 */

/* Console.WriteLine("Введите число");
 int num = int.Parse(Console.ReadLine());
 int negNum = -1 * num;
 while(negNum <= num)
{
    Console.WriteLine(negNum);
    negNum = negNum + 1;
}
*/

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num / 100;
int num3 = num % 10;
int result = num1 + num3;
Console.WriteLine("Сумма первой и третьей цифр числа равна " + result); //конкатенация
Console.WriteLine($"Сумма первой и третьей цифр числа равна {result}"); //интерполяция