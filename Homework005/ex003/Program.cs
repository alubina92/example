using static Methods;
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] numbers = CreateArray(GetNumber("Введите размер массива"));
FillArray(numbers);
PrintArray(numbers);
double max = MaxNumber(numbers);
double min = MinNumber(numbers);
Dif(max, min);


