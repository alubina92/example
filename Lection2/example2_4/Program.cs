void FillArray(int[]collection) //метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,10); // обратимся к cvollection и положим туда новое случайное число. набиваем массив.
        index++;
    }
}
void PrintArray(int[]col) // метод печати массива. void - оператор который не возвращает
{
    int size = col.Length;
    int position = 0;
    while(position<size)
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

int[] array = new int [10]; // создай массив из 10 элементов, по умолчанию будет заполнен нулями. смотрим вверх
FillArray(array); // заполнили массив
PrintArray(array);//распечатали массив
Console.WriteLine("Позиция заданного элемента");
int pos = IndexOf(array, 4); // ищем индекс массива на котором находится заданное число
Console.WriteLine(pos);

