// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void OutputText(string msg)
{
    System.Console.WriteLine(msg);
}

bool Palindrom(string number)
{
    bool result = true;
    int count = 0;
    int length = number.Length;
    for (int i = 0; i < (length / 2); i++)
    {
        int j = (length - 1) - i;
     
        if (number[i] != number[j])
        {
            result = false;
            return result;
             i++; 
             count++;
             }
        
        

    }
return result;
}


OutputText("Введите число: ");
string numbers = Console.ReadLine();
bool result = Palindrom(numbers);
System.Console.WriteLine(result);