using static Methods;

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] numbers = CreateArray(GetNumber("Введите размер массива"));
FillArray(numbers);
PrintArray(numbers);
int sum = Sum(numbers);
System.Console.WriteLine(sum);