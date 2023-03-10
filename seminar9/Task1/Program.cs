// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        System.Console.Write(m + " ");
    }
    Numbers(m + 1, n);
}

int m = Prompt("Введите число M");
int n = Prompt("Введите число N");
if (m < n)
{
    Numbers(m, n);
}
else
{
    System.Console.WriteLine("Ошибка. M должно быть меньше N");
}