// программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
double N = Double.Parse(Console.ReadLine());
int count = 1;

while(count<=N)
{
    if (count % 2 == 0)
    {
         Console.WriteLine(count);
        
    }
 
 count += 1;     
}

Console.WriteLine("Операция завершена.");


