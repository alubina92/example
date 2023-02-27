using static Methods;

// дан массив: наполненный числами от 1 до N
// Задача: сколько раз какое число встречается

int N = GetNumber("Введите число");
int[] array = CreateArray(N);
FillArray(array);
Print(array);
Counter(array);


