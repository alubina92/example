// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateTable(int k, int m)
{
    return new int[k, m];
}
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Average(int[,] array)
{
    int sum = 0; // сумма в столбце
    double average = 0; // среднее арифтемитечское
    double maxAverage = 0; //наибольшее среднее
 
    int position = 0;// индекс столбца наибольшего среднего
   

    for (int i = 0; i < array.GetLength(1); i++) // столбцы считаем
    {


        for (int j = 0; j < array.GetLength(0); j++) // строки считаем
        {

            sum = sum + array[j, i];

        }


        average = Convert.ToDouble(sum) / (array.GetLength(0)); // среднее арифметическое считаем

        System.Console.WriteLine($" Среднее арифметичсекое {i + 1} столбца равно: {Math.Round(average, 2)} ");
        if (average > maxAverage)
        {
            maxAverage = average;
            position = i + 1;
        }
       
        sum = 0;


    }
    System.Console.WriteLine($" Максимальное среднееарифметическое равно {Math.Round(maxAverage,2)}, в столбце {position}");
 
   

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
int row = GetNumber("Введите количество строк");
int column = GetNumber("Введите число столбцов");
int[,] table = CreateTable(row, column);
FillTable(table);
Average(table);

