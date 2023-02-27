//Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
int GetNumber( string text)
{
    System.Console.WriteLine(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}

 
 int Sum(int number)
        {
            int result = 0;
            result += number % 10;
            number /= 10;
            if(number > 0)
            {
                result += Sum(number);
            }
            return result;
        }
int number = GetNumber("Введите число");
int sum = Sum(number);
System.Console.WriteLine(sum);