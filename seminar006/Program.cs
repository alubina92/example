// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
void PrintTwoArray(int[,] array)
{
    for( int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
void FillTwoArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             array[i,j] = new Random().Next(1,10);
        }
    }
}
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
