// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if(a % 7 == 0)
{
    if(a % 23 == 0)
    {
        Console.WriteLine("Да, кратное");
    }
    else
    {
      Console.WriteLine("НЕТ");
    }
}
else
{
    Console.WriteLine("НЕТ");
}
bool kratno(int number)
{
    if (number % 7 == 0 && number % 23 == 0) 
    {
        return true;
        Console.WriteLine("кратно");
    }
    else 
    { 
        Console.WriteLine("нет");
        return false;
    }
}
Console.WriteLine("Попробуем через метод");
Console.WriteLine(kratno(a));