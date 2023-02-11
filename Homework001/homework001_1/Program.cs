Console.WriteLine("Здравствуйте, это программа определяет наибольшее из двух чисел");
Console.WriteLine("Введите числа: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Наибольшее число: ");

if(a > b)
{
Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}