// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 99);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }

}

int FindMaxStroka1(int[,] matrix)
{
    int max = matrix[0, 0];
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    return max;
}

int FindMaxStroka2(int[,] matrix)
{
    int max = matrix[1, 0];
    int i = 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    return max;
}

int FindMinStolbec1(int[,] matrix)
{
    int min = matrix[0, 0];
    int j = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
        }
    }
    return min;
}

int FindMinStolbec2(int[,] matrix)
{
    int min = matrix[0, 1];
    int j = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
        }
    }
    return min;
}

int FindMinStolbec3(int[,] matrix)
{
    int min = matrix[0, 2];
    int j = 2;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
        }
    }
    return min;
}

int[,] matrix = new int[2, 3];  // 2 - строки      3 - столбца
FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine($"Максимальное значение в первой строке = {FindMaxStroka1(matrix)}");
System.Console.WriteLine($"Максимальное значение во второй строке = {FindMaxStroka2(matrix)}");
int summax = FindMaxStroka1(matrix) + FindMaxStroka2(matrix);
System.Console.WriteLine($"Сумма этих максимумов {summax}");
System.Console.WriteLine($"Минимальное значение в первой колонке = {FindMinStolbec1(matrix)}");
System.Console.WriteLine($"Минимальное значение во второй колонке = {FindMinStolbec2(matrix)}");
System.Console.WriteLine($"Минимальное значение в третьей колонке = {FindMinStolbec3(matrix)}");
int summin = FindMinStolbec1(matrix) + FindMinStolbec2(matrix) + FindMinStolbec3(matrix);
System.Console.WriteLine($"Сумма этих минимумов {summin}");
int result = summax - summin;
System.Console.WriteLine($"Разница между {summax} и {summin} равна {result}");
