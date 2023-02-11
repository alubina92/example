Console.WriteLine("Программа которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.WriteLine("Введите число: ");

double a = Double.Parse(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число НЕ четное");
}