// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int [] CreateArray(int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}, ");
    }
}


int razmer = Prompt("Введите количество элементов массива: ");
int min = Prompt("Введите минимальный порог случайных значений: ");
int max = Prompt("Введите максимальный порог случайных значений: ");
int [] array = CreateArray(razmer, min, max);
PrintArray(array);