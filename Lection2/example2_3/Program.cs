// Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find/

int[] array = {2, 45, 35, 47, 113, 59, 23, 33};
int n = array.Length; // ввели n - длинна массива ( больше индекса на 1)
int find = 113;
int index = 0;
while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // убрать, если нужно все одинаковые показать)
    }
    index++;
}

