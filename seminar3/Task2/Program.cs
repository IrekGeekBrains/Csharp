// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numX1 = Prompt("Введите Х1");
int numY1 = Prompt("Введите Y1");
int numZ1 = Prompt("Введите Z1");
int numX2 = Prompt("Введите X2");
int numY2 = Prompt("Введите Y2");
int numZ2 = Prompt("Введите Z2");


double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = x2 - x1;
    double b = y2 - y1;
    double c = z2 - z1;
    return Math.Sqrt(a * a + b * b + c * c);
}

Console.WriteLine("Результат: " + Distance(numX1, numY1, numZ1, numX2, numY2, numZ2));
