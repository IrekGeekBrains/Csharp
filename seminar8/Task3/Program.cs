// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray1(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] GenerateArray2(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

int[,] Multiplication(int[,] array, int[,] array2)
{
    int[,] resultArray = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * array2[k, j];
            }
        }

    }
    return resultArray;
}



int rowArray1 = Prompt($"Введите количество строк первой матрицы: ");
int colArray1 = Prompt($"Введите количество стобцов первой матрицы: ");
int rowArray2 = Prompt($"Введите количество строк второй матрицы: ");
int colArray2 = Prompt($"Введите количество столбцов второй матрицы: ");
System.Console.WriteLine();

if (colArray1 == rowArray2)
{
    int[,] massiveOne = GenerateArray1(rowArray1, colArray1);
    int[,] massiveTwo = GenerateArray2(rowArray2, colArray2);
    System.Console.WriteLine("Первая матрица: ");
    PrintArray(massiveOne);
    System.Console.WriteLine();
    System.Console.WriteLine("Вторая матрица: ");
    PrintArray(massiveTwo);
    System.Console.WriteLine();
    System.Console.WriteLine("Результат:");
    int[,] result = Multiplication(massiveOne, massiveTwo);
    PrintArray(result);
}
else
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Указаны неправильные параметры матрицы.");
    System.Console.WriteLine($"Количество столбцов первой матрицы должны соответствовать количеству строк второй матрицы.");
}

