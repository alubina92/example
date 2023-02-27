public class Methods
{

    //метод создания массива

    public static int[] CreateArray(int size)
    {
        return new int[size];
    }

    // метод заполнения массива рандомно
    public static void FillArray(int[] collection) // метод заполнения массива
    {
        int size = collection.Length;
        int index = 0;
        while (index < size)
        {
            collection[index] = new Random().Next(1, 10);
            index++;
        }
    }

    // метод заполнения массива руками
    public static void FillByUser(int[] array)
    {
        int size = array.Length;

        int index = 0;

        while (index < size)
        {
            array[index] = GetNumber("Введите " + index + " элемент: ");
            index++;
        }
    }

    // метод печати массива
    public static string Print(int[] array)
    {
        string result = String.Empty;
        int len = array.Length;
        int index = 0;
        while (index < len)
        {
            result = result + " " + array[index];
            index++;

        }
        Console.WriteLine(result);
        return result;

    }

    //  2ой метод печати массива
    public static void PrintArray(int[] col) // method of print 
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    }

    // метод нахождения индекса числа
    public static int IndexOf(int[] collection, int find) // метод нахождения индекса необходимого значения)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1;
        while (index < count)
        {
            if (collection[index] == find)
            {
                position = index;
                break; // если убрать будет последнее вхождение. с ним первое
            }
            index++;
        }
        return position;
    }

    //Ввод числа
    public static int GetNumber(string text)
    {
        System.Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    //метод перемешивания массива
    public static void GetMix(int[] array)
    {
        int length = array.Length;
        int index = 0;
        int secondIndex;
        int tempt;

        while (index < length)
        {
            secondIndex = new Random().Next(1, length - 1);
            tempt = array[index];
            array[index] = array[secondIndex];
            array[secondIndex] = tempt;
            index++;
        }
    }
    // Сколько раз какое число встречается
    public static void CicleInCicle(int[] array) //счетчик сколько  число встречается
    {
        for(int i = 0; i< array.Length; i++)
         {
            for(int j = 0; j<array.Length; j++)
            {
                if(array[i]!=array[j])
                System.Console.WriteLine($"{array[i]}   {array[j]}");
            }
     
         }
    }
    public static void Counter(int[]array)
    {
        
        for(int i = 0; i< array.Length; i++)
         {
            int count =0;
            
            for(int j = 0; j<array.Length; j++)
            {
            
                if(array[i] == array[j])
                count++;
                
            
            }
            
             System.Console.WriteLine($"{array[i]}   {count}");
     
         }
    }
    

public static void True() //проверка пятизначное число или нет
{

    int text = Convert.ToInt32(Console.ReadLine());
    if (999 < text && text < 100000)
    {
        Console.WriteLine("Отлично!Проверяем..");
    }
    else System.Console.WriteLine("Число не пятизначное!");
}



}
