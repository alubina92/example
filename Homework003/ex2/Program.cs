//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// 1. Создадим два массива, заполним, распечатаем.
// 2. Найдем разность элементов двух массивов с одинаковым индексом
// 3. найдем сумму квадратов разностей элементов двух массивов с одинаковым индексом
//4. вычислим квадратный кореень


//метод создания массива
double[] CreateArray(int size)
{
    return new double [size];
}
// метод заполнения массвиа вручную
void FillByUser(double[] array)
{
  int size = array.Length;

  int index = 0;

  while (index < size)
  {
    array[index] = GetNumber("Введите " + index + " элемент: ");
    index++;
  }
}
// метод ввода числа
int GetNumber(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

double Distance( double[] array)
{
    return Math.Sqrt(Math.Pow(array[0], 2) + Math.Pow(array[1], 2) + Math.Pow(array[2], 2));
}

double Sum( double[] array) //сумма квадратов разностей
{
    return Math.Pow(array[0], 2) + Math.Pow(array[1], 2) + Math.Pow(array[2], 2);
   
}

double Sqrt(double sum) // квадратный корень из суммы квадратов
{
    return Math.Sqrt(sum);
   
}

double[] Diff (double[] arrayA, double[] arrayB) // разность координат
{
    int size = arrayA.Length;
    double[] result = new double [arrayA.Length];
    for(int index = 0; index<size; index++)
      {
        
         result[index] = arrayB[index] - arrayA[index];
         
        
        }
       return result;
}

double[] ArrayA = CreateArray(3);
FillByUser(ArrayA);
double[] ArrayB = CreateArray(3);
FillByUser(ArrayB);
System.Console.WriteLine("разность равна:");
double[] diff = Diff(ArrayA, ArrayB);
double distance = Distance( diff);

System.Console.WriteLine(distance);
System.Console.WriteLine(" Да неужели я это сделала =)))!");



