// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return Numbers((m + 1), n) + m;

}

int m = Prompt("Введите число M");
int n = Prompt("Введите число N");

if (m<n)
{
System.Console.WriteLine(Numbers(m, n));
}
else
{
    System.Console.WriteLine("Ошибка. M должно быть меньше N");
}

