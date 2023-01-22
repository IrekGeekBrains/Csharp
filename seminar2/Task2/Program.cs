// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

long InputInt(string message)
{
    Console.WriteLine(message);
    long mes = Convert.ToInt64(Console.ReadLine());
    return mes;
}
long number = InputInt("Введите число: ");

if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    long result = number % 10;
    Console.WriteLine($"Третья цифра числа равна {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
