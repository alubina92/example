//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int KeyboardInput( string massage)   // метод ввода с клавиатуры
{
    Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


bool Holiday(int number) // метод определения вых или нет
{
    
      if(number > 5)
      {
        return true;
        Console.WriteLine("Это выходной");
      }
      else
      {
        return false;
        Console.WriteLine("Это будний день");
    
      }
    
}

bool DayOfWeek(int nnumber)  // метод определения правильное ли пользователь ввел число.
{
    if(nnumber >0 && nnumber<=7) return true;
    return false;
    Console.WriteLine("Такого дня не существует");

}



int number = KeyboardInput("Введите число: ");

if(DayOfWeek(number))
{
 if(Holiday(number))
 {
    Console.WriteLine("Урра, отдыхаем!");
 }
 else
 {
    Console.WriteLine("Работаем..");
 }
}
else
{
    Console.WriteLine("Вы ввели неверный день");
}
