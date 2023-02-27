public class Methods
{

public static int[] CreateArray(int size)
{
    return new int[size];
}
public static void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
public static int GetNumber(string massange)
{
    Console.WriteLine(massange);
    return Convert.ToInt32(Console.ReadLine());
}
public static void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine("]");
}
public static int Counter(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
public static int Sum(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index+=2)
    {
       sum = sum + array[index];
    }
    return sum;
}


}