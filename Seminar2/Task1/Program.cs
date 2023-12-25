Console.WriteLine("Введите трехзначное число.");
int num = Convert.ToInt32(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
if(num > 99 && num < 1000)
{
    int num1 = num / 100;
    int num3 = num % 10;
    int result = num1 * 10 + num3;
    Console.WriteLine(result);
}