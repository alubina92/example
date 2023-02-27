// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
using static Methods;

int[] numbers = CreateArray(GetNumber("Введите длину массива "));
FillArray(numbers);
PrintArray(numbers);
int counts = Counter(numbers);
System.Console.WriteLine(counts);
