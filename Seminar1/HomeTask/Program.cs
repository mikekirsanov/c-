/* using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if(firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше, чем второе число `{secondNumber}`");
        }
        else if(firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше, чем второе число `{secondNumber}`");
        }
        else
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
*/

using System;

public class Answer
{

    static int Findresult(int a, int b, int c)
    {
        // Введите свое решение ниже
        int result = a;
        if (result < b)
        {
            result = b;
        }
        if (result < c)
        {
            result = c;
        }
        return result;
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int a, b, c;

        if (args.Length >= 3)
        {
            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            a = 5;
            b = 6;
            c = 7;
        }

        // Не удаляйте строки ниже
        int result = Findresult(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}