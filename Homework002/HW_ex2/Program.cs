//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)
{
    int result;

    if(number / 100 > 0)
    {
        result = number % 10;
        return result;
     
    }
    else
    {
        result = -1;
        Console.WriteLine("Третьей цифры нет");   
    
    }
   return result;
    }
int ExumpleNumber = new Random().Next(1,1000);
Console.WriteLine(ExumpleNumber);
int ExumplaeResult = ThirdDigit(ExumpleNumber);
Console.WriteLine(ExumplaeResult);

// второй вариант
Console.WriteLine("Второй вариант");

int ThirdNumber(int count)
{
    int answer = count % 10;
    return answer;
}

int abc = new Random().Next(1,1000);
Console.WriteLine(abc);
int c = ThirdNumber(abc);

if(abc / 100 > 0)
{
    Console.WriteLine(c);

}
else
{
    Console.WriteLine("Третьей цифры нет");
}