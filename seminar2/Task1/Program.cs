// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputInt(string message){
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int num = InputInt("Введите трехзначное число: ");
if(num > 99 && num < 1000)
{
    int result = num % 100;
    int result1 = result / 10;
    
    Console.WriteLine($"Центральная цифра {result1}");
}else{
    Console.WriteLine("Число не трехзначное!");
}
