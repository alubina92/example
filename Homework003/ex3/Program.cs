// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    
}
double[] Array(int size)
{
    return new double[size];
}
void FillArray(double[] array)
{
    int size = array.Length;
    int index = 0;
    array[index] = 0;
    for(index = 0; index<size; index++ )
    {
    array[index] = index + 1.0;
    }
      

}

void CubeTable(double[] array1, double[] array2)
{
    int size = array1.Length;
    for(int index = 0; index<size; index++)
    {
     System.Console.WriteLine($"{array1[index]}, куб ==> {array2[index]}");
    }
}
double[] Cube(double[] array)
{
    int size = array.Length;
    double[] result = new double[array.Length];
    for(int index = 0; index<size; index++)
      { 
        result[index] = Math.Pow(array[index], 3);
         //return System.Console.WriteLine($"{array[index]}, куб ==> {cube}");
      }
    return result;
}

//int N = GetNumber("Введите число: ");
double[] number = Array(GetNumber("Введите число: "));
FillArray(number);

double[] cube = Cube(number);

CubeTable(number, cube);