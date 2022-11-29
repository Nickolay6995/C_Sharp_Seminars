/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Третье число:");
int numberThree = Convert.ToInt32(Console.ReadLine());

int max = numberOne;

if (numberTwo > max)
{
    max = numberTwo;
}
if (numberThree > max)
{
    max = numberThree;
}
Console.WriteLine($"Максимальное число = {max}");
