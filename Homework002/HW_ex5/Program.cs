// написать программу, которая определяет является ли пятизначное число палиндромом.
//Для обращения числа в степени n достаточно использовать метод Math .Pow( x , y ), где x – число, возводимое в степени, y – число, задающее степень.


bool palindromom(int number)
{
if(number/10000 == number % 10 && (number / 1000)%10 == (number/10)%10 )
{
    return true;
    Console.WriteLine("Число палиндромом)");
}
else
{
    return false;
    Console.WriteLine("Число НЕ палиндромом");
}
}
int abcde = new Random().Next(10000, 99999);
Console.WriteLine(abcde);

Console.WriteLine(palindromom(abcde));