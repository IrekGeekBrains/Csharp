// Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int Random (){
    int random = new Random().Next(100, 1000);
    Console.WriteLine($"Случайное трехзначное число {random}");
    return random;
}

int chance = Random();
int num1 = (chance / 100);
int num2 = chance % 10;

Console.WriteLine($"Трехзначное случайное число {chance} результат {num1}{num2}");
