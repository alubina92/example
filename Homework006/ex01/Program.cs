//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int GetNumber(string text)
{
    System.Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>0) count++;

    }
    System.Console.WriteLine($"Количество больше нуля равно: {count}");
    return count;
}
int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] array)
{
  for(int i = 0; i<array.Length; i++) array[i] = GetNumber($"Введите {array[i]} число: ");
}
void PrintArray(int[]array)
{   
    System.Console.Write("[");
    for(int i = 0; i<array.Length; i++)
    {
    System.Console.Write($"{array[i]}, " );
    }
    System.Console.WriteLine("]");
}

int[] numbers = CreateArray(GetNumber("Введите число "));
FillArray(numbers);
PrintArray(numbers);
int count = Count(numbers);
