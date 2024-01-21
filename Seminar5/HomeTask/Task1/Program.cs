/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
или
"Позиция по колонкам выходит за пределы массива"

Позиции в массиве считать от единицы.

В коде, начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;
Выводится: 6
*/

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    // Поиск элемента по позициям
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        if (ValidatePosition(array, x, y))
        {
            return array[x, y];
        }
        else
        {
            Console.WriteLine("Такого элемента нет.");
            return -1; // Или любое другое значение, указывающее на ошибку.
        }
    }

    // Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
        return x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1);
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        //Напишите свое решение здесь
        int arrayX = x - 1;
        int arrayY = y - 1;

        if (ValidatePosition(numbers, arrayX, arrayY))
        {
            Console.WriteLine(numbers[arrayX,arrayY]);
        }
        else
        {
            Console.WriteLine("Неверные координаты.");
        }
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] array; // Объявление двумерного массива.

        int x, y; // Объявление переменных для координат x и y.

        if (args.Length >= 3)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(','); // Разделение аргумента на строки.

            int rowCount = rows.Length; // Количество строк в матрице.
            int colCount = rows[0].Trim().Split(' ').Length; // Количество столбцов в матрице.

            array = new int[rowCount, colCount]; // Создание двумерного массива.

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' '); // Разделение элементов строки.

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result; // Заполнение матрицы числами из аргументов.
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return; // В случае ошибки завершаем выполнение программы.
                    }
                }
            }

            // Парсинг x и y из аргументов.
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                // Теперь у вас есть двумерный массив "array" и координаты x и y.
                UserInputToCompileForTest.PrintResult(array, x, y); // Вывод результата.
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив.
            array = new int[,]
            {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
            };
            x = 2;
            y = 2;

            UserInputToCompileForTest.PrintResult(array, x, y); // Вывод результата для примерного массива.
        }
    }
}