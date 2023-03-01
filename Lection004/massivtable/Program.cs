//зададим двумерный массив
string[,] table = new string[2, 5];
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[2, 2] table[3, 3] table[4, 4]

table[1, 2] = "слово";

void PrintArray(string[,] array)
{
    for( int i = 0; i<2; i++)
    {
        for(int j = 0; j<5; j++)
        {
            System.Console.WriteLine($" - {array[i,j]} -");
        }
    }
}
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
//PrintArray(table);
int[,] tableTwo = new int[3,6];
FillTwoArray(tableTwo);
PrintTwoArray(tableTwo);
