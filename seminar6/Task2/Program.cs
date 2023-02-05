// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Найдем X:
// y = k1 * x + b1
// y = k2 * x + b2
// k2 * x + b2 = k1 * x + b1
// (k2 - k1) * x = b1 - b2
// x = (b1 - b2) / (k2 - k1)

// Найдем У:
// y = k2 * x + b2 = k2 * ((b1 - b2) / (k2 - k1)) + b2



double ImputInt (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Point(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * ((b1 - b2) / (k2 - k1)) + b2);
    if (k1 == k2)
    {
        Console.Write("Заданные прямые не пересекаются!");
    }
    else
    {
        Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
    }
}

double b1 = ImputInt ("Введите b1: ");
double k1 = ImputInt ("Введите k1: ");
double b2 = ImputInt ("Введите b2: ");
double k2 = ImputInt ("Введите k2: ");

Point(b1, k1, b2, k2);
