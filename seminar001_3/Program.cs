double a = new Random().Next(1,20);
Console.WriteLine(a);
double b = new Random().Next(1,20);
Console.WriteLine(b);


if (a == b * b)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
