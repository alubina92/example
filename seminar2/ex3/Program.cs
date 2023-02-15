// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

    if(a % b == 0)
    {
        Console.WriteLine("Да, кратное");
    }
    else
    {
      Console.Write("НЕТ, остаток равен: ");
      Console.WriteLine(a % b);
    }

