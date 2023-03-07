// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] numbers = new int[2, 4];
void Average(int[,] array)
{
    int sum = 0;
    double average =0;
    for(int i = 0; i<array.GetLength(1);i++) // столбцы считаем
    {
        for(int j = 0; j<array.GetLength(0); j++) // строки считаем
        { 
            
            sum = sum + array[j,i];
            
        }
        
        average = Convert.ToDouble(sum)/(array.GetLength(0));
        System.Console.WriteLine($" Среднее арифметичсекое {i+1} столбца равно: {average} ");
        sum =0;
    }
}
void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{array[i, j]} ");
        }

        System.Console.WriteLine();
    }
}
FillTable(numbers);
Average(numbers);
