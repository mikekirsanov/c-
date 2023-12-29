double CalculteFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}

double result = CalculteFormula(34, 345, 323, 67);
Console.Write(result);