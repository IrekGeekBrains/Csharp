// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите пятизначное число: ");

if (number > 9999 && number <= 99999)
{
    int num1 = number / 10000;
    int num5 = number % 10;
    int num2 = (number / 1000) % 10;
    int num4 = (number % 100) / 10;

    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}

