//// Задачи 1
// Реализовать перемешивание массива

// 1. создать массив
// 2. записать массив
//3. заполнить массив
//4. перемешать массив 
void FillArray(int []collection) // метод заполнения массива
{
    int size = collection.Length;
    int index = 0;
    while(index < size)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) // method of print 
{ 
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[]collection, int find) // метод нахождения индекса необходимого значения)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // если убрать будет последнее вхождение. с ним первое
        }
        index++;
    }
    return position;
}

// Задача 1
// Реализовать перемешивание массива

// 1. Создание массива
int[] CreateArray(int size)
{
  return new int[size];
}
// 2. ввод числа
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 3. Печать массива
string Print(int[] array)
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


// 4. Заполнение массива
// 4.1 руками

void FillByUser(int[] array)
{
  int size = array.Length;

  int index = 0;

  while (index < size)
  {
    array[index] = GetNumber("Введите " + index + " элемент: ");
    index++;
  }
}
// метод перемешивания
void GetMix(int[] array)
{
    int length = array.Length;
    int index = 0;
    int secondIndex;
    int tempt;
    
    while(index<length)
    {
       secondIndex = new Random().Next(1, length - 1);
       tempt = array[index];
       array[index] = array[secondIndex];
       array[secondIndex] = tempt;
       index++;
    }
}

int size = GetNumber("Введите размер массива ");
int[] numbers = CreateArray(size);
System.Console.WriteLine(Print(numbers));

FillByUser(numbers);
System.Console.WriteLine(Print(numbers));
GetMix(numbers);
System.Console.WriteLine(Print(numbers));

// int[] mas = GetMix(numbers);
// System.Console.WriteLine(Print(numbers));

