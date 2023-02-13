// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray()
{
    int[,] array = new int[4, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

void PrintArrayOne(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write($"{array[j]}\t");
    }
    System.Console.WriteLine();
}

void FindIndex (int[] array, int numMin)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (numMin == array[i])
        {
            Console.WriteLine($"Строка {i+1} имеет минимальную сумму {numMin}");
        }
    }
}

int[] FindSumm(int[,] array)
{
    int sumOne = 0;
    int sumTwo = 0;
    int sumThree = 0;
    int sumFour = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 0;
        sumOne = sumOne + array[i, j];
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 1;
        sumTwo = sumTwo + array[i, j];
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 2;
        sumThree = sumThree + array[i, j];
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int i = 3;
        sumFour = sumFour + array[i, j];
    }

    int[] massive = new int[4] { sumOne, sumTwo, sumThree, sumFour };
    return massive;
}

int SearchRowMin(int[] massive)
{
    int min = massive[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (min > massive[i]) min = massive[i];

    }
    return min;

}

int[,] massive = GenerateArray();
PrintArray(massive);

System.Console.WriteLine();

int[] arrayWithMinElement = FindSumm(massive);
PrintArrayOne(arrayWithMinElement);
int result = SearchRowMin(arrayWithMinElement);

System.Console.WriteLine();

FindIndex(arrayWithMinElement, result);
















// int Search1(int[,] array)
// {
//     int sum = 0;
//     int i = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     return sum;
// }

// int Search2(int[,] array)
// {
//     int sum = 0;
//     int i = 1;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     return sum;
// }

// int Search3(int[,] array)
// {
//     int sum = 0;
//     int i = 2;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     return sum;
// }

// int Search4(int[,] array)
// {
//     int sum = 0;
//     int i = 3;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     return sum;
// }

// int SearchRowMin(int minOne, int minTwo, int minThree, int minFour)
// {
//     int[] massive = new int[4] { minOne, minTwo, minThree, minFour };
//     int min = minOne;

//     for (int i = 0; i < massive.Length; i++)
//     {
//         if (min > massive[i]) min = massive[i];

//     }
//     return min;
// }




// int rowOne = Search1(massive);
// int rowTwo = Search2(massive);
// int rowThree = Search3(massive);
// int rowFour = Search4(massive);




// System.Console.WriteLine($"{rowOne}, {rowTwo}, {rowThree}, {rowFour}");

// int result = SearchRowMin(rowOne, rowTwo, rowThree, rowFour);

// if (rowOne == result) System.Console.WriteLine($"Первая строка с наименьшей суммой элементов > {result}");
// if (rowTwo == result) System.Console.WriteLine($"Вторая строка с наименьшей суммой элементов > {result}");
// if (rowThree == result) System.Console.WriteLine($"Третья строка с наименьшей суммой элементов > {result}");
// if (rowFour == result) System.Console.WriteLine($"Четвертая строка с наименьшей суммой элементов > {result}");