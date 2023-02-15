// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = new Random().Next(10, 100);

Console.WriteLine(a);

int c = a / 10;
int d = a % 10;

if (c>d)
{
    Console.WriteLine(c);
}
else 
{
 Console.WriteLine(d);
}
