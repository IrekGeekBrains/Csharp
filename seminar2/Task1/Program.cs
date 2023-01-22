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
    int result = num / 10;
    int result1 = 100 + result;
    int result2 = result1 % 10;

    Console.WriteLine(result2);
}else{
    Console.WriteLine("Число не трехзначное!");
}
