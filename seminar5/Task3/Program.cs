// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] GenerateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    int i = 0;
    int length = array.Length;
    double min = array[i];

    while (i < length)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        i++;
    }
    return min;
}

double[] array = GenerateArray(5);
PrintArray(array);
// System.Console.WriteLine($"Максимальное {FindMax(array)}");
// System.Console.WriteLine($"Минимальное {FindMin(array)}");
double result = FindMax(array) - FindMin(array);
System.Console.WriteLine($"Разница между максимальным значением {FindMax(array)} и минимальным значением {FindMin(array)} равна {result}");