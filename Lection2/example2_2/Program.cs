﻿//             0    1  2  3   4   5  6   7  8
int[] array = {12, 45, 2, 78, 96, 2, 4, 56,87};
array[7] = 102;



int Max(int arg1, int arg2, int arg3) // описали функцию
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);

