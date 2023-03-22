// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillCoub(double[,,] coub)
{
    for (int x = 0; x < coub.GetLength(0); x++)
    {
        for (int y = 0; y < coub.GetLength(1); y++)
        {
            for (int z = 0; z < coub.GetLength(2); z++)
                coub[x, y, z] = new Random().Next(10, 100);

        }
    }
    
}


for (int x = 0; x < coub.GetLength(0); x++)
    {
        for (int y = 0; y < coub.GetLength(1); y++)
        {
            for (int z = 0; z < coub.GetLength(2); z++)
                

        }
    }