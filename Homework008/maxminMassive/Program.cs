// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] numbers = new int[4, 6];

void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 20);
    }
}
void StreamlineTable(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++) 
  {
    int max = 0;
     for (int j = 0; j < array.GetLength(1); j++) 
     {   int tempt;
         if(array[i,j] > max)
         {
             max = array[i,j];
         }
             tempt = a
     }
}
int MaxNumber(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++) // выбрали строку
    {
        int max = 0;
        int[] arr = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++) //перебираем элементы в строке
        {
            if (array[i, j] > max)
                {
                    max = array[i, j];
                   do(index++)
                
            
            for (int index = 0; index < array.GetLength(1); index++)
            {
                
        }

    }