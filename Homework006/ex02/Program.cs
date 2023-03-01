//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// y-k2*x -b2 = 0; k1*x +b1 -k2*x -b2 = 0;
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int X(int b1, int b2, int k1, int k2)
{
    int x = (b1 - b2) / (k2 - k1);
    
    return x;
}
int Y( int k2, int b2, int x)
{
    int y = k2 * x + b2;
    return y;
}
void PrintResult( string text, int x, int y)
{
    System.Console.WriteLine($"{text}:({x}, {y})");
}

int k1 = GetNumber("Введите k1");
int k2 = GetNumber("Введите k2");
int b1 = GetNumber("Введите b1");
int b2 = GetNumber("Введите b2");
int x = X(b1, b2, k1, k2);
int y = Y(k2, b2, x);
PrintResult("Точка пересечения прямых имеет координаты:", x, y);
