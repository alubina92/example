// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// преподаватель сказал решать через методы. Значит вводим метод.

int SecondDigit(int number)
{
    int result = (number % 100) / 10;
    return result;
}
int number2 = new Random().Next(100, 1000);
int count = SecondDigit(number2);
Console.WriteLine(number2);

Console.WriteLine(count);
