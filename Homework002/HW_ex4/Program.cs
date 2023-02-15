//  Программа проверяет пятизначное число на палиндромом.
//создать метод ввода с клавиатуры
//создать метод проверки числа пятизначное или нет
//создать метод определения цифры из числа
// создать метод сравнения чисел
// ввести данные и просчитать по методам

int KeyboardInput(string massage)
{
  Console.WriteLine(massage);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
int number = KeyboardInput("Введите число");

bool fiveth( int number)
{
    if(number / 10000 > 0) 
    {
        return true;
    }
    else
    { 
        Console.WriteLine("Число не пятизначное, введите другое!");
        return false;
        
    }
}


void FillArray(int[] digit)
{
    int size = 5;
    int index = 0;
    int NumberDigit = 10000;
    int number = KeyboardInput("Введите число");
    while (index < size)
    {
        digit[index] = number / NumberDigit;
        index++;
        NumberDigit = NumberDigit / 10;
    }
}



bool Palindrom( int[] digit)
{
    
    if(digit[0] == digit[4] && digit[1] == digit[3]) 
    {
        return true;
     Console.WriteLine(" число палиндромом"); 
    }
    else
    {
        Console.WriteLine("не является");
        return false;
    }
}
while(fiveth(KeyboardInput("Введите число")))
{
   int[] array = new int[5];
    FillArray(array);
    
}





