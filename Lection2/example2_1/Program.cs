﻿// Find MAX among 9 numbers

int a1 = 17;
int b1 = 25;
int c1 = 13;
int a2 = 17;
int b2 = 25;
int c2 = 13;
int a3 = 17;
int b3 = 25;
int c3 = 13;

int max = a1;
if(b1>max) max = b1;
if(c1>max) max = c1;
if(a2>max) max = a2;
if(b2>max) max = b2;
if(c2>max) max = c2;
if(a3>max) max = a3;
if(b3>max) max = b3;
if(c3>max) max = c3;

Console.WriteLine(max);

// Решим по-другому:

Console.WriteLine("Теперь введем функцию  упростить код.");

int Max(int arg1, int arg2, int arg3) // описали функцию
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int maxmax = Max(max1, max2, max3);

Console.WriteLine(maxmax);

