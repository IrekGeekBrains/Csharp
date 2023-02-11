// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] GenerateArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double SredneeArifmet1 (double[,] array)
{
    double count = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = count + array[i, j];
    }
    double result = count / array.GetLength(0);
    return result;
}

double SredneeArifmet2 (double[,] array)
{
    double count = 0;
    int j = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = count + array[i, j];
    }
    double result = count / array.GetLength(0);
    return result;
}

double SredneeArifmet3 (double[,] array)
{
    double count = 0;
    int j = 2;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = count + array[i, j];
    }
    double result = count / array.GetLength(0);
    return result;
}

double SredneeArifmet4 (double[,] array)
{
    double count = 0;
    int j = 3;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = count + array[i, j];
    }
    double result = count / array.GetLength(0);
    return result;
}

double SredneeArifmet5 (double[,] array)
{
    double count = 0;
    int j = 4;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = count + array[i, j];
    }
    double result = count / array.GetLength(0);
    return result;
}


double[,] massive = GenerateArray(5,5);
PrintArray(massive);
double result1 = SredneeArifmet1(massive);
double result2 = SredneeArifmet2(massive);
double result3 = SredneeArifmet3(massive);
double result4 = SredneeArifmet4(massive);
double result5 = SredneeArifmet5(massive);
System.Console.WriteLine();
System.Console.WriteLine($"Среднее арифметическое первого столбца: {result1}");
System.Console.WriteLine($"Среднее арифметическое второго столбца: {result2}");
System.Console.WriteLine($"Среднее арифметическое третьего столбца: {result3}");
System.Console.WriteLine($"Среднее арифметическое четвертого столбца: {result4}");
System.Console.WriteLine($"Среднее арифметическое пятого столбца: {result5}");