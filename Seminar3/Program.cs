int [] array = new int [10];

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