//задаем количесвто точек M
// Создаем двумерный массив и заполняем его координатами
// Вычисляем последовательно все расстояния между точками попутно проверяя минимальность.
// Что значит исключить? Назвать точки которые планируем закрыть.



void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Nex(1, 20);
    }
}
// ввести количесвто магазинов
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
 int x = GetNumber("Введите количество магазинов:");
 int[,] shopNumber = new int [x,x];
 FillTable(shopNumber);
 void Distance(int[,] array)
 {
    for(int i =0; i<array.GetLength(0); i++)
    {
        for(j = i+1; j<array.GetLength(0); j++ )
        {
            double distance = 
        }
    }
 }