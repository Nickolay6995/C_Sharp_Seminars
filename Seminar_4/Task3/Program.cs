/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/


int[] array = new int[8];
Random rnd = new Random();

for (long i = 1; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 9);
}

Console.Write($"[");
Console.Write(string.Join(",", array));
Console.Write($"]");
