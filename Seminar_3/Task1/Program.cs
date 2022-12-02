/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
string? number = Console.ReadLine();
int NumLength = number.Length;

if (NumLength == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Да. Палиндром");
    }
    else
    {
        Console.WriteLine($"Нет. Не палиндром");
    }
}
else
{
    Console.Write($"Число не является пятизначным. Введите пятизначное число.");
}
