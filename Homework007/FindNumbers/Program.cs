//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] table = new int[4, 9];
void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next();
            System.Console.Write($"{array[i, j]} ");
        }

        System.Console.WriteLine();
    }
}
void FindNumber(int[,] array, int m, int n) //m - строка, n - столбец
{


    if (m < array.GetLength(0))
    {
        if (n < array.GetLength(1))
        {
            System.Console.Write($"Число найдено: {array[m, n]}");
        }
        else
        {
            System.Console.WriteLine("Число не найдено");
        }


    }
    else
    {
        System.Console.WriteLine("Число не найдено");
    }

}


int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



FillTable(table);
FindNumber(table, GetNumber("Введите строку"), GetNumber("Введите столбец"));
