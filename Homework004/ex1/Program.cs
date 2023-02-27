//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
    
}
 
int Pow(int arg1, int arg2)
{

int result = 1;
for(int count = 1; count<= arg2; count++)
{ 
    
    result = result * arg1;
}
return result;
}

int A = GetNumber("Введите число");
int pow = GetNumber("Введите степень");
int result = Pow(A,pow);
System.Console.WriteLine(result);
