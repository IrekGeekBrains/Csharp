// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt ("Введите число: ");
int result = 0;

for (int index = 1; index <= number; index++)
{
    result = index * index * index;
    Console.Write($"{result}, ");
}
