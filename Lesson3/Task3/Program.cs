void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] array)
{
    foreach(int e in array)
    {
    Console.Write($"{e} ");
    }
}

int[] array = {23, 34, 45, 23, 67, 34};
ZeroEvenElements(array);
PrintArray(array);