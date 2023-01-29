// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int num)
{
    int result = 0;
    int count = 0;

    while (num > 0)
    {
        count = num % 10;
        result = result + count;
        num = num / 10;
    }
    return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма равна {Sum(number)}");




