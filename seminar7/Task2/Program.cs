// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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

bool ValidateArray(int row, int col, int[,] array)
{
    if (row >= array.GetLength(0) || col >= array.GetLength(1))
    {
        System.Console.WriteLine($"Такого элемента не существует.");
        return false;
    }
    return true;
}

int Search(int row, int col, int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[row, col])
            {
                result = array[i, j];
            }
        }
    }
    return result;
}


int[,] matrix = GenerateArray(5, 5);
PrintArray(matrix);
int row = Prompt("Выберете интересующую строку: ");
int col = Prompt("Выберете интересующий столбец: ");

if (ValidateArray(row, col, matrix))
{
    int result = Search(row, col, matrix);
    System.Console.WriteLine($"Вы выбрали цифру: {result}");
}
