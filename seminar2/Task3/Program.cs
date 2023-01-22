// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputInt(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
Console.WriteLine("ДНИ НЕДЕЛИ:");
Console.WriteLine("1 - Понедельник");
Console.WriteLine("2 - Вторник");
Console.WriteLine("3 - Среда");
Console.WriteLine("4 - Четверг");
Console.WriteLine("5 - Пятница");
Console.WriteLine("6 - Суббота");
Console.WriteLine("7 - Воскресенье");

int num = InputInt("Введите порядковый номер дня недели: ");

if (num <= 7)
{
    if (num == 6)
    {
        Console.WriteLine($"Поздравляю! Вы выбрали выходной день СУББОТА");
    }
    else
    {
        if (num == 7)
        {
            Console.WriteLine($"Поздравляю! Вы выбрали выходной день ВОСКРЕСЕНЬЕ");
        }
        else
        {
            Console.WriteLine("Прости, ты выбрал будний день");
        }
    }
}
else
{
    Console.WriteLine("Вы не выбрали день недели");
}