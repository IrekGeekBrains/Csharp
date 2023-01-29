// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] CreateArray(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(); // В условии задачи не задан диапазон чисел, который должен быть в массиве, поэтому в теле цикла диапазон не указал.
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


int razmer = 8;
int [] array = CreateArray(razmer);
PrintArray(array);