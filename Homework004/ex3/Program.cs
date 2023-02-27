//Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// метод создания массива
// метод заполнения массива
//метод печати массива
double[] CreateArray(int size)
{
    return new double[size];
}
void PrintArray(double[] col) 
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}
string Print(double[] array)
{
  string result = String.Empty;
  int len = array.Length;
  int index = 0;
  while (index < len)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
void FillArray(double []collection) 
{
    int size = collection.Length;
    int index = 0;
    while(index < size)
    {
        collection[index] = new Random().Next(-100, 100);
        index++;
    }
}

double [] numbers = CreateArray(GetNumber("Введите число N"));
FillArray(numbers);
PrintArray(numbers);