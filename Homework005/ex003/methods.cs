public class Methods
{

    public static double[] CreateArray(int size)
    {
        return new double[size];
    }
    public static void FillArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().NextDouble();
        }
    }
    public static int GetNumber(string massange)
    {
        Console.WriteLine(massange);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void PrintArray(double[] array)
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
        for (int index = 0; index < array.Length; index += 2)
        {
            sum = sum + array[index];
        }
        return sum;
    }
    public static double MaxNumber(double[] array)
    {
        double max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static double MinNumber(double[] array)
    {
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    public static double Dif(double max, double min)
    {
        double dif = max - min;
        System.Console.WriteLine(Math.Round(dif, 4));
        return dif; 
        
    }

}