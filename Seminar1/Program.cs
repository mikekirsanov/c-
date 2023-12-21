Console.WriteLine("Введите число");
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