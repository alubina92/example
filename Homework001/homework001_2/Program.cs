Console.WriteLine("Программа, которая ищет наибольшее из трех чисел");
Console.WriteLine("Введите числа по порядку, нажимая enter");

double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());
double c = Double.Parse(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
      Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if(b>c)
    {
      Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}


