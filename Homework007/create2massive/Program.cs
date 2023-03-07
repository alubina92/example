//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.m=3 n=4

void FillTwoAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble(); // как сделать чтобы отрицательные числа были?
    }
}
void PrintTwoArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(array[i, j], 2)}  ");
        }
        System.Console.WriteLine();
    }

}
double[,] numbers = new double[3, 4];
FillTwoAray(numbers);
PrintTwoArray(numbers);

