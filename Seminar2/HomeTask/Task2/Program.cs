Console.WriteLine("Введите координату X точки.");
int x = Convert.ToInt32(Console.ReadLine());
while (x == 0)
{
    Console.WriteLine("Вы ввели нулевую координату X точки. Введите другое значение.");
    x = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координату Y точки.");
int y = Convert.ToInt32(Console.ReadLine());
while (y == 0)
{
    Console.WriteLine("Вы ввели нулевую координату Y точки. Введите другое значение.");
    y = Convert.ToInt32(Console.ReadLine());
}
if (x > 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами X = {x} и Y = {y} находится в 1 координатной четверти плоскости.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine($"Точка с координатами X = {x} и Y = {y} находится во 2 координатной четверти плоскости.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine($"Точка с координатами X = {x} и Y = {y} находится в 3 координатной четверти плоскости.");
}
else
{
    Console.WriteLine($"Точка с координатами X = {x} и Y = {y} находится в 4 координатной четверти плоскости.");
}